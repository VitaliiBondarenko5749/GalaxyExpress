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
                    ImageDirectory = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "/UserIcons/Default-icon.png"),
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
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), "a2c39e5c-c9e9-4fc2-967e-f738ce8ea547", "Admin", "ADMIN" },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), "f1bfa24a-e5fc-4f86-8194-1b1088c10ffc", "User", "USER" },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), "416604c0-7cb1-4e4a-9c05-e50b880a0e0c", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3"), 0, true, new DateTime(1990, 4, 22, 11, 2, 41, 907, DateTimeKind.Local).AddTicks(250), 820.054007955250000m, "f4ca78da-0eab-478c-abb9-8eb7e71ca5cb", "Kristie", "Kristie", "Torphy", false, null, "Kristie92", "AQAAAAEAACcQAAAAELPDFUFYVUK7uq6c6KsDk9fM7vH+x9CftCJ6iJumTwWWvOi+dz1FycvxiItgsg5E8Q==", null, "Female", false },
                    { new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), 0, true, new DateTime(1978, 8, 11, 15, 9, 24, 976, DateTimeKind.Local).AddTicks(8522), 192.9424631212730000m, "3e7dea38-d3cd-4b45-8615-20deaa9e465d", "Rosemary", "Rosemary", "McClure", false, null, "Rosemary85", "AQAAAAEAACcQAAAAEJ8iXYeMorJsWsLJHZ4xv5SHDbEuqJInh/o9Pj7iHwXZJNrRgtFxKRw2d2mIE0eh8w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd"), 0, null, 264.2965786549430000m, "e2565786-5ebc-49dc-aea2-14c4e499ebba", null, "Eddie", "Collier", false, null, "Eddie14", "AQAAAAEAACcQAAAAENbQcEOwDu7gItFI4Ez8uSKpOsAV+Pq2cwIddCNqZYnlh91WluGfq5jMGMYIjMUU8w==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803"), 0, true, new DateTime(1942, 5, 1, 3, 18, 37, 287, DateTimeKind.Local).AddTicks(8820), 225.884581898240000m, "6b13b570-c5f0-4f83-9f4e-f34697dc5ee2", null, "Everett", "Fahey", false, null, "Everett.Fahey", "AQAAAAEAACcQAAAAEHefKFgeXaB+RfCohEgKcfDfZAl1fzMSWWD6EA65Ob8km55x643boacz3WXVlyAYFA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("03f69888-97c1-4626-8453-7ac762327e44"), 0, null, 687.7392316362270000m, "17aaecfc-8d92-483a-a437-c1bc0f3d8f2c", null, "Elaine", "Thiel", false, null, "Elaine82", "AQAAAAEAACcQAAAAEOoieO+ZOVY0kGT0fNEj9LIG1H5CYhLbvzoUpV7TcYMG05l+qPzMyT59O6BnjM0F/A==", null, "NotSelected", false },
                    { new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058"), 0, new DateTime(1971, 5, 4, 6, 6, 57, 447, DateTimeKind.Local).AddTicks(5335), 358.8952866319020000m, "c5c4d993-36f8-4f27-9606-7cb2f400bb0e", null, "Latoya", "Lang", false, null, "Latoya18", "AQAAAAEAACcQAAAAELgw/5yYJ/AeqofdRztZeS4q+jH1N5LKeP3TODyZzPjW6AhSvDJo9qGDf/vN8wNY0Q==", null, "NotSelected", false },
                    { new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714"), 0, new DateTime(1949, 3, 7, 0, 58, 54, 472, DateTimeKind.Local).AddTicks(7570), 64.06972372985430000m, "30d7b173-9284-4dd4-9bf6-83a18192b225", "Darnell", "Darnell", "Hegmann", false, null, "Darnell_Hegmann29", "AQAAAAEAACcQAAAAEIA/uLgBStIVzGyEAWiyL3J94HCRDEParERTbj5bu+TlCyqoTauw/plJmKBFVRTA4w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985"), 0, null, 939.9889624679670000m, "a4c7f76a-f5ae-4075-94cd-046b9c020494", "Beulah", "Beulah", "Durgan", false, null, "Beulah83", "AQAAAAEAACcQAAAAEIwX8ienRHwfnifUApBN1i3DntLv1e0Zd+vExQO+z9aOoDFw3q8tg3h4N6xEjgxuXw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("049182ed-f5e3-469d-9878-36594ec23de3"), 0, new DateTime(1987, 7, 28, 3, 14, 21, 219, DateTimeKind.Local).AddTicks(3736), 342.5446003446970000m, "58a75496-a651-4dbf-b327-99549ba578ba", "Andrew", "Andrew", "Hahn", false, null, "Andrew81", "AQAAAAEAACcQAAAAEClEJF8yFdhHXA8E1yhfjJtPpAJLPTteh5IYhxyyMk5xGouSgyOsgLWEXyRnAyQSxA==", null, "NotSelected", false },
                    { new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), 0, new DateTime(1999, 12, 15, 13, 29, 43, 897, DateTimeKind.Local).AddTicks(4097), 652.4879421248810000m, "67e10fdc-8fe4-4d17-b2f2-e30967b8458f", null, "Margie", "Von", false, null, "Margie_Von36", "AQAAAAEAACcQAAAAENfsG7sM1QypQy14gDp1588vWQprGBbfBoxwP3p2oL4VKuhwbLzBV1vIT/qJVjzvvQ==", null, "Female", false },
                    { new Guid("07ad492d-8647-409f-93a7-b4567c04166e"), 0, new DateTime(1956, 4, 27, 2, 18, 3, 328, DateTimeKind.Local).AddTicks(745), 305.2018940944820000m, "9d1dfe33-caab-4133-8b29-372ad99dae12", null, "Alma", "Klocko", false, null, "Alma.Klocko", "AQAAAAEAACcQAAAAEF4Cr3dwQBh1xT3LFhTGzbIFDfec35EjAmLu+ipO9u+6cKmPTHTT1pVQM6Qm97k38g==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb"), 0, null, 907.8048704661650000m, "de0af16f-8daf-4fc4-8380-b43d09a27598", null, "Gilbert", "Beatty", false, null, "Gilbert84", "AQAAAAEAACcQAAAAEFeC2gp8GXCYFmAVF+LZrj/UPNwfymRZtkBLyBDE3DkfvYNxbDXms1IsFhfR09fUFQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), 0, true, new DateTime(1951, 12, 7, 16, 52, 46, 764, DateTimeKind.Local).AddTicks(4420), 901.4970234059620000m, "b56efd0e-0a77-4df7-b11a-0456ca6c5ea4", "Amy", "Amy", "Herzog", false, null, "Amy.Herzog", "AQAAAAEAACcQAAAAEFsQ5Tsg6rDle1U6YNa2doomBXrI4GU3aSRHb0w1PX//IttGV1GTHTGs2qmvtjnxMA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("082d68f3-3ec8-4587-9852-34cd715f794e"), 0, null, 226.1303806800720000m, "e5da5675-ec28-4cce-adae-270b7f066e68", "Levi", "Levi", "Blick", false, null, "Levi_Blick26", "AQAAAAEAACcQAAAAEPzXnkyAl9TN9X0Wf5yHskyLQTEdwHQzx/1oR6QMx2XZS2Yol9dS0q3QTZxbyuuFWQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), 0, null, 939.2599875020360000m, "d3c8b183-d934-4fa3-a4fe-2b095686fbbc", "Naomi", "Naomi", "Adams", false, null, "Naomi13", "AQAAAAEAACcQAAAAEB3xkphqQ1p3k0e/Pe7DRhb/6kDjvRW4i2KCa389UO6N4PhSq9kkTXgk4fek5zbcgA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), 0, true, null, 53.13422657885940000m, "b37d9a39-6967-4247-bbb3-c46a13326676", "Juanita", "Juanita", "Collier", false, null, "Juanita25", "AQAAAAEAACcQAAAAEFvtb2oraTfrPg2smiJ6xMp+5Fk2eKx2cjIa3H6TuBTGi4yiMSLt3hOkOEcMat/NRQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0c876743-f7db-4f0a-8d45-76f35960f834"), 0, null, 35.93882976780250000m, "0182970c-ad03-433e-9ab3-44b8c51e386c", "Perry", "Perry", "Deckow", false, null, "Perry21", "AQAAAAEAACcQAAAAEK0GV6zRZvLjGe/HWfS1iKRnUnWBUUSIr4pDYsXw2JYnBN8Dbx0CI6IeVm+TWZtq+g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27"), 0, true, new DateTime(1992, 7, 4, 14, 36, 18, 423, DateTimeKind.Local).AddTicks(396), 788.7172884561770000m, "155fda23-3e58-4ef7-8005-1246aea4a32e", null, "Blanca", "Toy", false, null, "Blanca.Toy", "AQAAAAEAACcQAAAAEJRDyEYnGnE+R+sb8Xs8twq3vtal3tu0S9MVMjqrb3f9CCcTeLjjVEQhsTreymRPMg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), 0, null, 567.3376225813160000m, "2bf2bcde-9238-437a-bcd4-bfe0cd600f0b", null, "Kristi", "Predovic", false, null, "Kristi.Predovic66", "AQAAAAEAACcQAAAAEC5eWWBNQ6ZwThKuNWB1DYgwCJ7we7aUdkusFV5yZ7YV7KfxNJ0m71JE2VzonatOAQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("0f432380-a89c-4564-a477-a1ed20795e01"), 0, new DateTime(2000, 8, 2, 3, 59, 58, 690, DateTimeKind.Local).AddTicks(1281), 532.8044376068250000m, "38da8351-d2de-4dbf-ae6d-36f089106b3f", "Tyrone", "Tyrone", "Boyle", false, null, "Tyrone_Boyle", "AQAAAAEAACcQAAAAEB3AA8eEO2WmHZL+Y8tzzy2Mvk5HZThh9gSnnbwPndWEaqwqhGFSbsPZb6NFgoIR3Q==", null, "Female", false },
                    { new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), 0, new DateTime(1974, 12, 19, 5, 45, 52, 511, DateTimeKind.Local).AddTicks(7875), 358.4075356846180000m, "ab30dac6-ae47-4623-9040-2d46ba3a9c28", null, "Verna", "Bruen", false, null, "Verna.Bruen", "AQAAAAEAACcQAAAAEGblE7MMwmtIPU5PJXbnZ5fIdLrY+jAS5K28v1T5KA2wpkojqg9l9GEGWyNOOtcGsA==", null, "NotSelected", false },
                    { new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684"), 0, new DateTime(1979, 11, 6, 19, 4, 45, 304, DateTimeKind.Local).AddTicks(4455), 1.411783117368890000m, "8565617a-5f3b-49fd-983b-ca7b54541cc6", "Mary", "Mary", "Lebsack", false, null, "Mary_Lebsack", "AQAAAAEAACcQAAAAEA8XYFtGECtommYSwPeADsfvg/7cVSk5WBE/yMKX2iqlYDIan2d4yanwxxiR/BZHZA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a"), 0, null, 512.5695470860890000m, "4e421edc-e7f3-42a2-9855-3a9bcbcdff4a", null, "Patsy", "Morissette", false, null, "Patsy.Morissette94", "AQAAAAEAACcQAAAAEDfLsxC+lxrtq3MErr+BhsAtqKlDHWfeKpSeNVXBuFATkkZszBGdkqJiaGZxh1t/QA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7"), 0, true, null, 929.7746248053640000m, "3ebfdc83-dfd1-481b-9579-2d48ac787cf6", null, "Sheri", "Ledner", false, null, "Sheri_Ledner", "AQAAAAEAACcQAAAAELsFkKH4QBXJ8YumgqhVLi4DKEtE/GiSU5Ap6hjuBmLCK/iQyL979Iaew+jqMzZfQw==", null, "NotSelected", false },
                    { new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), 0, true, new DateTime(1948, 12, 22, 1, 5, 23, 451, DateTimeKind.Local).AddTicks(3396), 780.34313806970000m, "52e4ae69-ca0e-4818-a7b3-5df02774b56f", null, "Chris", "Durgan", false, null, "Chris10", "AQAAAAEAACcQAAAAEHc/fYNsrAUl5pwEi6d69n44s4ehtBAZ4i/fYDnr8H/FNWYFvN9/X0pWxNDxOPrVbg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), 0, new DateTime(1991, 4, 25, 11, 59, 45, 475, DateTimeKind.Local).AddTicks(4491), 959.6278506826860000m, "077a1203-66e0-4d89-8ed3-8528fe6cd7ef", null, "Jennifer", "Treutel", false, null, "Jennifer.Treutel", "AQAAAAEAACcQAAAAEA8voCi77uMCV5L53/OS+AL0i60poehuUWyid6Xks0ag8tR4Htl/xiM9tuQbIUWWXA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), 0, new DateTime(1938, 1, 16, 1, 27, 3, 737, DateTimeKind.Local).AddTicks(5321), 363.1656928247470000m, "34db40eb-4dd8-43e6-b659-d233b4c8eaf4", null, "Maryann", "Maggio", false, null, "Maryann_Maggio2", "AQAAAAEAACcQAAAAEJu5KGTPv1feDsYc6w9CMgcQUeFAyDAGijAn+HRxaL3Nu3b4hTOegD543dxAB1Xxqg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245"), 0, true, null, 431.2939062789490000m, "e690cce6-a7be-48b2-bf7e-2e4e4abea8b1", null, "Robin", "Emard", false, null, "Robin.Emard98", "AQAAAAEAACcQAAAAEJjalSCiDoqZy6EMeGlfbo8axSocml+plgYjZLL2inKbhx2qv88xOfnoQO/+STK+1A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a"), 0, new DateTime(1956, 10, 28, 4, 0, 43, 875, DateTimeKind.Local).AddTicks(7267), 39.99238667623810000m, "11906744-795f-4e48-a324-55061cb6f8f8", "Andres", "Andres", "Considine", false, null, "Andres16", "AQAAAAEAACcQAAAAEE0jtFZuT7P94FKF88H2y/si/l/g08Bw+0Uk5IWIiuNKqy4CRSI0r0OLS4Tvb8bFGA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b"), 0, true, null, 157.1641253069920000m, "e4216c27-4533-4a6f-b4a1-80b6c7a21f15", "Jennie", "Jennie", "Lemke", false, null, "Jennie4", "AQAAAAEAACcQAAAAEPfjfPbbFFHT5VgH7Pl9rU0mNF1or/oVJgIeSeNFH//IZsLMAdGNAAOIKfl1LZ55QQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("18971e31-ee25-41fd-bafa-129547aefc10"), 0, null, 937.7633186339080000m, "ab4f5c57-c58e-4d0e-8c57-d603e39bbe40", null, "Erin", "Jaskolski", false, null, "Erin.Jaskolski", "AQAAAAEAACcQAAAAEI9wXFtpbOBW9aIvJaKkFNImhX+7xk/DZaHeQ8n6BqHKCBlDynDvA8ewmSvEgNZZbw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9"), 0, true, new DateTime(1963, 6, 29, 17, 27, 46, 830, DateTimeKind.Local).AddTicks(3636), 728.9877724542420000m, "8d57b5ad-3087-488a-850b-2d874dcc57e8", "Jessie", "Jessie", "Daniel", false, null, "Jessie_Daniel", "AQAAAAEAACcQAAAAEL/bq9RZ1fHY0+rkby2rC1YV/BACgTt/n3yMAjIgQ9JgFM6wip8FKH8IZoSBTWZD7A==", null, false },
                    { new Guid("19c67f23-dfcc-4228-91b6-db840755a673"), 0, true, new DateTime(1979, 6, 2, 1, 31, 45, 164, DateTimeKind.Local).AddTicks(2113), 40.06763365525820000m, "0d07decf-d146-4ff2-9f4c-4968753c21a1", "Linda", "Linda", "Collins", false, null, "Linda29", "AQAAAAEAACcQAAAAEBCgQKu7GcqUxfbGB6N19ralLo0FyBJzPsewoDy80mdGCiLbs5h/CXEckMmX/wfDRA==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf"), 0, true, new DateTime(1965, 5, 28, 6, 17, 19, 274, DateTimeKind.Local).AddTicks(3458), 742.9956887482340000m, "b33455f3-aeed-4b8b-9df1-073a4c12865d", null, "Terry", "Frami", false, null, "Terry11", "AQAAAAEAACcQAAAAED04J4PqNmNZ5H5HzxGGrBtzV4/lokWMTGMTpGSSd/vhU6ZeW1/IltgN8rkUNA5Klw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6"), 0, null, 320.3040666862960000m, "e16c4eec-93eb-485b-ad91-d0ac471da5f5", "Kristie", "Kristie", "Grimes", false, null, "Kristie42", "AQAAAAEAACcQAAAAEC0bQYn075nyC50mnjJcy2565/Lb77mFu1aIAgplFtfnVh0QPa/7ZrnFpzYalBYymw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc"), 0, new DateTime(1965, 10, 27, 20, 29, 3, 629, DateTimeKind.Local).AddTicks(9655), 628.0303737695520000m, "50e02709-5629-47c8-8251-6d2c71253c30", null, "Ricky", "Hane", false, null, "Ricky.Hane5", "AQAAAAEAACcQAAAAEM1DDEw1sEPECyt7BDv+ZZ3Ckfq7Vl0uzCxZoVRbckeixvecSGtk61to/0wht/z7tw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20"), 0, true, null, 688.255984597490000m, "9a40d5e2-bab2-4f25-b67f-1146ef1f27d8", null, "Lillian", "Hegmann", false, null, "Lillian53", "AQAAAAEAACcQAAAAEMofFLYIQUsHdWivDtG82Z3LKv72Ltg0GDj+g23htDiq7How1ZX+5RvljLrT/hndDg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb"), 0, new DateTime(2006, 6, 21, 21, 49, 35, 889, DateTimeKind.Local).AddTicks(2095), 733.6964437772880000m, "13b4b9a8-e97e-4c9c-aeb3-0082b9ad7c80", null, "Billy", "Klocko", false, null, "Billy.Klocko36", "AQAAAAEAACcQAAAAEBp04rJFENUZ1QdX37rJ9penbWbeqOAKjk20hMhu7Fh+/MF1cAmka89ITmpKKXN9ww==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56"), 0, null, 691.6653036603810000m, "c82506c5-1f47-4421-b1b9-d37bc9b6c08b", null, "Leigh", "O'Connell", false, null, "Leigh94", "AQAAAAEAACcQAAAAEIGFGuv2hLl7yREL/E5wouM+ZN90AoUcAspknmiyjcHfq7p/oCmW4lqGCPmXir8C0g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337"), 0, true, new DateTime(1984, 7, 19, 23, 8, 49, 557, DateTimeKind.Local).AddTicks(2347), 487.2742788923430000m, "06c94517-7a27-418f-879d-001f1b477bd0", "Pablo", "Pablo", "Mertz", false, null, "Pablo_Mertz30", "AQAAAAEAACcQAAAAECOXLItdaeA2a+A3MiWRP4DTNQTr8B/Sxx/AY4fygzPCkojDOTMx35TWFywTyOhDIQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d"), 0, null, 918.6441346520860000m, "12b9bcdc-148a-45b4-ba33-31e3648aa4dd", "Jeremiah", "Jeremiah", "O'Hara", false, null, "Jeremiah_OHara", "AQAAAAEAACcQAAAAECb6yrre5MGQdfrMKqyF15TwjgS2C+1yyfaBDd78vsiX2FjqonKlLahI+0kyPfPfSw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401"), 0, true, null, 895.1534462992760000m, "8ae836e5-3563-4939-a31a-5357ddbba22b", null, "Alfredo", "Glover", false, null, "Alfredo.Glover", "AQAAAAEAACcQAAAAEPqvVuWohm+8XequrvlH51nuyGJXjLepssOXc1OlilJ4h1RvRNDZV+XcoyqDkRQdmA==", null, "NotSelected", false },
                    { new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08"), 0, true, null, 479.9010841351790000m, "d96402fc-1599-4ae8-a278-67f898bd70d9", "Krista", "Krista", "Beatty", false, null, "Krista.Beatty29", "AQAAAAEAACcQAAAAEJZk5hDIHqV4H7oAS5lNdK/o+7ii+76yL1mgU8S9GdalGlDlnlCcumlRMH7QZld80w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), 0, new DateTime(1932, 2, 16, 13, 16, 11, 25, DateTimeKind.Local).AddTicks(9078), 759.0875677799040000m, "eb7b555e-58e8-4d9d-a36e-1ea23e2084bf", null, "Mary", "Casper", false, null, "Mary0", "AQAAAAEAACcQAAAAEONXQsV/c1k2vaEgTLZ/fw1kVbxKNi5dQ8O5v3yxCOrK4RQ0YGarBP6HPTmLcKyFXg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("21856d76-0810-4123-9f39-8fd468591282"), 0, true, new DateTime(1994, 9, 7, 10, 48, 56, 312, DateTimeKind.Local).AddTicks(8406), 338.8836792287390000m, "7b4dd073-de8d-47b5-bce3-81c8e7267bec", "Edmond", "Edmond", "Marvin", false, null, "Edmond_Marvin", "AQAAAAEAACcQAAAAEEjH0ISh5pA65/9IRPNdYBopQ+5seuB+vOQi4sqpWmU/a0quhrcVk3yIXYqNu58/hQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), 0, null, 931.9462990381270000m, "f00baf69-8633-4b31-b34f-7099652440dc", "David", "David", "Sporer", false, null, "David.Sporer76", "AQAAAAEAACcQAAAAEDB+TDCXeCtrSfo6jcdDmT8ku5cBmwV4hpVAHRwgMwzvl2lyrpjkCJc6GTqDOGRM2A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17"), 0, null, 265.4251089671750000m, "6099cff2-81e9-432b-87a6-2390748f4149", null, "Willard", "Bernier", false, null, "Willard.Bernier", "AQAAAAEAACcQAAAAEFszzV1l136xMHFu0wxMV5Mt3mlJW3J8EPutJKXTBmS9NESkjOlDIPw8PLGcfQNBow==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a"), 0, true, null, 520.9623105633580000m, "9d7812e2-2a0c-4624-9c5e-d614ead3d5cb", null, "Grady", "McCullough", false, null, "Grady.McCullough", "AQAAAAEAACcQAAAAEKgxbHIqwg4aIhcWdy0Wnc5I4xTYWlne1TKmPYHix03XjPKfvtgBmzUUrVLkMFmDWw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("24292576-82c4-4a01-961e-e050d58bf4a8"), 0, new DateTime(1964, 8, 29, 14, 44, 18, 129, DateTimeKind.Local).AddTicks(6756), 322.5522895763480000m, "d13b5843-d7ce-4bf6-ba3f-87e6e122d324", "Erma", "Erma", "Pfannerstill", false, null, "Erma76", "AQAAAAEAACcQAAAAEFiOzA7pPdtCUsreJ6W4k0ZFhgc9vlsfmUnbkHdCi+QyEw2AycpRb7qeohJ/gP5DEQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f"), 0, true, null, 599.139329431060000m, "ad8de01a-6735-4373-ab0d-cdf4f4b55fdf", null, "Ismael", "Smitham", false, null, "Ismael82", "AQAAAAEAACcQAAAAEAo9DA4YVCmyh9P4nO1M+POWNYHCCJZXX7i+R6oAEIO/HIKDm9iiqDae0R/pDa480A==", null, "NotSelected", false },
                    { new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1"), 0, true, new DateTime(1963, 5, 15, 3, 36, 15, 767, DateTimeKind.Local).AddTicks(3912), 937.9883727876580000m, "a466428e-2bef-4ef1-8ea6-5a9b6a9bafdb", null, "Mable", "Krajcik", false, null, "Mable_Krajcik65", "AQAAAAEAACcQAAAAEA1h0Q+/gp+zS2XTEk9xpzWAU1jmvCQ1XFlttt3JyBUGq2pgrQYX5+icIXI5XwaodA==", null, "Female", false },
                    { new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f"), 0, true, null, 611.2403959947760000m, "45a5c4ab-ae02-41c7-95e8-b3981d126509", "Tommie", "Tommie", "Mosciski", false, null, "Tommie.Mosciski", "AQAAAAEAACcQAAAAEOK4DwY7DNT8SPgQ12KUSxr/ovZz9gwRSmluYfjWHvzVa9ppAxJczhbNGGhuv1aTcA==", null, "NotSelected", false },
                    { new Guid("2a24280c-6e79-420d-bd19-903d44c42081"), 0, true, null, 436.8562522803220000m, "ed87f007-466b-4722-a343-d9694dac3170", "Geoffrey", "Geoffrey", "Hudson", false, null, "Geoffrey98", "AQAAAAEAACcQAAAAEJT+CcIj33IMfSk7fKZpj916zx0zi6T+NjqbR6fQUuH3/4xRSEMCxiUAP/pwwsbl0w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), 0, true, new DateTime(1968, 4, 9, 8, 3, 9, 257, DateTimeKind.Local).AddTicks(4644), 920.268344508530000m, "89e7e95d-e119-4f98-9a49-b057cf2fc230", "Jennifer", "Jennifer", "Maggio", false, null, "Jennifer93", "AQAAAAEAACcQAAAAEBDGmedVT52FQu0+GUiRGOQIdrU0QmZfSpbtec5Y5N+ggBzhhrglV4n8fm9oBGa3ZA==", null, false },
                    { new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb"), 0, true, new DateTime(1947, 12, 8, 0, 22, 14, 482, DateTimeKind.Local).AddTicks(6991), 417.965319400210000m, "769c0091-7787-4709-8353-9ada7156c9a0", "Damon", "Damon", "Cormier", false, null, "Damon9", "AQAAAAEAACcQAAAAEOhlR+X5fmy8JlS7JWm9kEYjP/k3h5Kn3G3kb2cq/dWGheH45f9jDZO5ymUPyRyC4w==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("2a7af252-1892-408c-8a62-8885f15e7f65"), 0, true, new DateTime(1935, 4, 4, 10, 28, 6, 408, DateTimeKind.Local).AddTicks(6518), 729.9129959845090000m, "d6dd980a-9ab4-4797-af1b-2071b7c18e8a", "Lorenzo", "Lorenzo", "Flatley", false, null, "Lorenzo71", "AQAAAAEAACcQAAAAEJBXCqDjwDTXGWv8Mki/EhoOMGMcxFhEuQEu98sHm51SfH3yiR8VWi0cm9wkIEJ5Xg==", null, "Female", false },
                    { new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a"), 0, true, null, 417.1330255757430000m, "ed22c3df-76b6-47a8-802f-8458060eb0c4", null, "Erik", "Hermann", false, null, "Erik.Hermann71", "AQAAAAEAACcQAAAAEAiKhipDYMgE3erR6fcH65/fxOP3n9qu6Dm9K/ozU72cqQLZzLbrVLHAj008uXs1Vg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), 0, null, 434.9285670535480000m, "9b01a4d5-2789-42da-a7bc-9084c8284d5b", null, "Ken", "Sanford", false, null, "Ken_Sanford12", "AQAAAAEAACcQAAAAEIYe4BMug1arzlcOxUsgrejrt1XVzbtsUpVnrCaB75ihcpMhBY1Z/l8y/XzzhBQWMQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387"), 0, new DateTime(1965, 10, 9, 18, 13, 3, 566, DateTimeKind.Local).AddTicks(2036), 877.9586136871960000m, "f0bc9e14-f563-47dc-b783-d2be09e4c658", "Gertrude", "Gertrude", "Gorczany", false, null, "Gertrude_Gorczany61", "AQAAAAEAACcQAAAAEG/5n+QfAJ+wIC2p+0uv1PDbPhpZyfh2iZ5dvUofpA1CpyUs9IDZqtouURPNXuNmaQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e"), 0, true, new DateTime(2001, 10, 25, 10, 49, 54, 327, DateTimeKind.Local).AddTicks(4988), 974.7422091803860000m, "0e03b7af-9180-4440-b158-12bcbb12612d", "Harvey", "Harvey", "Blick", false, null, "Harvey_Blick34", "AQAAAAEAACcQAAAAEP/ZnNR8YLGyx5FYmLhzzumur/0hVtLLbkKEIQEUg3RNZEN9MoKei935zyKLgQGzNw==", null, "Female", false },
                    { new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9"), 0, true, new DateTime(1953, 2, 21, 14, 43, 26, 914, DateTimeKind.Local).AddTicks(4753), 871.5838384066430000m, "cc6216b7-9bb5-484f-bd57-67f59c65c184", null, "Myrtle", "Ernser", false, null, "Myrtle69", "AQAAAAEAACcQAAAAEHGg1sWpilPMQyiC4FapcvUc4etEz7R/goWgsty5rXJNQB1A1HwjIUefpn+XOX7XcA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("313a1b63-2c0c-411e-a611-28a27b318502"), 0, new DateTime(1993, 11, 17, 4, 53, 51, 317, DateTimeKind.Local).AddTicks(1146), 729.8451108027510000m, "abee5e6d-b199-4ded-a588-6f6400a71045", "Richard", "Richard", "Effertz", false, null, "Richard.Effertz84", "AQAAAAEAACcQAAAAEBpJJ5B3ay65XJTwgGEzaHZSNOlFyAVjGHkhBGKf2uf+29fMK9W6vsPs0czefLKe5g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a"), 0, null, 560.9644422040280000m, "05611bf7-f4c0-41f4-bad8-8b7b45b072ec", null, "Edwin", "Bruen", false, null, "Edwin.Bruen62", "AQAAAAEAACcQAAAAEIvMEOOQ0D1Gy514JWB7aPEXKdX38yJ0uBxwz5tMumpLkHdV1uiA5Y0RBwpKlZ6ptg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f"), 0, true, new DateTime(1988, 8, 8, 3, 50, 59, 929, DateTimeKind.Local).AddTicks(5403), 201.6075322357990000m, "357286b1-be2b-4ba0-9d25-3bf8b6f5ec64", null, "Beth", "Fadel", false, null, "Beth.Fadel", "AQAAAAEAACcQAAAAEIbDgVgk1VU4HRDV9qg3ENM1Z5PhVxE0GRUTO7N7ex3DuL8GSAj7TvQeLNl8Qcjq+g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), 0, new DateTime(2000, 6, 18, 12, 28, 2, 742, DateTimeKind.Local).AddTicks(691), 348.8885766079620000m, "ed38ba60-1e1e-4554-82c1-d49dbc4d892e", "Jenna", "Jenna", "Kautzer", false, null, "Jenna.Kautzer", "AQAAAAEAACcQAAAAEKQ6oOjygV3wR2M+S8/ms3t3Q+SKYzB/nKJPeM6ZJ0CS0EdFYnfsjT0jcl4Uh52E7g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39"), 0, true, null, 342.4650163508740000m, "10d1ffa2-fc63-4e0b-b676-f254d33ee309", null, "Iris", "Kihn", false, null, "Iris_Kihn58", "AQAAAAEAACcQAAAAEJk6wT2U6BsH2Nn0qJv+FGWub+C/X4XUYmh7I6hn5QoZF+oVpKePYBsSOgNDd2wJ2A==", null, false },
                    { new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), 0, true, new DateTime(1930, 1, 25, 18, 17, 57, 346, DateTimeKind.Local).AddTicks(783), 740.2124250326450000m, "af4c913e-e9c2-48b2-ac98-a73357d1460a", null, "Christie", "Fisher", false, null, "Christie_Fisher7", "AQAAAAEAACcQAAAAEFB0AW6O8+3TE6+jI/gCe7DVBt39x6hVN2rBNSIabHvDqqOzmgj1B93RjITPyU2oUg==", null, false },
                    { new Guid("3725b28a-7101-4f09-b805-78a6947f6afb"), 0, true, new DateTime(1972, 4, 2, 19, 8, 51, 55, DateTimeKind.Local).AddTicks(8431), 55.86345571606070000m, "8c77c0bb-479a-41d5-8c40-7569a3b64340", null, "Stuart", "Wiegand", false, null, "Stuart_Wiegand", "AQAAAAEAACcQAAAAEN2ma3oLSUBny2ilSn++4WN5+vrR+ImXl8qIbGAn6iRvSb+WuVqIFCrq6bOnozDCTw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d"), 0, true, new DateTime(1989, 9, 22, 9, 26, 10, 701, DateTimeKind.Local).AddTicks(2997), 959.7112764968940000m, "aef770f8-584c-4374-8125-e44ed0b11d8a", "Johnnie", "Johnnie", "Padberg", false, null, "Johnnie80", "AQAAAAEAACcQAAAAEBgcF2SyyqtGBq5S6ZJfoigCDs/ZUFcc0wTkxpT4s1eXaoDU37gaCuJro+qNX18jIQ==", null, "NotSelected", false },
                    { new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3"), 0, true, new DateTime(1925, 7, 4, 22, 32, 6, 870, DateTimeKind.Local).AddTicks(1970), 797.4793967357720000m, "314cdbe9-d2ee-414a-a622-9e2b155f4907", null, "Ricky", "Price", false, null, "Ricky32", "AQAAAAEAACcQAAAAEOxnG2dYhf1gCOCiFNNpN1TvfEFrgKmZT4w1TdjsqKkodRkz1JdyxNnGYf/W+A0b5Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), 0, new DateTime(1950, 10, 1, 3, 0, 21, 39, DateTimeKind.Local).AddTicks(294), 641.1868871904480000m, "985e11f9-a6e3-44a1-8dbd-7d4c2f08052a", "Victor", "Victor", "Lockman", false, null, "Victor.Lockman", "AQAAAAEAACcQAAAAEF2+5s3gECpUSPSWPRUWCIItjLEqPt8C3GcbV4x8Gw7D54XNcpBph4JOnAM5WncIog==", null, "Female", false },
                    { new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b"), 0, new DateTime(1969, 5, 1, 5, 48, 51, 238, DateTimeKind.Local).AddTicks(1470), 910.2501404231130000m, "64578b17-7abe-4f27-b578-4ee738597e60", null, "Rafael", "Wilderman", false, null, "Rafael.Wilderman0", "AQAAAAEAACcQAAAAELu0G7Vl4Dffw7H8kd4OV95vNBS0HHQMcZYRKkEeq466PdDOyG4izdyBtIGBwzT3+w==", null, "NotSelected", false },
                    { new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184"), 0, null, 692.6438389817640000m, "9c95bed2-8e55-4e62-9f0f-eb5c98762f69", "Wendy", "Wendy", "Beatty", false, null, "Wendy_Beatty", "AQAAAAEAACcQAAAAEAz8JfFuxIRQAUKQ7X7ItfAbd+feQqMTUMWKPklzRvKyGyEaGr2br6pYvcnE32MuNQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede"), 0, new DateTime(1943, 1, 16, 17, 55, 57, 61, DateTimeKind.Local).AddTicks(7721), 946.4723199156360000m, "c1d2c0d0-b961-46dd-8f83-5649e53ae5a3", "Nichole", "Nichole", "Von", false, null, "Nichole.Von56", "AQAAAAEAACcQAAAAEIW3tjuo49LfEyImklVsMC6EzOmWJMeSuxbU9oAvm9okeM5dtnJtc65dv8nPFOliOQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8"), 0, new DateTime(1997, 12, 8, 10, 7, 50, 188, DateTimeKind.Local).AddTicks(7070), 92.89983991319140000m, "b1f8faa6-40f5-4eba-bd22-930e2cf122a3", "Jessie", "Jessie", "Mayer", false, null, "Jessie_Mayer72", "AQAAAAEAACcQAAAAEHtiiBDeC7o2/kZ+0kLsEAohDoaXHum7BixxZfewzqhkyhECaF8VYM1wBmDexkhQJw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("41296760-deca-4b2d-a760-5538da32ccb4"), 0, null, 534.4002827119940000m, "5ac9660a-5afa-4e01-bb0b-19c4f584613e", "June", "June", "Pollich", false, null, "June_Pollich", "AQAAAAEAACcQAAAAEFFnq6Va2Yc8cF7yn2HmjvYATdrMIhgvq7sSewx4eHaJijv69Je/NWaNR58SaSPqxA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), 0, true, new DateTime(1976, 7, 30, 9, 18, 42, 27, DateTimeKind.Local).AddTicks(1443), 728.5538838120840000m, "9e2331e2-16a5-4ff5-b62d-14108bd0b0e0", "Henrietta", "Henrietta", "Ratke", false, null, "Henrietta28", "AQAAAAEAACcQAAAAEET+xKoWkUkEkZ3/OjduDrPPOiC4O+mO8JopfShhXM3YEd0jUlfiBXrmAigppIHuyg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), 0, true, new DateTime(1997, 9, 26, 9, 50, 4, 74, DateTimeKind.Local).AddTicks(5330), 577.3748904928750000m, "ed10e4f7-0a07-41e6-9715-29f6c3031184", "Heidi", "Heidi", "Hodkiewicz", false, null, "Heidi_Hodkiewicz65", "AQAAAAEAACcQAAAAEMZfLUQ0He2pBcX2F9VUmopUNoZUuY+MH/4ajqaIKp0MSh/ZMS+Djvo8W7dfZWY5cg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f"), 0, new DateTime(1979, 7, 7, 6, 52, 6, 305, DateTimeKind.Local).AddTicks(5644), 458.7788378271650000m, "12339c42-e16a-4070-95a4-af5658f549a0", "Shane", "Shane", "Beer", false, null, "Shane_Beer", "AQAAAAEAACcQAAAAEAONtNmVoKHb5l5UG6K1qKGB+wHJT0MBu87GTtJuf0Fw9mZ7D/NbsUKVnHZPPHBVjg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099"), 0, true, new DateTime(1995, 4, 4, 9, 25, 23, 212, DateTimeKind.Local).AddTicks(3154), 317.4143341680310000m, "ba735f53-e893-4b8f-ae89-2ad968c94004", null, "Ann", "Rice", false, null, "Ann77", "AQAAAAEAACcQAAAAEDcSEYpbyZ6ChNBxoWXJPpJ0BSMLKHnm6iwHRo/O2PuNXWpNiF2zTiA2SosAkKeRGg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35"), 0, null, 773.1139381402750000m, "b08e2673-f121-4f4c-a2b9-258e70d073a4", null, "Daryl", "Kirlin", false, null, "Daryl_Kirlin", "AQAAAAEAACcQAAAAEAInS6t9p4ayCGLzX1Zk7uXNycEY3+xjZFYwr/bQ8QRQgvk+Lkqnl5TPL1NxsVqiFA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), 0, true, null, 151.3187918089960000m, "071393f0-c6d9-4237-b0ee-6aaf57702bc8", null, "Jessica", "Bahringer", false, null, "Jessica79", "AQAAAAEAACcQAAAAEDi2LfTirwUFttn0T2L7ozucw1uIZQrCONRDR8G+/0YgP1NEMgmkDIOrnMs2EY4Nlg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), 0, true, new DateTime(1982, 4, 25, 4, 8, 28, 712, DateTimeKind.Local).AddTicks(8796), 371.5962920247250000m, "5102a6bf-d3b0-4274-84f8-2396c81a20ad", null, "Paula", "Kuhlman", false, null, "Paula87", "AQAAAAEAACcQAAAAEDg24bqGvMBg7Srf/5+9tc6ecA9id0HYjEedWDDcN45ODnxEtfWAHZPRT0qLTuELTg==", null, "NotSelected", false },
                    { new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef"), 0, true, null, 568.1253003093610000m, "efd76c50-a723-4309-9032-a7e1a92688cf", "Patrick", "Patrick", "Larkin", false, null, "Patrick24", "AQAAAAEAACcQAAAAEDnAfBZtnoAU2z6bBzDczdRzAaYUTdhcf/ULPsO/P6f68mS8lpWd+wLzqdNwWDRybA==", null, "NotSelected", false },
                    { new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d"), 0, true, null, 323.0957902091980000m, "d5f91ceb-6b89-4537-9ae5-0b1cf0feb826", "Adrian", "Adrian", "Carroll", false, null, "Adrian.Carroll43", "AQAAAAEAACcQAAAAEEAZi9R/uHhAmkbi8Knezp+0a+4SGEfuJ9CL1RAkvEqcNVGCx5D2+0bP0owjJede1A==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7"), 0, true, new DateTime(1966, 1, 7, 12, 40, 11, 509, DateTimeKind.Local).AddTicks(8462), 676.4329978142030000m, "f4e6bc1f-c0f8-47a7-b10a-b3af33e58dd2", "Camille", "Camille", "Macejkovic", false, null, "Camille53", "AQAAAAEAACcQAAAAEDKbh0hUkDQ/yGks7Rl9D1VS86CyNJLviiPw5hYJwiG0SgJt0Wmw5cwG7Bq7ebgz+g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), 0, true, new DateTime(1994, 3, 24, 19, 47, 30, 860, DateTimeKind.Local).AddTicks(3823), 939.2933356044980000m, "f15420b4-d204-45ac-8967-f6c786230d32", null, "Lance", "Maggio", false, null, "Lance.Maggio76", "AQAAAAEAACcQAAAAEILFa30u5eeu9j2pw53ZYAKeXKrms0W8JSf0P1yfOzkKyxM1crdcThUZqOJBnzHikw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0"), 0, true, new DateTime(1935, 11, 25, 17, 17, 27, 524, DateTimeKind.Local).AddTicks(8150), 904.9251231300740000m, "2d1c4159-c915-4db5-86ad-e6b3c3e16b25", null, "Sherry", "Oberbrunner", false, null, "Sherry.Oberbrunner", "AQAAAAEAACcQAAAAECV1NgljDxU9txzgf4MaR7fn7UyfMoV60XLJjN5WcF/jV1VCJ+3A6WEjXpHWNzvCyg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d"), 0, true, new DateTime(1980, 7, 29, 12, 43, 20, 719, DateTimeKind.Local).AddTicks(3831), 624.8704029928060000m, "1e4edbba-781f-412f-874c-2df8dea3f23d", null, "Geraldine", "Shanahan", false, null, "Geraldine73", "AQAAAAEAACcQAAAAEJsac2zM8X+1veplIPYJJxjFODfyH4/TtVsnFLqsWZDyX7OlxdQWx8wAgP7xgkst4g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), 0, new DateTime(1961, 2, 28, 7, 48, 15, 896, DateTimeKind.Local).AddTicks(7598), 769.0161862881390000m, "72a3c5d7-107e-4ad4-8ab0-0a8b56e76aae", "Betsy", "Betsy", "Upton", false, null, "Betsy67", "AQAAAAEAACcQAAAAEAywY9kVk5YE4REKQ5C2cTNUz6FU5xPvl391HIJgvZOdVUO/jaryRR/qXg3TpDKZCA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), 0, true, new DateTime(2002, 11, 21, 6, 10, 44, 477, DateTimeKind.Local).AddTicks(1784), 300.6969834195560000m, "d5e9167c-db6a-4ae0-a8d6-4acc01691eb4", "Gerardo", "Gerardo", "Mraz", false, null, "Gerardo_Mraz74", "AQAAAAEAACcQAAAAEKwZvPCUxLJSgRyu0Hu9p3rqLpF8u+DXWJc1R5NTQpg0YOMuijxwnfnyW3nkMRig8A==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02"), 0, null, 972.8935921358860000m, "0cba885d-0f0d-47c4-9603-226a028e1da2", null, "Melanie", "Wunsch", false, null, "Melanie.Wunsch15", "AQAAAAEAACcQAAAAECLNEqYN8df4iLQl5pMk9CZeKCCHd0n5YUfJbltWsm7VPknk4G6i7bIhGWRbL8rodg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("501ca405-0708-4624-a634-6510fc3c78d1"), 0, true, new DateTime(2007, 2, 15, 2, 37, 45, 438, DateTimeKind.Local).AddTicks(1167), 405.8309555709650000m, "48f7f0c6-dc5f-4a58-9d18-bf5e972ac39b", "Desiree", "Desiree", "Kuhlman", false, null, "Desiree.Kuhlman59", "AQAAAAEAACcQAAAAEOZ4Nbkzrve/xKJ+vH3JCn7QbOLR77VUd8kGv7amu3ncABhoX1NsrQxIOyuB3L9Ang==", null, "Female", false },
                    { new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), 0, true, null, 22.27691593778120000m, "236616fe-3301-4c62-9ed5-12dde208490b", "Duane", "Duane", "Renner", false, null, "Duane.Renner62", "AQAAAAEAACcQAAAAEEPf2TmTFnpwWFBD+g0MCEkdB382wVDt/WFBHkCtW8IV2nsoxhxgqVxf+NQNwC7alA==", null, "NotSelected", false },
                    { new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), 0, true, null, 670.2096348240130000m, "9ff1d849-cc97-4b3d-a3a8-76dfc0f082e9", "Darin", "Darin", "Homenick", false, null, "Darin_Homenick82", "AQAAAAEAACcQAAAAEGvke7nRgl6Y4sLfoOJcHui/VutFzPM4DYkOVigfnPiFEtzkHq2jKswpV+aILfsmGw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34"), 0, new DateTime(2006, 5, 5, 20, 58, 3, 567, DateTimeKind.Local).AddTicks(4962), 947.9650851251350000m, "32540f78-9c50-415e-b5c7-027f9416c5a3", null, "Sandra", "Hansen", false, null, "Sandra.Hansen", "AQAAAAEAACcQAAAAEF+JkM/ex3rNvlfhgoSG71TbTKL5nD7t65gN2bphMuac2YkAxRC6REiya3/ghwXetg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("51274356-5ef0-4e46-a687-716d200f49e1"), 0, true, null, 517.6507612653790000m, "a041ee16-80b5-4414-9dcd-d7af3abb93cd", "Janice", "Janice", "Johnston", false, null, "Janice.Johnston", "AQAAAAEAACcQAAAAEA0aZZSuF1P628SQ2fKCptzaU8ehYfVynuq4+NxUvjinvnyYtu9rclimnzEsy3f+XA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("53792862-da15-45a1-b0ef-d025a7608026"), 0, null, 669.8579324526560000m, "0c706372-7595-471e-8cfd-ca5c1e00784e", null, "Edgar", "Koepp", false, null, "Edgar_Koepp", "AQAAAAEAACcQAAAAELVh3o96Oo6QopUD3FhcwnRMzAANGGz+wcm9AYSw9auETLfcX1al0OfzKoYuoYAdXQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f"), 0, true, null, 23.89603674637080000m, "5de8d1af-94a9-4123-8c29-b2cf748e7ea1", null, "Paula", "Bartell", false, null, "Paula.Bartell90", "AQAAAAEAACcQAAAAEGbl/yA7sXtA5R6mb/0/Xqd0p59wBOEBkiYQyrBW3Ua56nsd7M/rkrWhEeaHHf0KgQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("57e87c72-5541-4451-bbea-b6a4e815221f"), 0, null, 588.4565991785380000m, "5e903cfd-7ce2-4503-8f56-2d1a38212332", "Julie", "Julie", "Thompson", false, null, "Julie.Thompson85", "AQAAAAEAACcQAAAAEDarFefVoxrrEzIv93zSFPIi7wvlQr76vZEKL2uD3PQvSRs0rLnvX3tcgDqBDDBoAw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("57fde852-8e91-4713-955a-cd98c7327f5a"), 0, true, new DateTime(2007, 12, 21, 18, 45, 51, 587, DateTimeKind.Local).AddTicks(696), 144.6076557003530000m, "a3646bb1-6c14-46ae-b393-91f9ac7fc89e", null, "Faye", "Abbott", false, null, "Faye19", "AQAAAAEAACcQAAAAEEDdiDfoOyoMiXhygIopjhuI4Ltq6TTV/9WYZOtfjb8Vvcrc4PjUfJqp92mW0tDyFg==", null, "Female", false },
                    { new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), 0, true, null, 213.4180380191340000m, "1e8e11ee-1225-4848-871a-144bc1864280", "Flora", "Flora", "Senger", false, null, "Flora_Senger", "AQAAAAEAACcQAAAAEGebJsNhrJCuZI8wVvMhe7sL3CQXNeYITZnVPm4fw/xIgX+A0l5vl0TgZmMO0iV1dQ==", null, "Female", false },
                    { new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33"), 0, true, null, 857.8235216019140000m, "9adc96f4-02b5-4b87-b04a-c1078e924fee", null, "Ross", "Wilderman", false, null, "Ross_Wilderman", "AQAAAAEAACcQAAAAENT9UBlWpdb9ArGX7h1N1aZMN3C5U8tnvnjvrC0Ldn/PE0yhrUhhsu4GmbbW2ubBlw==", null, "Female", false },
                    { new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8"), 0, true, null, 189.6667060752310000m, "43182487-01dc-4227-a479-1ba372d5c2f4", null, "Madeline", "Beahan", false, null, "Madeline38", "AQAAAAEAACcQAAAAEEcPZqyk7x/ecxzeZcZ+2wbZLkZgJmr5DDyLdooXSTSq+E33omhx0cVr+qh7V9yvsQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("5e307603-b79c-42ff-b951-98b55aa9f903"), 0, new DateTime(1942, 2, 2, 18, 12, 34, 589, DateTimeKind.Local).AddTicks(3143), 650.6898767127330000m, "de932259-907d-4d3d-a394-57b80ff48b6a", null, "Eula", "Brown", false, null, "Eula.Brown79", "AQAAAAEAACcQAAAAEOifJwv4qJEAZNi51vCEOYUtgg60koNYHMvj9FeSFVzRSbsIS07OcsD5lr3FddPJNQ==", null, "NotSelected", false },
                    { new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c"), 0, null, 665.384697460680000m, "d1279f0f-a3de-4a14-b0b5-9c757bfe739e", "Penny", "Penny", "Gulgowski", false, null, "Penny.Gulgowski", "AQAAAAEAACcQAAAAEEPsm/MUEzm+85NDWEi/o96TYmDrcxsvVnDFSNqRN2XdB5VcnmllZEtjF5IQOHS7JA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b"), 0, null, 929.3690285803920000m, "9a96b7cf-ea5a-483f-b1ab-914a1ab0ad55", null, "Tim", "Trantow", false, null, "Tim_Trantow", "AQAAAAEAACcQAAAAEM2OetcmiSQ1ZpQ9X9Q1bVstjGSOHHJYKtWFxwRcjRZvryDVmwDcLnuZmc6e3z8//w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("61fe1433-1b16-4004-8246-4e030b366c6d"), 0, true, null, 754.0994206398190000m, "6f5ec03f-7c32-4130-b616-7df566d5fcf1", null, "Daniel", "King", false, null, "Daniel_King", "AQAAAAEAACcQAAAAENeIVPJg2tUly9hF80fFiTtYh0u/6cljFjwrLkP08vDYUCwOuUpjbFAriErU0gnDiQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c"), 0, new DateTime(1989, 5, 24, 1, 15, 25, 846, DateTimeKind.Local).AddTicks(1633), 838.9833960577680000m, "2844871c-6e41-4069-9d02-fbc9abb02d22", "Fernando", "Fernando", "Dicki", false, null, "Fernando.Dicki", "AQAAAAEAACcQAAAAEDX9+5mZ3wWjqj7/d+hDtN6JAwJQjkhNMX+b7tw+sbpLRanbbOjAoHjIvwPNqZStRg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6280e581-a380-4b2b-890d-dced1f97d1de"), 0, new DateTime(1974, 8, 9, 16, 40, 14, 86, DateTimeKind.Local).AddTicks(4695), 359.1402550361070000m, "6196ece8-0f72-48cb-9cd9-82ed3442d266", "Norman", "Norman", "Grant", false, null, "Norman46", "AQAAAAEAACcQAAAAEFSW9PmblxAJgtUQUFid0/LxsOhqS44gU4xGiSDqXMP/3PEGvwGUb1O6NvrU+Ns2EQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("65012c66-d07a-40f6-9789-b100201359c2"), 0, true, null, 173.8857828383240000m, "b112dee2-ffe6-4f56-a161-12dcb8b394f3", "Hubert", "Hubert", "Ebert", false, null, "Hubert.Ebert", "AQAAAAEAACcQAAAAEFxAjP/t7rYbCWVfBNLsz7UJ0xYWxBAiYmii7FfOwNeeHemVAbiZeEiYnEzK7shHYg==", null, "NotSelected", false },
                    { new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a"), 0, true, null, 267.6884145704890000m, "65517d10-517d-4df1-9bb0-173e9edb0dbe", null, "Shawna", "Jast", false, null, "Shawna_Jast3", "AQAAAAEAACcQAAAAEJuEJxZazXSBgOsuR2xRTxxUA2Hla4qZJ2cQm0vX4jgfrOc9rUgJtRbsWggYgqGpYA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856"), 0, new DateTime(1950, 8, 14, 16, 17, 24, 779, DateTimeKind.Local).AddTicks(918), 92.1378609169450000m, "52981a6e-9303-4aaa-bf87-a0a1b91b7768", null, "Nicole", "Schmeler", false, null, "Nicole80", "AQAAAAEAACcQAAAAEMMnnB2WhEaQBVWCtp1EYi2nvXlPHh92CSZyftjgAkxn5YwTBsDp01T8WwBk4QAZkQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("67a0fefa-c903-4326-91fc-981d72b581a8"), 0, true, new DateTime(1939, 5, 19, 21, 7, 2, 41, DateTimeKind.Local).AddTicks(4516), 947.2417244689320000m, "755ba57f-76d7-4f22-9f16-2a2accd65af7", "Mark", "Mark", "Aufderhar", false, null, "Mark.Aufderhar77", "AQAAAAEAACcQAAAAEEAbSkvmr/pRdIi3J8IeKD03nZcX9/Czrk6VMPmNI3rMvte3Q9ZSENqlimFF2fQY0A==", null, "NotSelected", false },
                    { new Guid("68d876f2-c855-4a3a-b244-f66443d9d833"), 0, true, null, 481.5349017631560000m, "80db3345-7d13-407b-a483-8c3e9410b3e6", null, "Ricardo", "Nienow", false, null, "Ricardo_Nienow29", "AQAAAAEAACcQAAAAEKFaXBE04hgvaN3EWmpx9ZoBvKAj4glb6vd9EicxV/p8drtBn4iLAe1Qx8QiDvJcaA==", null, "NotSelected", false },
                    { new Guid("69335634-41ba-4400-a54f-e27126ae5352"), 0, true, null, 238.9959932602970000m, "937beef5-87e0-4596-a9bc-57ee4f28d75b", "Wilma", "Wilma", "Russel", false, null, "Wilma.Russel30", "AQAAAAEAACcQAAAAEMLS4CD37cIGJrN+nqxPtZN5NE+9gkyBEeJog3nCYruhs9/6Vjy7nV6os973xB4zDg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2"), 0, null, 743.089030331260000m, "70928394-1783-4ffd-9265-064683391cd9", null, "Ervin", "Morar", false, null, "Ervin77", "AQAAAAEAACcQAAAAEAXqFYOh1+YtFET7JCtm0TFefq5ccl+UH1ZzqsHvy1iidrYWueYhz/QLsngAWsjbzA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e"), 0, new DateTime(2005, 8, 10, 21, 3, 36, 205, DateTimeKind.Local).AddTicks(2299), 93.12487222619380000m, "135ebc21-b68c-4820-b914-9cdfee04e730", "Herbert", "Herbert", "Reichel", false, null, "Herbert.Reichel58", "AQAAAAEAACcQAAAAEP8OJYYNol25jSvVkNiknUI7/nY8LhIg1OXhC9UDiLOsbSkAs7sxnBndXa7tZIsipQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), 0, true, new DateTime(1950, 11, 29, 22, 51, 34, 610, DateTimeKind.Local).AddTicks(6416), 433.8408240684350000m, "43746311-0ab8-4711-b26b-192a96daa589", "Todd", "Todd", "Koss", false, null, "Todd61", "AQAAAAEAACcQAAAAEPYBo3jZ754iJB4cR2qHB0S1GepgVqHMIFsLq2wSR3/LveaTWObOSBVWQf1VnuLZrw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), 0, new DateTime(1989, 3, 5, 18, 9, 31, 174, DateTimeKind.Local).AddTicks(634), 497.1582881759290000m, "7d6ca493-3333-44de-9824-e01df9c29467", "Dallas", "Dallas", "Gerlach", false, null, "Dallas_Gerlach", "AQAAAAEAACcQAAAAENmz6Jr9yC+FfRUFnXaLbhhH7wUtrGx+IDAg4/Sm14cHkVmb03Smw5s/wO2Y3TcleQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), 0, true, new DateTime(1956, 11, 28, 14, 4, 22, 687, DateTimeKind.Local).AddTicks(2906), 783.5688118962980000m, "f61ccb54-9239-4675-86e3-4b1acb456e74", null, "Ruth", "Wiegand", false, null, "Ruth.Wiegand60", "AQAAAAEAACcQAAAAEI/GRQ3vajLSFSeI7e0HO75xRyxIM1UVjjRR9N2HIqNF42pYVOe3vhUbiaOHkrivgQ==", null, "Female", false },
                    { new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192"), 0, true, null, 902.3876644503040000m, "5550500f-1323-4972-b18c-8f981d9cc792", null, "Abraham", "Wilderman", false, null, "Abraham18", "AQAAAAEAACcQAAAAEGd9axdfNGoqoBpRNS/VGMoDbYRofpX8+/cvtaJ5rjRAUgLhZJkemlAYFPKpb7ZUJg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38"), 0, new DateTime(1977, 3, 13, 18, 11, 4, 640, DateTimeKind.Local).AddTicks(1352), 401.7077370656450000m, "ec765e08-d730-4e56-a7b0-258d21eb36da", null, "Christie", "Cruickshank", false, null, "Christie81", "AQAAAAEAACcQAAAAEK6afy2Oi3djXs9+qCIBCb7EInywt15BQ13+8lI/ekuyMOllwN41b03UeWlXchCAbw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("6e90baa7-8b75-4108-acaa-210af704a12f"), 0, true, null, 814.4775284307880000m, "16e45eab-3d2d-48ab-8af2-1ebe18b9ab32", null, "Nora", "Beer", false, null, "Nora62", "AQAAAAEAACcQAAAAEDkoKn6XUquNxY2zq6wNJR7qwAkRsSP24QOZNqrVX/ogjm6KsUkxlgk+YNVVqFdn2A==", null, false },
                    { new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb"), 0, true, new DateTime(2000, 8, 15, 5, 54, 18, 144, DateTimeKind.Local).AddTicks(1032), 210.3303713652760000m, "eaec6b5f-428b-4dc9-b468-812d636b47f5", "Traci", "Traci", "Lesch", false, null, "Traci.Lesch", "AQAAAAEAACcQAAAAEAZTOFiNVyWNEdGLf0thFrhMOqiMAEHf9Y/n/CW+auth/9XkzqOF5M5tXNYniHLCXw==", null, false },
                    { new Guid("702dc016-070a-4620-818f-b4e492286066"), 0, true, null, 725.3038315161320000m, "2e12198e-ea1f-4a58-b8fc-07f45c13605c", null, "Dominic", "Barrows", false, null, "Dominic.Barrows65", "AQAAAAEAACcQAAAAEL3S+K7C8HeWcg3eZCDipBMFBR8RcxFc3nja+6ILSGUJzQEt6oFftSnm4myFD61pIw==", null, false },
                    { new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), 0, true, null, 286.6719477009560000m, "a8ff885e-220f-4315-9d41-0d0a5d9794c7", "Leonard", "Leonard", "Romaguera", false, null, "Leonard_Romaguera", "AQAAAAEAACcQAAAAEG0UM6w9Wo+NmOcyLlXYUdjjErT+p5GUxHx/5vkSXaqn58JfgyB/Hn7cPJeXSgNWAQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700"), 0, true, null, 725.1803211417920000m, "d5f46bd7-0e1b-4cb2-b092-fe314565c011", "James", "James", "Connelly", false, null, "James.Connelly", "AQAAAAEAACcQAAAAEBGZsueFX3xfrSrPSwRJNebOt37zHRi9Y5GvZSo/g7roKg8axK9dS4FPFIbLos71gg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332"), 0, null, 479.6774118913530000m, "844a10de-93cb-4085-a6e6-8da8331b994b", null, "Edna", "Kuhlman", false, null, "Edna88", "AQAAAAEAACcQAAAAEIwVZubr9O696DMdtP/MeO+BDvhqGFygvp2GP0zz+8PnLG1ueXdb82bQb4HoKTaJbA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("74b3dcc9-46b9-432b-a105-af04273b540f"), 0, null, 649.8396592223160000m, "328c770c-2099-4637-86a7-6fc088bf936b", "Reginald", "Reginald", "Skiles", false, null, "Reginald.Skiles", "AQAAAAEAACcQAAAAEBCQ1RaGBmypy9S/A/1jFeQ10K+iA8mKSKdfApaqnmAzA8n08IwTu8fsYrWKSXDfHQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26"), 0, true, new DateTime(1976, 3, 18, 23, 38, 48, 313, DateTimeKind.Local).AddTicks(6656), 640.0119898177310000m, "a903047c-36ce-4cd5-a670-bed669d6434c", "Hattie", "Hattie", "Hansen", false, null, "Hattie15", "AQAAAAEAACcQAAAAEI892dbWGHFFf6FNhjv0TUAJONZXByY6T7wc+c18Y9sLezhbSm+GL9Gq/qQIklUPFQ==", null, "Female", false },
                    { new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49"), 0, true, null, 823.8730072741360000m, "9c284731-74d3-4ffd-8451-46c892c0f4d7", "Myra", "Myra", "Jenkins", false, null, "Myra.Jenkins", "AQAAAAEAACcQAAAAEMls28d+KS1wdWyyjKun2hW/GrMGz4bmJ9MuS/M/pwWP5NDAmBaFyOG4CUcCqX9KyQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b"), 0, null, 15.88959351800980000m, "1e706484-6bbb-4425-85aa-a03e14cec72f", null, "Shawn", "Armstrong", false, null, "Shawn.Armstrong2", "AQAAAAEAACcQAAAAEL4/an+FOhAwcKttlahAGKQlmDRlY6bTddeE4CeJV5APCuGyGke0aOLEKDkbfnK8bw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("776bae78-ddd1-4162-b313-91943ab9b893"), 0, true, null, 962.8324832424070000m, "015bf14b-a39f-4079-80a8-c291cbb3e196", null, "Thomas", "Reichel", false, null, "Thomas83", "AQAAAAEAACcQAAAAEFtzCRp/Wx40BTo6QiLvhNOlUEFgYDBpw6MrcKSvNN56UHiJiFTF4oNBXUWd1RtbsQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9"), 0, new DateTime(2003, 5, 20, 23, 48, 54, 980, DateTimeKind.Local).AddTicks(9665), 889.9926890914640000m, "5a07991a-9a2f-4d66-b43c-360e73264f6b", null, "Susie", "Stark", false, null, "Susie21", "AQAAAAEAACcQAAAAEMQJRG8+a1xNvv9fYzBaCwgL09jGs5yGaY+fDPYX/6I4fx+0gDXf5whcieHcBkUVjw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86"), 0, new DateTime(1964, 8, 29, 18, 34, 40, 560, DateTimeKind.Local).AddTicks(233), 992.7834537610520000m, "1080a354-5c04-480a-87ae-6065686ba6c3", "Jim", "Jim", "Weissnat", false, null, "Jim.Weissnat45", "AQAAAAEAACcQAAAAELT6G1NcQPxXn7Hu4em76ysWmFpr20XOaqFFOh96Qee05GPNnKrxBbfbUi5HH17bGA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf"), 0, true, null, 703.1287010182840000m, "873ed628-bb3a-439c-98fa-f76a87ed01bd", "Alvin", "Alvin", "Pfannerstill", false, null, "Alvin25", "AQAAAAEAACcQAAAAEO5s/JX4ezkAFXDLW0ae8neED1CWOCvrPCc7QMQjgPA65gSVIUETkYffmAJ8eOi7oQ==", null, "NotSelected", false },
                    { new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e"), 0, true, null, 118.5075620680550000m, "223ac90b-dd8c-4bc3-8698-89d16693c63e", null, "Josephine", "Bednar", false, null, "Josephine.Bednar", "AQAAAAEAACcQAAAAEIzJ8q0aCoJGuUzk0J3Mq8j8nrpKYFEEWfyXmduGSPKckHgCVEX20l7ddtBDv/Wprw==", null, "NotSelected", false },
                    { new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9"), 0, true, new DateTime(1999, 3, 12, 18, 34, 0, 783, DateTimeKind.Local).AddTicks(5899), 766.1182986744030000m, "33ba890f-8f56-4ba1-b6cc-3aed91382fe8", "Bradley", "Bradley", "Olson", false, null, "Bradley_Olson", "AQAAAAEAACcQAAAAEJ2pbf6Ru7jq3ZpXamumhXZl2Md5gCBboJqmrHCmzoo4I86Nlj7Q52bi02yi/VGyLw==", null, "NotSelected", false },
                    { new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), 0, true, null, 972.6549555836990000m, "7c31ea24-7caf-46f1-a04e-4b6761c7894a", "Bonnie", "Bonnie", "Ward", false, null, "Bonnie_Ward14", "AQAAAAEAACcQAAAAEJwk3y7YrzrHHVRz0Bl9lotCYxyHp6Xtp3OS+6rejj0v1cJuvQjrsUz+7YgnUUI+6Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a"), 0, null, 870.4223290844190000m, "7d137360-713a-473f-b151-bbc6f3a498d6", null, "Jerald", "Miller", false, null, "Jerald.Miller", "AQAAAAEAACcQAAAAEDPzGlON9C/QwLh38WbGxsC7zEvnUrPhYoWcgjSsjFPG8WZBAKilV2sEgROQ2yz3fw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e"), 0, new DateTime(1990, 4, 13, 13, 0, 10, 376, DateTimeKind.Local).AddTicks(4475), 959.2864922922840000m, "16eff56a-9da1-4dc7-868e-aa1c2a479570", "Terry", "Terry", "Greenholt", false, null, "Terry_Greenholt", "AQAAAAEAACcQAAAAEIuM9Lko485ZesR1tfNKxELkfuNaPQ7kGOTxxMUxCA5z/B2E64MPuo0ypWLQRYYVgg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8206ebce-6988-4bbe-a696-1449919f6b27"), 0, new DateTime(2008, 11, 25, 10, 27, 21, 183, DateTimeKind.Local).AddTicks(475), 159.4683475407410000m, "2f76ddb2-b81c-407f-814a-eb89e61e96a9", null, "Melanie", "Barton", false, null, "Melanie99", "AQAAAAEAACcQAAAAELDlckQE0CvG2zSYh+BIvH/dPJ9ic8Q7/S+ke1NaLZekj4stiP2Qj49zCGC5V6TNNA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91"), 0, new DateTime(1949, 12, 5, 12, 23, 41, 38, DateTimeKind.Local).AddTicks(3589), 528.6868703233420000m, "533950bd-83c2-4056-a92d-405e3de4c122", null, "Kendra", "Bauch", false, null, "Kendra_Bauch", "AQAAAAEAACcQAAAAEBNUUU297CE3aufu5QsNV3Xdux87qb7dDTGkBYYVH5ZLwqdbL9DQEvcrmB8UjqKTCQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), 0, true, new DateTime(2002, 8, 19, 15, 38, 41, 808, DateTimeKind.Local).AddTicks(617), 855.5667176897120000m, "9415feb6-b1eb-4ede-b627-6c3f9a34bc96", "Edmund", "Edmund", "McCullough", false, null, "Edmund38", "AQAAAAEAACcQAAAAECzA1HQQhtyE9rsjugSWI5Fw8vNYGIveR/T1KqFu0PM5grW2r9EvdYVKr8ItD5AxBQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), 0, new DateTime(1992, 4, 12, 15, 2, 0, 616, DateTimeKind.Local).AddTicks(4744), 848.0141659285460000m, "40692bd8-5b45-4292-bfde-52398f7fc074", "Ira", "Ira", "Cruickshank", false, null, "Ira.Cruickshank", "AQAAAAEAACcQAAAAEDIfnSdvI0S3DJlBes/vtEtNfdEyI/pLWpJEL0R3joce3RoZ+cRvbYit5zpwshHTIw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d"), 0, null, 293.0565794189940000m, "80cf0e44-3521-4a79-9c69-4d1fad0fb312", "Christian", "Christian", "Parker", false, null, "Christian68", "AQAAAAEAACcQAAAAELrpGvCwnVGsNIhCz/54PtIcG0mdgFPvnUIkerhmDL9TvZeE48+i3qoLvprlFJlo7g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8675a226-f36f-438d-8b47-8ae515b842eb"), 0, true, new DateTime(1941, 4, 25, 7, 41, 44, 116, DateTimeKind.Local).AddTicks(3393), 585.3007788701410000m, "8f77c7bc-f119-46a7-b85b-437e8428e408", null, "Priscilla", "Rodriguez", false, null, "Priscilla39", "AQAAAAEAACcQAAAAEKsH0yvV+k+xEmnKOTOOtEWB263O4jHTYGM1pBInYXOEFw49UURS1UQ50moiPt8/Gg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7"), 0, new DateTime(1943, 2, 5, 18, 55, 6, 804, DateTimeKind.Local).AddTicks(1879), 316.7655181285820000m, "73e2a45b-0dd4-450e-98e0-7907e1d84630", null, "Dianna", "Bauch", false, null, "Dianna_Bauch96", "AQAAAAEAACcQAAAAEKno9YWgliP+rbhfBaM07VenwY0Qe0PFRsHfJMRF17XQ1iYwVzF5K3AaGKKC3bWi0A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912"), 0, null, 667.5531663301070000m, "0ea959a8-24a0-4526-a0df-fe978099fbb4", "Horace", "Horace", "Lang", false, null, "Horace54", "AQAAAAEAACcQAAAAEHygZ/nl2nsHBg9o/Ei1bcd/83AhdLmhSloM8GC5JwkI6t6BEAbIELcrNfrSVqXmzA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1"), 0, true, null, 245.6857440041750000m, "de6681be-a1e3-4c5f-9e62-aaee9aa52f3f", null, "Marty", "Schiller", false, null, "Marty59", "AQAAAAEAACcQAAAAEBMvjoyvcJHyNk/zxIbXOXj+B3p0SkgKxzBI7mwuSHJfw0Lh7wEd9xHaZdV1R7eMeg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), 0, true, new DateTime(1961, 9, 3, 1, 31, 9, 288, DateTimeKind.Local).AddTicks(1769), 892.4682147816560000m, "7e2b43ce-4782-4476-90bc-0a6fe5c23dfa", null, "Yvonne", "Zulauf", false, null, "Yvonne_Zulauf", "AQAAAAEAACcQAAAAEHrBPXSmNwORK/CTM2tNKRDFnxqekjY8/J5cDjTFNalP7wiaQa1zgHjfVKvLbV7MZw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), 0, true, new DateTime(1929, 3, 3, 22, 45, 5, 765, DateTimeKind.Local).AddTicks(8636), 361.0425797063290000m, "c683af51-1d1d-44b1-9e93-dbe0f4a7a5e7", "Randall", "Randall", "Ondricka", false, null, "Randall.Ondricka", "AQAAAAEAACcQAAAAEDyG2uogzNswJ337QKeJbGPn0Udkx7Oz6i3bVK1u2m6BdPA72xTloVHup32UK1Sxig==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007"), 0, null, 649.1840223643060000m, "22c9cebf-9965-4c1d-a864-97be10004a0b", null, "Jeffrey", "Ratke", false, null, "Jeffrey_Ratke", "AQAAAAEAACcQAAAAEGcACegJCbiu8IMeF51qeB0qFIacXkQvO77c1/APcGmnAohqMYarJgpn55SXLlulxg==", null, "Female", false },
                    { new Guid("8959e331-7a84-433f-9378-9aad487e24b6"), 0, new DateTime(1953, 9, 3, 6, 26, 16, 7, DateTimeKind.Local).AddTicks(2430), 875.5195306467640000m, "f4b08e6c-0f64-48b1-9cd7-c014f29553a6", null, "Sonja", "Moore", false, null, "Sonja_Moore93", "AQAAAAEAACcQAAAAEAAfu2ZnH03znPsINLhFpmwR+ODP7J/wuHRfXwz15XeOAS7AuTn6cTZ78nlrrcArtw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("8b031351-f694-4f12-b95c-b4d9076da358"), 0, true, new DateTime(1932, 4, 15, 2, 32, 20, 126, DateTimeKind.Local).AddTicks(8343), 405.2333196317640000m, "31b4ae31-b573-4c86-9aca-b1ec866415de", "Vanessa", "Vanessa", "Kautzer", false, null, "Vanessa46", "AQAAAAEAACcQAAAAEKPq+E+D5U9AmLbGga4WmQZ81kPWGQ2mp5kZoQ4pF03Kq8vTQKfQx23v453ukK4S9Q==", null, "Female", false },
                    { new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), 0, true, new DateTime(1964, 7, 16, 12, 15, 15, 553, DateTimeKind.Local).AddTicks(5987), 174.5029659475990000m, "0d18d5df-e82c-4379-98e3-08bd3b29ab4f", null, "Bobbie", "Beier", false, null, "Bobbie61", "AQAAAAEAACcQAAAAEIm/3qbTm5Dv0FkU4u/m4m5JwOOAJV0Zb8+xFnUx76M1XhCeXrS4xNWm6ehTZaCtIg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596"), 0, true, new DateTime(1934, 11, 6, 5, 18, 30, 570, DateTimeKind.Local).AddTicks(3557), 639.7887974550990000m, "181aab55-a9ff-495a-ac9e-33de063af5b8", "Myra", "Myra", "Toy", false, null, "Myra_Toy", "AQAAAAEAACcQAAAAEAAC5gb7uifsuLiBfy2xP+hV95w/4LwncDnMpxSNR4KE3vwu5Whjln1m4uccwDjLAg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("913aac82-79cd-4930-833a-d54464607133"), 0, new DateTime(1937, 11, 10, 6, 25, 10, 939, DateTimeKind.Local).AddTicks(6564), 53.45599115915310000m, "49bfe66e-776f-4491-ab4b-a4c547f8258c", null, "Helen", "Langosh", false, null, "Helen_Langosh", "AQAAAAEAACcQAAAAELrYA9bmPbdrV3BtQIGSGMcPeVZbnKE7PTxIYbaeJgVUZUv7mseOhLSiwiPEgyv3rQ==", null, "Female", false },
                    { new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f"), 0, null, 132.452144787340000m, "6a55add3-4c0c-4b05-bd98-614597aa9d3d", "Pat", "Pat", "Kohler", false, null, "Pat90", "AQAAAAEAACcQAAAAEN9Am80s+2rBVvB3iX4buMrarLYokIXZLJJbLJWKZGslygi5DDnUD0DV+EzHzIC1Yw==", null, "NotSelected", false },
                    { new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615"), 0, new DateTime(1940, 6, 13, 10, 57, 50, 56, DateTimeKind.Local).AddTicks(1719), 518.4085598970990000m, "2124be03-c2c8-4784-9eff-77f54265e5b2", null, "Katherine", "Waelchi", false, null, "Katherine63", "AQAAAAEAACcQAAAAEJnf+KDVjn25Afh+HQhPCLF9gmpmmSQCJk4z67Nai6msylpXHNFmD78iHLlOfGZ1Nw==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969"), 0, true, null, 169.4327140285660000m, "48033b1a-82eb-40fe-8246-66b8c7ffc3a2", "Erick", "Erick", "Grimes", false, null, "Erick_Grimes", "AQAAAAEAACcQAAAAEJ8P42EVm4gK0PUheG1eflFd/Z37q1MnN46mM+EfvyNNagP+X+YxoFQ96GnMwGlSJw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a"), 0, true, null, 945.9673767282480000m, "dff356db-2f56-47e5-98b4-8ebd9bde2d01", "Muriel", "Muriel", "Daugherty", false, null, "Muriel63", "AQAAAAEAACcQAAAAEPjY48DcbOlbwnS4jTXqadyIKsIHWVSR3iI2zppIVb356je3fQ+iTMmvwWoUP0N+pw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("93fc11aa-1d50-4309-844c-1154f207d374"), 0, new DateTime(1946, 5, 30, 18, 11, 26, 265, DateTimeKind.Local).AddTicks(6134), 653.8518640633820000m, "25b4cd5a-04b5-4386-91dd-0a3637244559", "Jeannie", "Jeannie", "Wintheiser", false, null, "Jeannie51", "AQAAAAEAACcQAAAAEEnqDfzDmR6C7Fu1bY0J2ZcyQYXbsgZCk22rajg5gpX99mLf+UnMLth434qGLPThpw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), 0, true, new DateTime(2006, 11, 21, 19, 57, 31, 91, DateTimeKind.Local).AddTicks(3148), 920.2196624141930000m, "a86fbcb8-d686-4de7-ad99-89990dce0a43", null, "Don", "Will", false, null, "Don_Will", "AQAAAAEAACcQAAAAEBoP4F8ijWyJvB3vNPEnBgpqckt8HmjJAV7NMZ45QSDoWCOhlOtL/3nxU/yXIK6sCA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40"), 0, new DateTime(1950, 8, 29, 16, 48, 44, 294, DateTimeKind.Local).AddTicks(8382), 232.5092263852830000m, "0ad2722a-6556-4fa8-8fdd-d4629b4710cd", "Beverly", "Beverly", "Oberbrunner", false, null, "Beverly10", "AQAAAAEAACcQAAAAENRn8D/q2Qly82R8/vFs8lFbwslS2uSYOXKjxmKsprqX7DHf2rglaLCSDORiy5uHkQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6"), 0, null, 412.2764983212490000m, "39bc1776-d5f1-4156-ba33-5f77633f05ea", null, "Meghan", "Renner", false, null, "Meghan10", "AQAAAAEAACcQAAAAEJy8hdYX6aMY1fwufXIZYgRZkapv3QAOdp1Q0/kTcAg39oNywdWdeBFBXiRo6/f2Dg==", null, "Female", false },
                    { new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), 0, null, 237.0176176652410000m, "ccf08efa-6189-4230-866b-6b5ca94084bb", null, "Hannah", "Price", false, null, "Hannah_Price", "AQAAAAEAACcQAAAAEFmRPv/BiVYiHFSTr9vLm1fuVNYlx7AdtCwjqfBkFVv2lK5X+lmlUQIEsGtP0Jibzw==", null, "NotSelected", false },
                    { new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), 0, new DateTime(1957, 8, 18, 18, 41, 36, 783, DateTimeKind.Local).AddTicks(8473), 680.037705662220000m, "6c271188-55bb-47ff-b970-994e84d17847", "Eva", "Eva", "Rohan", false, null, "Eva52", "AQAAAAEAACcQAAAAEAA264Z/hF+1TSffxhUmaT2BCUiCYs7kfbSNcSRplYH6wV/G1OJY9cqGc6Jc5YRjIg==", null, "NotSelected", false },
                    { new Guid("99e79b31-2994-4fd2-956f-0294e124da96"), 0, null, 730.6852440089180000m, "96b00a92-74a7-4702-adb3-e5628a9f8581", "Herbert", "Herbert", "Stiedemann", false, null, "Herbert22", "AQAAAAEAACcQAAAAENC58gniahLVOfK4bx+eT/d7/RoyVzAW5LDrpLKtqCe0zUv+qPEYoiP6M4mvIWV2ZQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("9a57b367-770f-4f86-8d83-869ef37800a0"), 0, true, new DateTime(1973, 12, 10, 13, 2, 21, 630, DateTimeKind.Local).AddTicks(9619), 313.5455247313250000m, "3ba63a1b-c80c-43b1-9215-fe17065eb748", "Belinda", "Belinda", "Gusikowski", false, null, "Belinda.Gusikowski", "AQAAAAEAACcQAAAAEDyx2EKrslXg3czOk3Q2fKm1EiG65Du0SPGzuo+jO/upGaIuDik6SATamTkfBZ3+eA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf"), 0, null, 954.4776263454190000m, "0d6dbab8-8e3d-42bb-a00e-f26109358f31", null, "Ana", "Romaguera", false, null, "Ana_Romaguera", "AQAAAAEAACcQAAAAEGeFNdz5ogKJKLMQWqN0/DO/uv2ETI8qYUxYN3TLlpNjmhkd9hJZR9NIkSHziBSjaA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7"), 0, true, null, 208.6304240194820000m, "aa5fee08-8318-4e41-a174-35b1df11c9dc", null, "June", "Cole", false, null, "June_Cole24", "AQAAAAEAACcQAAAAENhZx4lkTT8BqpyQq1TO2jDSv4jp/Y9PoKPx6jKZ/Ry/4S+9U5Yebd9Z2cfltuDJEA==", null, "NotSelected", false },
                    { new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63"), 0, true, null, 987.1483879792340000m, "049b4c78-24e9-479e-82aa-90153bd9e1c4", "Myrtle", "Myrtle", "Yundt", false, null, "Myrtle_Yundt", "AQAAAAEAACcQAAAAEHNCObLRnJ5jgODz90Z7ExcRBoUAkaCUYNMFNp3LFoE3ZwQys+aNuza70G8bwRcDfQ==", null, "NotSelected", false },
                    { new Guid("a0c72d91-dc13-4995-848c-613286a462f4"), 0, true, new DateTime(1968, 12, 16, 12, 41, 5, 142, DateTimeKind.Local).AddTicks(8721), 184.0477551612620000m, "4debfe2b-8618-40ed-a3eb-27490bf92510", "Omar", "Omar", "Abbott", false, null, "Omar6", "AQAAAAEAACcQAAAAEK4vsSSoNG27awekjBl+4CYfspGgNSp6bTomBqPt8ttSVxYvYUR3qcaqnZNWiW6Czg==", null, "Female", false },
                    { new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75"), 0, true, null, 237.9986669265520000m, "e407d79e-7e9e-4a97-b446-ff54477abe79", "Michele", "Michele", "Tremblay", false, null, "Michele_Tremblay", "AQAAAAEAACcQAAAAECUWAVYNIbJVPKkxGUdnH8t1qFLs4RTS5WeTOG0xNfAVl+h0OHwNcl/1ic0JI2wdcw==", null, "Female", false },
                    { new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), 0, true, new DateTime(1953, 11, 2, 8, 4, 50, 21, DateTimeKind.Local).AddTicks(9270), 511.7533496927320000m, "733720db-2f40-43f1-9d0a-cb4d2b18ba99", "Benjamin", "Benjamin", "Kuvalis", false, null, "Benjamin.Kuvalis51", "AQAAAAEAACcQAAAAECwxYxSEN9knZFRvEYpLqKTUwEEkJrlDS8g7OSvZJzo7ifuGTi7vc1idE5GTmcmN4w==", null, "Female", false },
                    { new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d"), 0, true, new DateTime(1925, 8, 9, 22, 44, 9, 140, DateTimeKind.Local).AddTicks(1745), 302.8338150589690000m, "79c69659-834f-48dc-8f04-d58afac10b3e", null, "Jamie", "Hoppe", false, null, "Jamie71", "AQAAAAEAACcQAAAAEOq3c1oPEgGfrlleNIAHBt1G1SJ94mknbGQzZzIHzPAma0gil+VnVHZd/XSFMoKaKA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e"), 0, true, null, 496.1166282427460000m, "a8395b29-eaeb-404c-929d-dc8da8748aa3", null, "April", "Brown", false, null, "April_Brown85", "AQAAAAEAACcQAAAAEDndKw6t7maen6ZILhHi9jum1mUSzAE5MX9GYAh+1uxLWOx+UEQaryQfvz3ijQHZpg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552"), 0, new DateTime(1927, 6, 20, 6, 2, 20, 811, DateTimeKind.Local).AddTicks(3772), 799.117868269510000m, "6a76d0db-41a4-4b4d-a274-87c7976efd64", "Heidi", "Heidi", "Rice", false, null, "Heidi.Rice", "AQAAAAEAACcQAAAAEESxVtXfD1jvJJ67tvP5/cApGQES26nn7OjRvVWrYAohk4Qox+bkk+V3w0UzstYdEg==", null, "NotSelected", false },
                    { new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1"), 0, null, 15.64399954198210000m, "b154aaca-ab1c-448c-9d7c-cdb13cdfcfce", "Doug", "Doug", "Kihn", false, null, "Doug21", "AQAAAAEAACcQAAAAENaWrkRpC/j86x97DATq8oGcislqvjQpWjFXZsgntdLpwKgOuvz7BNzd3WXMm7Zh2w==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), 0, true, null, 973.9021316489580000m, "4af60a07-8f71-4a23-b946-251cb67ee0d3", "Katrina", "Katrina", "Schuster", false, null, "Katrina.Schuster", "AQAAAAEAACcQAAAAEPadsw6ow+8wwfNuU77XihMzVjDbnzWj0Risfw/rmMDMrrNMjWIJPR27LoGtpjdq6w==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c"), 0, true, new DateTime(1989, 11, 8, 5, 9, 55, 372, DateTimeKind.Local).AddTicks(4510), 396.2286804795180000m, "95941ed7-1c89-4e76-989e-bfa2a0238644", "Beulah", "Beulah", "Pfannerstill", false, null, "Beulah.Pfannerstill67", "AQAAAAEAACcQAAAAEFZrN8BvZWUgOThFuuao9HTkHGVg+rDwH6xiOOaCjdkU2peldNGjXz+v1XZKX2fMfQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a"), 0, null, 441.7816170316940000m, "47ed5485-e6dc-4f52-b8f2-bae475c15d23", "Robyn", "Robyn", "Effertz", false, null, "Robyn60", "AQAAAAEAACcQAAAAEDPJ7rrPJSnA3WX4nx6HoyOQF/3zzVpLZ6L3lV+q9aa04MKVqWyxpFXDYKXYrln+YQ==", null, "NotSelected", false },
                    { new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd"), 0, null, 114.3444709246540000m, "7312f20b-cb21-42bd-b7e0-6526cecfc5a9", "Katrina", "Katrina", "Towne", false, null, "Katrina_Towne", "AQAAAAEAACcQAAAAEF/6tCmRmNXj67l0n+6in7iBPP+yjXlfwdqjPyQ70XRmgkU/sx0bgmtV+7/OSDznvw==", null, "Female", false },
                    { new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803"), 0, null, 278.7050483449950000m, "f45e2ca2-1a08-4caf-a0b2-02c70e907753", null, "Allen", "McGlynn", false, null, "Allen_McGlynn", "AQAAAAEAACcQAAAAEJP5cJGnOMDFKF9xYypVDZZXNbjh78n9LALQOD+jdBVc90rZ7jjwWmIV4HtzTbY7mA==", null, "Female", false },
                    { new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40"), 0, new DateTime(1981, 4, 1, 20, 17, 36, 435, DateTimeKind.Local).AddTicks(1795), 122.6078328635790000m, "c5615e61-bcf2-4cd2-9d45-ed4e2cae4468", "Renee", "Renee", "Johns", false, null, "Renee_Johns", "AQAAAAEAACcQAAAAED1glZnAid0NpH3mBeZM0TSGvdTL9lDS00R6iU1GDUbdX8UEXV23RkZWhX4muahPjA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), 0, true, null, 932.920229321020000m, "df6afa45-f233-4e05-a8d9-792129554d2f", null, "Andrew", "Wisoky", false, null, "Andrew4", "AQAAAAEAACcQAAAAEFE88mtULq1OevTJ8Ram73WyuWNFQbb15znoX9szyn39Uzg4EZSovwt8t9cq2ionTA==", null, false },
                    { new Guid("ad5b9802-88b7-4c47-b138-778817c4050a"), 0, true, null, 665.56175039590000m, "56f68581-b0cd-406a-a2a9-7f502fe89a52", "Hilda", "Hilda", "Hermiston", false, null, "Hilda35", "AQAAAAEAACcQAAAAEKiEf1aebUQy1t2X+i7D21WOZE6NtW4QkaRALNF/tq74bvOVNfzh5k3biwzMXThSNQ==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669"), 0, true, new DateTime(1996, 7, 27, 3, 47, 34, 561, DateTimeKind.Local).AddTicks(3652), 536.5959613874770000m, "c0c104d2-c918-4334-8cd8-aa37c8230b8d", null, "Aubrey", "Pollich", false, null, "Aubrey.Pollich", "AQAAAAEAACcQAAAAEIyo4ZazR/CM1kA4xCpsfkiDjDGpHUwVleMD2cU3NTZcUiIzQpiE7AnHSOSemSGlzQ==", null, "Female", false },
                    { new Guid("afa896ab-be1f-4401-923e-90219b5466bb"), 0, true, null, 582.1015296738550000m, "aabceb23-0e58-4c54-bd0d-597abe5c7f7f", null, "Bradford", "Trantow", false, null, "Bradford.Trantow89", "AQAAAAEAACcQAAAAEKWRg7VLVgVbTONOBQsxcZFO6K729u4gyKXZ0bs9/9HeU8BYEsvu7C2sWosZJtNYeA==", null, "Female", false },
                    { new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6"), 0, true, new DateTime(2006, 8, 2, 10, 19, 43, 768, DateTimeKind.Local).AddTicks(2298), 416.2549049979260000m, "45c7f9b3-e160-488e-9f03-bda5ac383890", "Kent", "Kent", "Marvin", false, null, "Kent.Marvin", "AQAAAAEAACcQAAAAEGOCn8TsgkOBp3jk7lHqJztFl+OGRa9mBr6aDBZCkJrYNothdUgHyEDixKg+LccVkw==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), 0, null, 676.7872134483060000m, "9c870899-576f-405e-8ef9-282eb5597ef5", null, "Mary", "Bauch", false, null, "Mary23", "AQAAAAEAACcQAAAAEBE4u1OglWz0oE+hUowih6GHJlO1R3k/YN2MiJmU2kiWsLds/vJax9rmRJncZyViIQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5"), 0, true, new DateTime(1933, 8, 22, 18, 25, 31, 260, DateTimeKind.Local).AddTicks(1056), 254.4740703235740000m, "b2baa497-aa56-4acb-a452-81f2658fecc8", "Wilma", "Wilma", "Weimann", false, null, "Wilma.Weimann95", "AQAAAAEAACcQAAAAEOcdP/V+QNUgSxmwE2bAJ+0C1OV68kVRhh/vUrICSv7XNuIQlBjpmqNXweoNbFxL+Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7"), 0, new DateTime(1975, 9, 2, 17, 39, 15, 695, DateTimeKind.Local).AddTicks(89), 750.3135459779870000m, "883bbb39-3766-4a4e-b980-97995d6c2c19", "Bill", "Bill", "Kris", false, null, "Bill51", "AQAAAAEAACcQAAAAEMxX5POoodSbDRr1v9imY7QEe9dFgTCjNscN+OzkaKsqeWfglcC/iEcuFOQQkym8pg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e"), 0, true, new DateTime(1993, 6, 8, 15, 19, 37, 166, DateTimeKind.Local).AddTicks(766), 687.22769017520000m, "4f402b57-0581-4d81-b4e5-aafd0d92550f", "Karen", "Karen", "Tillman", false, null, "Karen_Tillman66", "AQAAAAEAACcQAAAAELHsfk/ip54/Gq2q5wYM1Qp1YnGCpyKkMjmrhAeib+Hq8sEnNrJ2+A2+NSc0JtDh/A==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7"), 0, new DateTime(1929, 7, 18, 4, 51, 0, 492, DateTimeKind.Local).AddTicks(2804), 516.1470390793330000m, "5f314d34-119b-42b5-8acb-3314b85058e3", "Randy", "Randy", "Ward", false, null, "Randy.Ward97", "AQAAAAEAACcQAAAAEDeRnOq9wdmeQlnZJ3x6uuvUqR6zP19NACqzemDFwgORTE9NCtK/hWlq6e6LOn2fEQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), 0, null, 839.2513137610280000m, "f96dd171-4fb1-4179-9651-0593511e976a", null, "Corey", "Beer", false, null, "Corey.Beer24", "AQAAAAEAACcQAAAAEKO3Y3StY8ljKLKBV2EZXF50k6fnUpIiTMAJNS/5VAgKUnq1C/7N+0GINEbN3xms9A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), 0, new DateTime(1956, 4, 22, 9, 23, 43, 225, DateTimeKind.Local).AddTicks(1846), 635.9164746421610000m, "60e0621e-d604-450c-98c1-6dc661de41c8", null, "Sonya", "Kassulke", false, null, "Sonya27", "AQAAAAEAACcQAAAAEIrZs9wepMRpNACirx2SHn1ypY14uq13vUnqFjAkQuXOgqUC23hMX/xwzi1vX7lqfQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8"), 0, true, new DateTime(1985, 2, 6, 22, 47, 26, 343, DateTimeKind.Local).AddTicks(1613), 529.7042914324940000m, "31b2f242-7957-4d2d-a858-d0887263e61e", "Fannie", "Fannie", "Skiles", false, null, "Fannie_Skiles84", "AQAAAAEAACcQAAAAEFx4E7Viy6YwoX95cFbSN9b8Ih6Gry6knhZHz8BLS6dWgKRH8jt3uKqrCW/n9zB+hA==", null, "Female", false },
                    { new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), 0, true, new DateTime(1979, 5, 16, 13, 33, 37, 947, DateTimeKind.Local).AddTicks(6083), 384.6596746657740000m, "09e889e9-3700-4352-baae-0976d53534cd", "Ashley", "Ashley", "Funk", false, null, "Ashley58", "AQAAAAEAACcQAAAAEHvaox3vDsURCPGQou/IExyCqR/Ip0oTWAtSAPBC40wObvzFy1KgeTVudRLVqJtLsA==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), 0, new DateTime(1950, 4, 3, 6, 22, 22, 558, DateTimeKind.Local).AddTicks(8050), 904.9288692364460000m, "cafe3e94-3254-44f1-b9d5-4820a987edfe", null, "Sarah", "Casper", false, null, "Sarah.Casper", "AQAAAAEAACcQAAAAEB380fF1AFCoEStAGBhnXty6tCborS7+a+UnTmBEvWETsj7/Hy5UMJqeagltfYwhOQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b6691519-38b6-436a-a19c-602dda7868aa"), 0, true, new DateTime(1950, 3, 8, 20, 58, 52, 935, DateTimeKind.Local).AddTicks(5835), 283.4466712972140000m, "495d409b-d432-42d9-bbfa-b6a4ed57f7e7", null, "Bernadette", "Mayer", false, null, "Bernadette_Mayer25", "AQAAAAEAACcQAAAAEJkJbamoRC3+XD/edkS+aQUA4T1YIzVdHstsrcgpXBr1HZ3Mwx74mEfzf7Nrb5Mrwg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce"), 0, new DateTime(1963, 12, 23, 22, 28, 7, 286, DateTimeKind.Local).AddTicks(2671), 219.5071657635610000m, "cd690d0f-7fd0-479f-807f-d426b11dc0f9", "Spencer", "Spencer", "Blick", false, null, "Spencer8", "AQAAAAEAACcQAAAAEC6i1u1x1F5xTKIDiEBC4QL1enh9YLaIAlrxe2r0T07kQLHj/4api1m1ZM1ycAPfrQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), 0, null, 608.8656831952940000m, "90c94f25-3b5e-4c73-9109-0a2438281f98", null, "Janis", "Miller", false, null, "Janis21", "AQAAAAEAACcQAAAAEObjdaaKOD+08H02a6LF2ayzUxcDFSVi/bC9U7pBnc/b56pvCQJa92BIk9D2jcCwkg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b80d479f-1611-46e2-a055-1de659d203b8"), 0, true, null, 215.2442702065890000m, "b22961ff-2b23-43dc-997e-699084a31786", "Leah", "Leah", "Kuvalis", false, null, "Leah82", "AQAAAAEAACcQAAAAEKHeAtYfOwXMRW+TUzIgU5C/tk1H1N1ZxREGHIPincmWqBL2NK8LWTgXR1ZADUY3nA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2"), 0, null, 502.4065664224510000m, "cb9a2657-ee11-4a4b-b7a0-ca185871a2cb", "Amos", "Amos", "O'Hara", false, null, "Amos.OHara51", "AQAAAAEAACcQAAAAENi07JuWAziFlTTvVcghP5hF9v/z6y4VFoU1DqrU3k1XunsKcsOIj4/UTpEEvTZiiQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), 0, true, new DateTime(1930, 1, 11, 17, 5, 0, 336, DateTimeKind.Local).AddTicks(1235), 680.237806309650000m, "cc5403c1-d4da-4101-aeb0-774a9cc3cee1", null, "Becky", "Howell", false, null, "Becky76", "AQAAAAEAACcQAAAAEPX85p0NVk2plEcf+1KtiKF6Iadp0wOhnQEOf/uJxAbJ4dL7b2njMtZPHb/YJqbE9A==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63"), 0, true, null, 814.4956409649870000m, "d374056e-7632-45c5-9d22-c3bca19d0b68", null, "Verna", "Weimann", false, null, "Verna47", "AQAAAAEAACcQAAAAEN+2Uweizydj1HH8v4tIRQGaSKzHPt5F941SCJLUH1JGtUhvmwT3hE6P47slBq4j2w==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664"), 0, true, null, 622.9943928476280000m, "b58fe734-644f-4703-bec5-d68766d6db34", "Delia", "Delia", "Doyle", false, null, "Delia_Doyle", "AQAAAAEAACcQAAAAEJEyv1N/AHkb9bnyuLgze52qK/1f4fh9QI7fobUxfcaS6tOqDL/OwdoPVNqafz19Bg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078"), 0, new DateTime(1929, 1, 9, 8, 23, 19, 402, DateTimeKind.Local).AddTicks(8762), 805.5405327858360000m, "97b0fdb0-3cab-4228-8d07-ea11787563c1", "Peter", "Peter", "King", false, null, "Peter.King85", "AQAAAAEAACcQAAAAEOr9CxR5XBZ+vUFTcPUc8AwJn6MWFe1XiVbrEnaj4XQgZCnWu8hnBMDcNSgv33GOOg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), 0, true, new DateTime(1982, 9, 22, 12, 52, 11, 49, DateTimeKind.Local).AddTicks(6033), 524.0116050086410000m, "13d2bbdd-e040-4f27-9f76-5160fb18ca2a", "Amy", "Amy", "Huels", false, null, "Amy10", "AQAAAAEAACcQAAAAEHPY/rGnW4El7FNF67hb7U2ncy4jVbWeSDljGSdhYcgHBr6u5OFA0dqAQhG3jBd/7g==", null, "Female", false },
                    { new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f"), 0, true, new DateTime(1961, 11, 17, 16, 12, 36, 902, DateTimeKind.Local).AddTicks(7652), 212.4035947945610000m, "1c3b82cc-f7bb-4fd8-9870-5a00b0656f36", null, "Angelina", "Rath", false, null, "Angelina51", "AQAAAAEAACcQAAAAEPXV+W/QTZKaO1kfCpjsbfwzhoSNx6jluPAWdWFT8kPy/NRXaav3Ri4ovVFHzh8qgQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), 0, null, 143.4379064474070000m, "52f90bcc-02a7-4eeb-86f5-3c0c3ec3d44f", "Renee", "Renee", "O'Conner", false, null, "Renee16", "AQAAAAEAACcQAAAAEBf2PUtiM8+fK+evCQWzCj30Grgub37ECGaNLsJ1jAXAOPhJ2vtrpK/h/v06xsQ4BQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7"), 0, true, null, 811.5849096258340000m, "39c71cac-34e0-43e1-b0ee-337e3784cd5f", "Tabitha", "Tabitha", "Bechtelar", false, null, "Tabitha.Bechtelar98", "AQAAAAEAACcQAAAAEFkU0EABTzW3n0ah+d2jgz6/gplE9fHtau8Sx7n4QgJN53yAIo2fwn/7Sn1dkRrrmw==", null, "NotSelected", false },
                    { new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead"), 0, true, null, 167.8729387742530000m, "798ff6c8-92a9-4aad-bf80-e5064d17ca3e", "Jenna", "Jenna", "Bednar", false, null, "Jenna_Bednar", "AQAAAAEAACcQAAAAEE7qa1G+q/6LcAV02nNr6BxRZ68XSpTRjYgdGm5P2AROiL7GMOXMxQLqsnXeF+9upg==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), 0, new DateTime(1992, 1, 9, 21, 43, 21, 951, DateTimeKind.Local).AddTicks(5995), 378.461295257380000m, "7beb3cdc-6da1-4086-a962-1bdbbe4818b9", null, "Victoria", "Tillman", false, null, "Victoria40", "AQAAAAEAACcQAAAAEDJeSM8wVcyhYTjI8/MzVCQKWBH/pm3eHdzDyrVPiRKfwM2WqlBz4HkC/nIKR9zUFg==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865"), 0, new DateTime(1924, 7, 15, 4, 34, 17, 319, DateTimeKind.Local).AddTicks(3467), 937.0686594607640000m, "20e6e079-6b4f-40ad-b4be-2cb4c46f51c7", "Ruben", "Ruben", "Kihn", false, null, "Ruben.Kihn", "AQAAAAEAACcQAAAAEISBKcO8BVl2rVF/7Wo+NA5S/ZqhEuflc7Fcgp0/g3royH2vf6u0R4pah9703gSaVQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("c184664b-be88-432d-9f74-e8476badaa13"), 0, true, null, 854.8215843628150000m, "6044c0bc-9905-4fc4-9f5e-4def9c2dd195", "Suzanne", "Suzanne", "Stokes", false, null, "Suzanne.Stokes78", "AQAAAAEAACcQAAAAEKQW0TrQHgZc46zJIvwBh/YiTw+Slt7M3ZUIIoRBpWtdq7OffSt+4Wt+1pLHj5oihA==", null, "Female", false },
                    { new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374"), 0, true, new DateTime(1968, 6, 11, 19, 24, 13, 129, DateTimeKind.Local).AddTicks(7301), 710.9236381427880000m, "a471554d-424a-448f-8568-3f625b95a387", null, "Elaine", "Adams", false, null, "Elaine89", "AQAAAAEAACcQAAAAENX/UZrJPe8P/zFLzxLK67ONayYwcUgPHui+5pOzqC5w7LzQU35pkZdNRHjPcQPYMQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), 0, new DateTime(1997, 7, 26, 17, 20, 15, 719, DateTimeKind.Local).AddTicks(7195), 578.8349187842920000m, "8f74435f-dfd7-4599-8478-756a63aa6546", null, "Winston", "Gislason", false, null, "Winston30", "AQAAAAEAACcQAAAAEDxc9K8C12SxQiPvGWmRz8DvP0EE6++viRKyzYaGb64jVv5JBPptyDzEi6iwUBpelQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), 0, new DateTime(1929, 8, 4, 9, 21, 48, 3, DateTimeKind.Local).AddTicks(5795), 885.0188450262630000m, "ee1e090d-6b27-4bbe-9560-dd9cedff7176", null, "Rose", "Bogan", false, null, "Rose_Bogan", "AQAAAAEAACcQAAAAEBkpacwizrnmbru6vJ55oW5NhOU/azzA1Ud3oD17ooOtPr138DkSP3wZbN4tYe5KvA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9"), 0, true, new DateTime(1941, 8, 25, 8, 35, 50, 822, DateTimeKind.Local).AddTicks(8065), 862.3123276773790000m, "3e7fc460-486b-471c-aac3-6a8867c34f10", "Kirk", "Kirk", "Breitenberg", false, null, "Kirk.Breitenberg86", "AQAAAAEAACcQAAAAEKKnA3thKiwA2yZPJMgctLq0Fm2CW39uBZ3KjALmJEFOd9fM3r/Y+3IgvaJRixaEdA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c"), 0, null, 490.971982566630000m, "5ff78855-80b4-4ddb-8745-7a91a1a1eb6f", "Gwen", "Gwen", "Reilly", false, null, "Gwen_Reilly41", "AQAAAAEAACcQAAAAEOaKy3xGhF+ujafIjsDjr/lfQO0wM0i/vwoXl+51uljrj/c9zQHTiZFg2IrqjgQEMQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), 0, true, new DateTime(1957, 7, 26, 12, 24, 49, 165, DateTimeKind.Local).AddTicks(6835), 186.066906526540000m, "33f6e4d1-a39e-4035-82fc-7c1b555cce9a", null, "Willard", "Kessler", false, null, "Willard_Kessler6", "AQAAAAEAACcQAAAAEN7/wmJ5ue0sNp62RTCmhlbUHnnFhMzjq1Ulrhs0WIf+w6RyJIgq71wsqENcp086Xw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), 0, null, 740.7456737552490000m, "2639a9e9-5495-4a85-a559-cecb4e73f293", "Jan", "Jan", "McClure", false, null, "Jan.McClure38", "AQAAAAEAACcQAAAAEM3TnOJsLboMxkZGNoftqeGbt9pN6Uoofhvixizv6J4r56OCQ0qBcFJxgrIBnODxNQ==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ca402be9-4708-4877-ada7-62364da2236a"), 0, true, new DateTime(1997, 4, 4, 2, 12, 8, 236, DateTimeKind.Local).AddTicks(1898), 807.349099392730000m, "b49e6f29-6c6e-44be-b07a-f38f58112d4b", "Leticia", "Leticia", "Wiegand", false, null, "Leticia_Wiegand72", "AQAAAAEAACcQAAAAELum7Yjo1YODYO+I6WOSoxC/7csXh9y0ZEOpTsucZe1MDps7l8FQL0ziwUAXGcFBJw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b"), 0, true, new DateTime(1995, 4, 24, 21, 22, 26, 341, DateTimeKind.Local).AddTicks(6450), 123.1421131143440000m, "55fc375f-109a-4a65-8d6d-f7942b6148bc", null, "Roberto", "Toy", false, null, "Roberto58", "AQAAAAEAACcQAAAAELNjtG0CX1tgHSDA9KESe1Y/1hrtm74S8FSC1OK9o8C3VOIO/iWvBDUCIrq2+VxetA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), 0, null, 379.314847805840000m, "92d34c53-85b7-44c2-a782-6a9b3f365f82", "Grady", "Grady", "Cronin", false, null, "Grady14", "AQAAAAEAACcQAAAAEJlJ4blSoOgV/1miwN72PKBd3KP5UPmsltd3DyF3vZxu3Hs/A1OY/6E1s12OQAfIBw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a"), 0, null, 981.6403684038230000m, "9a31e939-68ea-4644-a572-2bb3f278601f", null, "Andrew", "Marks", false, null, "Andrew_Marks57", "AQAAAAEAACcQAAAAEHY7Vl/MdV/InzEVYM+7F+hO/VeuSu4u4GuS1VAVD1Twkor5VFZm9ackVkZSO31GLA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911"), 0, new DateTime(1969, 3, 4, 2, 33, 51, 135, DateTimeKind.Local).AddTicks(7938), 326.3689743797880000m, "a783dc7e-749d-4ddd-a9dc-20897d9732a8", "Ruth", "Ruth", "Hermiston", false, null, "Ruth.Hermiston20", "AQAAAAEAACcQAAAAEF+HKAWu8bCfbSsebJCISyxxFj5gPrZC3AAEaL+kTX9brLBotuFA5fA9F8xSfTu3mg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032"), 0, true, null, 722.6891181288730000m, "d156c523-0113-45ed-944d-bd37f6fe3d03", "Francisco", "Francisco", "Turner", false, null, "Francisco18", "AQAAAAEAACcQAAAAEBqXe9zwztoK7XEqNDUI3qIjtRuKAsLr8RzkOSs9YuR4TyPXMOmX7OPHS7Js7Jq57Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), 0, true, null, 562.0396231181290000m, "62b6c142-7171-4dd2-b53e-2296c3ddcd9e", "Morris", "Morris", "Lind", false, null, "Morris_Lind", "AQAAAAEAACcQAAAAEMay9o9hiaM1/4JSfm1BwCnmw+lvofUOnzcani8PjpSrXL/d4W5BtyTWS8F5e5tbjA==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6"), 0, null, 140.6738463495590000m, "dc97175a-2307-46c0-ba14-8009494f5057", null, "Colleen", "Cassin", false, null, "Colleen81", "AQAAAAEAACcQAAAAEJImrWQ0CiPVAAc2HQBrAdQ9w60uIBZc+x9OaVQSihs5b+Lc/cdDjbdBYIzfWLysvA==", null, "Female", false },
                    { new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), 0, null, 77.16052180248570000m, "a82e4d5a-899a-434f-915c-c125b06060db", "Alison", "Alison", "Stamm", false, null, "Alison_Stamm97", "AQAAAAEAACcQAAAAEFF4NyFqOARXM/ssfyMhJHNVjLowuSS+W0E40Qprc5KFx7W93RRNTGkrbzDY5p3A0Q==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2"), 0, true, new DateTime(1983, 7, 10, 10, 59, 49, 656, DateTimeKind.Local).AddTicks(5289), 564.5263379742910000m, "c1eda723-b5d4-4771-95af-a4a4fb4133a2", null, "Allison", "Williamson", false, null, "Allison42", "AQAAAAEAACcQAAAAEB+TAIpuwvtaJAn72JpkHZ0mFsC9Ivd6Hh1GtccnSpMS37eF+6XfG3HV2mREZ7aTHg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079"), 0, true, null, 114.1017442775180000m, "fd35300d-8728-4f26-a290-90d177525842", null, "Olive", "Langosh", false, null, "Olive3", "AQAAAAEAACcQAAAAEOySagLIQ/IYYOabKkeiTJyD4uGbiiRzrPimebTmzYbCKXQ2IGWD+EzpECXFXVRnMQ==", null, "Female", false },
                    { new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5"), 0, true, null, 593.1014937028150000m, "6a35d336-c506-43ff-929d-6030edb8dca1", null, "Darrel", "Rolfson", false, null, "Darrel_Rolfson", "AQAAAAEAACcQAAAAEEzrG6MYW6TvnQYmPNsgqcgnXF/xQ5cpceSSxD41RcQKoz4pzwBqW5xhDNe76ieGTw==", null, "Female", false },
                    { new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b"), 0, true, null, 583.7396239703370000m, "e56bb02a-c36f-4739-8d3d-185ebee89423", "Tara", "Tara", "Dooley", false, null, "Tara73", "AQAAAAEAACcQAAAAEAXugRB34gWLlIdkaFy89xllDEOP8aTQ403UfeCz1hIVkMcFvci24ClCQHoMddMWxQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), 0, new DateTime(2001, 6, 15, 21, 32, 8, 807, DateTimeKind.Local).AddTicks(2559), 543.1618554669280000m, "603cc350-fb72-498a-a113-3b7aa59aba2b", "Glenn", "Glenn", "Labadie", false, null, "Glenn98", "AQAAAAEAACcQAAAAEMZ8jGjx0Y5eQMZHDIkuViGCltRcmE3E9DsUApeaGXc2zirbDnfAeEwCQWAlCBFqww==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), 0, new DateTime(1947, 9, 9, 8, 57, 47, 784, DateTimeKind.Local).AddTicks(7151), 805.1143375409270000m, "7dab88d5-8ec5-4fd7-abe7-7edbc0ea889c", null, "Jack", "Bechtelar", false, null, "Jack71", "AQAAAAEAACcQAAAAEPrHRl2859akzXXAenUq4OqWKcaRFTr+izwGAnLdP/ILXzeR3h/Vnol6fzkxNtM3uw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("db79945a-0e64-4c97-801f-a38a1e357d12"), 0, true, new DateTime(1979, 6, 15, 2, 16, 21, 404, DateTimeKind.Local).AddTicks(1449), 708.7830412224920000m, "8ad1c2c2-758b-4f50-81c4-929594b39c2c", "Viola", "Viola", "Walker", false, null, "Viola.Walker", "AQAAAAEAACcQAAAAEJk4pNMVM7+lW7MywyUzi9mdYIGb9CC8F9SLfT+zo8b3VOvq1VhsYfn+OSRy/ff0zA==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), 0, null, 821.0772104773950000m, "f9f15894-5c78-4b38-94f2-6d22b5e8fcf4", "Deborah", "Deborah", "Barrows", false, null, "Deborah.Barrows", "AQAAAAEAACcQAAAAEMu21yfSWq54ucomqprmc++a4AQcqr9pLjFEUNhAoDk9Nyc90n1+cnolukAmg/FbCw==", null, false },
                    { new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01"), 0, null, 109.8656806466190000m, "3fd6fd6f-794b-40ff-a90d-f78dc7a1e593", null, "Angelica", "Schimmel", false, null, "Angelica73", "AQAAAAEAACcQAAAAECXdyQhE4b7YP1nqnpeJ7mzFlW0Ba8nlOMwu5aZIsgtaiLF3crVLFc4MfA9SeHo6OQ==", null, false },
                    { new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553"), 0, new DateTime(2002, 2, 4, 12, 43, 57, 712, DateTimeKind.Local).AddTicks(421), 616.6627713925580000m, "dbbf35f4-f5cd-4cbc-9851-aec04f5ed2f9", null, "Florence", "D'Amore", false, null, "Florence_DAmore", "AQAAAAEAACcQAAAAEAk8pTQjyJPiVzpV8rYZCbOrJKyr4EzCK7N4ukVXGxUnpG7rmXIAMrio2aqpW3kolw==", null, false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("de7d9783-5299-4552-b426-e13c1b4a4995"), 0, new DateTime(1974, 2, 10, 22, 31, 47, 134, DateTimeKind.Local).AddTicks(4129), 992.9699305095620000m, "b3a7ab89-4d76-49cd-b27e-a19a64f028c5", "Johanna", "Johanna", "Kirlin", false, null, "Johanna_Kirlin56", "AQAAAAEAACcQAAAAEH0xo0Zlq6DDKqZ9ciV5b2n8/sBj1dKAM+xzcK8LFftFIuGHYCdnBGVmUTi7u9vgIQ==", null, "Female", false },
                    { new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), 0, new DateTime(1980, 4, 26, 16, 33, 26, 452, DateTimeKind.Local).AddTicks(8207), 120.7334775329790000m, "bc852238-f0ef-403d-9115-b3883e2e4a4b", "Maggie", "Maggie", "Ritchie", false, null, "Maggie.Ritchie", "AQAAAAEAACcQAAAAEKraqFPqPdRDW0cu6FWWq1oMkb27GkQjb1jPmca2p930jYwtjktKMuQGHqs3+yKUeg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6"), 0, new DateTime(1996, 7, 27, 10, 39, 49, 912, DateTimeKind.Local).AddTicks(1231), 1.52772474715090000m, "8456bf44-4311-4335-963e-bd7e3153315c", "Casey", "Casey", "Brown", false, null, "Casey_Brown18", "AQAAAAEAACcQAAAAEGlJRbMBAIC+9syWatpP2ZoMa5uoXz5Csmjfac+PFjSaXMdmmUbehU2JhW8ivgcLqg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf"), 0, true, null, 353.382346566850000m, "47d9d309-0c44-46a4-aaf1-8259b7785993", "Moses", "Moses", "Tromp", false, null, "Moses_Tromp", "AQAAAAEAACcQAAAAEGjBQvAJF3DR1am9PAOSZAkmUZkm303kwQZGNe9CFxQ2vNzXLYIGHgjkjdN8sbEBoA==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), 0, null, 424.5163627325720000m, "5ec76133-2adb-415a-a460-62a60028b91b", "Blanca", "Blanca", "Feeney", false, null, "Blanca_Feeney33", "AQAAAAEAACcQAAAAECJTpP+5hiY+C6SVklY6mGBTq+XoCaZp6k3Xbxxtt22v3veNhHxmEYY66aaxMQ61Pg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809"), 0, null, 578.3227980864980000m, "5f5a63a0-94bd-4ae2-9e1e-a788e92a6111", "Delbert", "Delbert", "Koch", false, null, "Delbert_Koch", "AQAAAAEAACcQAAAAEPqiDEgbIOICqdUUS9i7q4HzpPXtOWn1clzo2kVkRbwHfNCG64bhgqWvi7VFTvgc9Q==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), 0, new DateTime(1946, 3, 16, 8, 17, 50, 858, DateTimeKind.Local).AddTicks(2926), 893.0578946554210000m, "3db33229-7d78-4c81-90ed-aa54127caaf0", "Katie", "Katie", "O'Keefe", false, null, "Katie.OKeefe85", "AQAAAAEAACcQAAAAENvzzemmPK6eC7iSBzLm9v+W9YtKYPZmji3nNk0ju43itkHYyacPlKtwZA/Qqp2N5Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), 0, true, new DateTime(1997, 3, 30, 9, 29, 17, 216, DateTimeKind.Local).AddTicks(8546), 576.089298807070000m, "3ff07d60-bc69-4b1e-a0f7-adcbca113691", "Kristen", "Kristen", "Zulauf", false, null, "Kristen_Zulauf71", "AQAAAAEAACcQAAAAEFfp3xlXvvN/GxJM1TG1bT5vpqCjbZHwJ6EaplehArNiM4H+2N6yGMgGp0hha/7d8A==", null, "NotSelected", false },
                    { new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d"), 0, true, new DateTime(1934, 6, 4, 6, 8, 35, 926, DateTimeKind.Local).AddTicks(7641), 968.217235493020000m, "c7ff0b2a-f093-408a-b903-e9c056586126", "Matthew", "Matthew", "Abernathy", false, null, "Matthew_Abernathy", "AQAAAAEAACcQAAAAEDlReo8rgn1mDvC/VR6mV2yIOJ1y7UTt09SMRk1iySy5SXu0YtdUVzHAL31Aoi4njQ==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0"), 0, null, 446.9618523323390000m, "012bfce2-fed2-4d79-acec-68adddb6b002", null, "Lauren", "Douglas", false, null, "Lauren.Douglas", "AQAAAAEAACcQAAAAEHvP1oMCTLfcGj7dI1IQwfSOOw9CxAOx+42snsS2AHIzs2omsqKFUk9z3oFHaGWhLA==", null, "NotSelected", false },
                    { new Guid("e698e260-89e1-4c83-b493-1379542f5647"), 0, null, 328.3279090158340000m, "febfc183-1612-4b0e-ab26-8cbad531ab29", null, "Ruby", "Goldner", false, null, "Ruby14", "AQAAAAEAACcQAAAAEEaSWr1lW0whJGwPDC918FJTf0OdjYkri1eX/8MUUdRUT4pzbD1W2btZ3DohPSuhZA==", null, "Female", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37"), 0, true, new DateTime(1936, 4, 7, 5, 21, 47, 399, DateTimeKind.Local).AddTicks(1169), 318.4728670735930000m, "3b45b36e-6f8b-4ebb-9590-fa43d586bfc0", "Tanya", "Tanya", "Reynolds", false, null, "Tanya.Reynolds", "AQAAAAEAACcQAAAAEO8zirSrshyBBhbQFQFzg+W4lbLmTJvlWTjXVPSe+syIU8ajLh3v+RoAl+OWUsQxJw==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757"), 0, true, new DateTime(1943, 4, 18, 5, 46, 55, 263, DateTimeKind.Local).AddTicks(7600), 393.7130819742060000m, "44e1966b-8cde-4114-b4f1-4318c183322f", "Bradford", "Bradford", "Ankunding", false, null, "Bradford.Ankunding58", "AQAAAAEAACcQAAAAECGU9B8kDZh49wzBGoycClxzOygAWgqocYlCajnGVr1feK3RV+f0AE2+Ah9lbkRq1Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b"), 0, null, 538.9207705845580000m, "112ab2f0-3881-420a-91fd-8d03239c5521", "Elizabeth", "Elizabeth", "Gleason", false, null, "Elizabeth.Gleason", "AQAAAAEAACcQAAAAEE4dBwf9jsOzWsIoAJsUqHmUyRVt8NM3OtTtzY4JCSG/ccVWCaNNWBRi74Qxmc42ZQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9"), 0, true, null, 377.7246684575810000m, "4407b300-8649-4114-b39e-a3661e175327", null, "Cesar", "Stracke", false, null, "Cesar.Stracke48", "AQAAAAEAACcQAAAAEGI93qXfTl2GDbUlLqpGnDAcMjSQ8KPjzr7u84Ve+hNKjQecBAc0Ji+ZzHRBKs1BZQ==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf"), 0, new DateTime(1938, 4, 14, 17, 1, 37, 537, DateTimeKind.Local).AddTicks(1939), 223.6818599290230000m, "7dd947da-d322-41b8-8c5e-11450e2171c1", null, "Harold", "Schamberger", false, null, "Harold23", "AQAAAAEAACcQAAAAEN+E/fCP2DkHLMFKOPn5/fzBS/3YkDnpmmcVFNSoleq0NrjSWenT8WkEKq4XkTYazQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f"), 0, new DateTime(1932, 6, 16, 11, 5, 2, 18, DateTimeKind.Local).AddTicks(3205), 46.47037659583460000m, "b3a78693-4602-4db3-a43e-f13cae7ff3a2", "Bradley", "Bradley", "Marks", false, null, "Bradley7", "AQAAAAEAACcQAAAAEG2Xq9PuNh5bNHxxs1d3xScNWESened4r5IuHbeXzsCrv4wSr2mNjjppyzzW8b3aCw==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e"), 0, new DateTime(1979, 11, 7, 15, 19, 27, 158, DateTimeKind.Local).AddTicks(5440), 456.6037787681460000m, "da77954c-ba95-4d9b-a018-4d9028d187eb", "Gerard", "Gerard", "Hermiston", false, null, "Gerard_Hermiston", "AQAAAAEAACcQAAAAEH0t2wAdniic+K9jaqU67QuTHXwy7dPYv5bButykW+mNhPnyAJiOP1QFFM6ftf78+Q==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("edf37002-a546-4d28-acd9-2614759e640d"), 0, true, null, 150.7732173666240000m, "85145c99-a55d-4eb7-a68c-661c790213e1", null, "Sue", "Gottlieb", false, null, "Sue36", "AQAAAAEAACcQAAAAEKkDFKkdo3V5mggPFrbrg1xnZeztiXF/4KGaIhy13Y7qiPBRl4n6qVtjWF4kGquVVg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab"), 0, true, new DateTime(1947, 1, 24, 1, 49, 33, 362, DateTimeKind.Local).AddTicks(90), 106.5320615165270000m, "9c572fab-43e6-4514-a2ee-ed9312843ca5", "Robert", "Robert", "Roberts", false, null, "Robert50", "AQAAAAEAACcQAAAAEEk588NnzDUPyCYzczJGBuSseikmqnp8mr5n8xz/8sywGad70XuulTTVRNzvsRJ+1Q==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), 0, new DateTime(1977, 7, 13, 12, 27, 32, 25, DateTimeKind.Local).AddTicks(8851), 523.4560425921470000m, "ceea5ad4-1ee5-4b65-8c81-5580db0cb65d", null, "Trevor", "Adams", false, null, "Trevor17", "AQAAAAEAACcQAAAAENt3arOek7oOybDoUQacC4Ncrof94t1Gz7uEyJ4UAykag/npVUiEZynKQl2Jzo5fgQ==", null, "Female", false },
                    { new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f"), 0, new DateTime(1988, 5, 6, 11, 31, 3, 492, DateTimeKind.Local).AddTicks(3580), 6.806481221455880000m, "44401f5d-454e-4963-a930-04166e8a188c", null, "Christie", "Lynch", false, null, "Christie.Lynch56", "AQAAAAEAACcQAAAAECrepEDQU0acYUU/xqa0FTUyjpIzdGarA1x+9YGJpCv1rwxi2R0ovwt87MYpyI/dFg==", null, "Female", false },
                    { new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), 0, null, 617.1791096543280000m, "e77add09-c745-4bc0-b879-45307db94a05", "Joshua", "Joshua", "Skiles", false, null, "Joshua_Skiles93", "AQAAAAEAACcQAAAAEGE5V6+uS4SyfMKquMXO4K85j74pdaBQId1wZ39gt9V7xGmgE/tQjOQACNN2KtiLqQ==", null, "Female", false },
                    { new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197"), 0, null, 683.6794963259180000m, "f83c1eb3-0097-4f0b-89c9-a722046222e9", null, "Gerard", "Lang", false, null, "Gerard.Lang", "AQAAAAEAACcQAAAAENHma+zqpO2NNBVSxq5M5jNJV7gNryt6VVKfv0F3n0RbWMWWLt82AyidVIie5vJtMg==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[,]
                {
                    { new Guid("f4943944-5289-42df-aed1-a6281dd934db"), 0, true, null, 424.8965285118910000m, "09ae0bb1-71f6-4418-b4c6-c2112fc6eb60", null, "Faye", "Harris", false, null, "Faye.Harris", "AQAAAAEAACcQAAAAEKQO91zH1Pg6x14KoM5EMjkNzGIBj0u1mCuN7e5IXWrM/xxgSl3z4kYk+9yGXeF1kQ==", null, "NotSelected", false },
                    { new Guid("f50dbc58-9b0d-479e-8402-e939027091e8"), 0, true, new DateTime(1954, 6, 20, 4, 39, 38, 819, DateTimeKind.Local).AddTicks(1131), 250.7001436278750000m, "8a41f740-89e8-48c0-8c4b-a0f5a8d41fde", null, "Colin", "Padberg", false, null, "Colin_Padberg", "AQAAAAEAACcQAAAAEB0D2Qp0Zy4zDImAjfOpX1rzMiFaYgmxTKOGg9yx6pen3YsEroBiwiOX+hVP9H5kqQ==", null, "NotSelected", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094"), 0, null, 933.6255815895340000m, "d185ba45-99b1-4d21-bdb3-3d7bdbba0e7e", "Luz", "Luz", "Roob", false, null, "Luz62", "AQAAAAEAACcQAAAAEPjAb0j97OtfKvG/JhYefx4HMAfbQHkXJssg6g5GuhLjnDNL5b8lF13kfGKdslDW/g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d"), 0, new DateTime(1928, 1, 3, 2, 58, 27, 955, DateTimeKind.Local).AddTicks(389), 177.1503784677380000m, "3c13e7fb-b1cd-4a67-b5c7-a2b30420890e", "Mindy", "Mindy", "Barton", false, null, "Mindy.Barton53", "AQAAAAEAACcQAAAAEPqgQP0+9+oGZQfDfY/Q0rKLyNSlJoZKyK/fYSUiRs724Uuj0s4nHXgiKXreEs/6Sg==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea"), 0, null, 70.73929313781160000m, "57162292-c47b-4d7c-ba95-df06e64b3d5d", null, "Earnest", "Spinka", false, null, "Earnest6", "AQAAAAEAACcQAAAAED4EnHy1Hf11+4hL86WI5cvonTGeSrokK30IwRp1xTtmfbJlp4CQGZligU4fFkCZlg==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328"), 0, null, 776.0634567447110000m, "b9531e4e-7ebe-4ca4-87fe-bde130d15a62", "Esther", "Esther", "Runolfsson", false, null, "Esther.Runolfsson", "AQAAAAEAACcQAAAAEHH5rA7Jjs53yf9COpz+eEtKmjCgd95Dt/aXcy6AG0oJBHSrtvVtHRI+gueWAo5m0g==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "TwoFactorEnabled" },
                values: new object[] { new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb"), 0, true, null, 666.9377688278890000m, "48691616-b523-4d6a-b4ae-90e313cbf6e3", null, "Rick", "Kohler", false, null, "Rick.Kohler96", "AQAAAAEAACcQAAAAEAlgMPbNLZ0ao7WbZUUWVkJ607h+pwLp71lBMhu0zHKk55gC/S5MvQkvpWWTe3OQaQ==", null, false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093"), 0, new DateTime(1984, 4, 24, 10, 21, 20, 597, DateTimeKind.Local).AddTicks(6026), 532.3315200736680000m, "a9a6395c-5142-4f62-ac9d-2365c60bcd0f", null, "Wanda", "Senger", false, null, "Wanda.Senger22", "AQAAAAEAACcQAAAAEDzJCtPkhUb2n//AnTbga2/yJnhxM4Dz/xjzS9uOQoTiguMxKiaPuzVkFwXIxoWvew==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7"), 0, true, null, 366.241684193770000m, "ffc50017-4546-4b33-8333-55998ead8058", "Tom", "Tom", "Gutmann", false, null, "Tom_Gutmann95", "AQAAAAEAACcQAAAAEF7CmG+Vo/XL+ctwnmsr0MwoawfJDuYh7qFpR90nHo6m1VaZr3EcZaPnK2yvoHRv7g==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fd936210-c641-434b-a51a-ab5f7d76430c"), 0, new DateTime(1998, 11, 27, 0, 16, 57, 392, DateTimeKind.Local).AddTicks(3139), 698.8975871042890000m, "c20cdc04-5df7-42d2-95cb-254ab2574693", null, "Malcolm", "Parisian", false, null, "Malcolm45", "AQAAAAEAACcQAAAAEPKcg7FXFQ7ApRT/PZNZ6jr+JhZJRlB8j9NJdHBfnTyNixfJZ/zFX6B66IL9TM/y2g==", null, "NotSelected", false });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActivatedAccount", "Birthday", "BonusAccount", "ConcurrencyStamp", "FatherName", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Login", "PasswordHash", "SecurityStamp", "Sex", "TwoFactorEnabled" },
                values: new object[] { new Guid("fe114181-f2e6-4432-86af-f7d827b491ef"), 0, true, new DateTime(1967, 2, 4, 13, 23, 13, 508, DateTimeKind.Local).AddTicks(323), 238.2016376249040000m, "ff9b0dd2-3f20-4918-96a2-62c70699ed61", null, "Angelo", "Sipes", false, null, "Angelo81", "AQAAAAEAACcQAAAAEPNXQ0nbPlGffHyr/nFijwHmiH7fV60C4DQaWWFkigcAEHkv/MvZkxkMF2d2Mw0xfw==", null, "Female", false });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("00dfebec-fb40-4e2b-9e75-2fdd2b55eceb"), "48,849487;28,275679", "Lennymouth, Cayman Islands", "Lois Falls, 739", 155 },
                    { new Guid("054ba48d-e0f9-47a1-b07b-316695b4b5df"), "48,92253;27,103603", "Lake Annamae, Niger", "Brianne Hollow, 84853", 91 },
                    { new Guid("0809ca1f-63f3-452d-b883-ca5f11d909cf"), "48,956863;26,154427", "North Dejuan, Turkmenistan", "Gerda Circles, 212", 200 },
                    { new Guid("08b71c1b-fe0f-4a5a-9233-90f325c74bca"), "49,126007;27,200823", "Leannonberg, Syrian Arab Republic", "Hirthe Ferry, 658", 148 },
                    { new Guid("0dbe5c88-d242-4e88-bff2-84be3ca6ec44"), "50,943623;28,435001", "Hayeschester, Libyan Arab Jamahiriya", "Gabrielle Hollow, 45899", 9 },
                    { new Guid("12e6149a-5a09-41b5-8abd-bb7c3cb92b48"), "50,079;24,486814", "Lake Dante, Costa Rica", "Brandyn Green, 54994", 8 },
                    { new Guid("136d1340-a0e7-42ac-8b65-ea93c6893dbf"), "50,450554;28,142796", "Abernathymouth, Reunion", "Wilfred Flats, 53180", 16 },
                    { new Guid("13e02abf-3844-4f82-845a-5bf26b396ce6"), "50,642002;28,251158", "Anikaport, Chile", "Courtney Garden, 301", 94 },
                    { new Guid("15465541-6048-441f-9365-f54a8f2e413f"), "49,544815;24,225977", "East Dominiqueport, Faroe Islands", "Dach Forges, 065", 123 },
                    { new Guid("1923b923-e1f7-4e13-a01c-f46f40149263"), "50,117252;28,574848", "Hudsonview, Denmark", "Reichert Tunnel, 9493", 126 },
                    { new Guid("20de2af1-350c-4f98-ac5d-c4a90261863a"), "50,391052;27,649715", "Donnieberg, Guinea", "Kreiger Skyway, 8815", 42 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("225c7cae-a13e-4edc-9cc1-cfcb2589e57c"), "50,275127;24,77943", "Bartolettitown, Argentina", "Hamill Walks, 78084", 128 },
                    { new Guid("23b79ba4-b643-43f8-bafe-c598b5b6c3a6"), "50,103416;26,102232", "New Chyna, Monaco", "Brisa Parks, 195", 118 },
                    { new Guid("2675240e-3801-49f3-8341-9a392ff00e6c"), "49,74524;23,99127", "New Glennie, Switzerland", "McClure Union, 8924", 52 },
                    { new Guid("26779feb-2cf6-4f33-96fe-7044c168acdc"), "49,36455;27,694588", "Williamsonfort, Yemen", "Fadel Land, 826", 97 },
                    { new Guid("27a268cc-f581-444b-a176-fa8c5722e627"), "48,58387;30,060226", "Parkertown, Latvia", "Herman Lights, 694", 147 },
                    { new Guid("27b0d9a9-2737-4ddf-9410-fabc3a2966fb"), "49,83509;29,214582", "Linashire, Eritrea", "Herzog Pike, 907", 118 },
                    { new Guid("27d2fb17-fa49-4cb2-887d-7044f14787ca"), "49,822857;26,100557", "East Monroe, Estonia", "Hansen Course, 7717", 62 },
                    { new Guid("29c204cf-fa17-4494-bbc4-69e1801aedb1"), "49,667854;26,707432", "Lake Jacklyn, Haiti", "Camden Rapid, 983", 174 },
                    { new Guid("2e93d73b-ab1e-4acc-9f3e-41137645d8c4"), "50,080074;30,242434", "Roobmouth, Finland", "Huels Ferry, 68770", 161 },
                    { new Guid("33629524-892b-419a-9844-38ecb6bf16ba"), "49,99691;24,710257", "Rueckerport, Pakistan", "Leone Lakes, 52846", 87 },
                    { new Guid("35ea3031-c5ad-4fe0-82a4-ec3bf7743e8c"), "48,84193;25,236494", "West George, Kiribati", "Ullrich Squares, 0432", 129 },
                    { new Guid("3b7b82bd-401e-448b-ad2c-0ccd23545038"), "49,414257;29,287275", "North Katlynn, Malta", "Ludie Garden, 7933", 131 },
                    { new Guid("3eb3b4fb-3f8d-48c1-bf6a-c86d5b88c4af"), "50,892643;25,263542", "Port Juniusport, Chile", "Rowena Shoals, 32221", 91 },
                    { new Guid("418d1ba6-af3b-42a5-8a21-7fb580de8d1a"), "50,94821;25,921835", "Cruickshankside, Netherlands Antilles", "Lavada Ways, 15748", 34 },
                    { new Guid("418de17e-db13-4ff5-a08f-6e6e26da4d38"), "49,03712;29,27335", "Baileyberg, Virgin Islands, U.S.", "Gleichner Street, 412", 161 },
                    { new Guid("47541163-70b3-4e12-a210-73989f977276"), "48,649456;30,900787", "New Harvey, Indonesia", "Erdman Squares, 8172", 172 },
                    { new Guid("4784390e-a20e-474d-9cb5-2e70bd2f81e6"), "50,502243;30,004032", "East Marianaside, Palestinian Territory", "Elian Ways, 42404", 130 },
                    { new Guid("4dedec77-b786-45da-842e-bd7355969f3e"), "48,275448;27,843569", "Anniefurt, Maldives", "Emery Cove, 94077", 137 },
                    { new Guid("4e40dcce-dbce-4e88-884d-f85c6f24350d"), "50,775276;23,339176", "Einarburgh, Tunisia", "Minnie Harbors, 595", 151 },
                    { new Guid("519dd59a-b1c2-4995-89e0-0c1861cb65ad"), "50,338146;23,109735", "Alyssonville, American Samoa", "Crist Rapid, 686", 51 },
                    { new Guid("5215b833-f9bf-45e1-8801-02f667761599"), "49,46097;27,566519", "West Dejah, Greenland", "Carmen Road, 86785", 30 },
                    { new Guid("5686d183-3d0d-41f1-a52b-ea86a8e0ac4a"), "49,18261;24,635117", "Lake Roy, Norfolk Island", "Kessler Mountain, 1092", 51 },
                    { new Guid("5d7b85dc-18ac-44d8-9bab-206bfeee594c"), "48,125134;25,968231", "South Margotstad, Croatia", "Pagac Locks, 92522", 20 },
                    { new Guid("5fdbf576-345f-48a9-80fc-5fc2b086a721"), "50,483376;27,682331", "East Taurean, Qatar", "Arch Garden, 949", 200 },
                    { new Guid("6000add2-5b86-4e4f-86e3-c2253a107133"), "50,403755;28,702993", "West Eltachester, Cambodia", "Bauch Pike, 245", 153 },
                    { new Guid("64069a76-e70c-4348-b8c9-b2bd5af83ff2"), "48,61915;29,943249", "Haagberg, Estonia", "Stokes Burgs, 59165", 88 },
                    { new Guid("651e98a0-df7d-43e2-8660-58b265bfb030"), "48,84615;26,84974", "Alessandrofurt, Republic of Korea", "Greenholt Field, 56812", 15 },
                    { new Guid("65de2abc-0071-445e-8420-4089caea7e68"), "50,480106;23,785574", "Denesikburgh, Palau", "Lukas Manor, 588", 16 },
                    { new Guid("66db584f-16bd-42f5-bd89-716dc726de6b"), "50,315918;27,61976", "Howellbury, Niue", "Geo Isle, 2657", 81 },
                    { new Guid("68280e04-4a3b-43d8-a234-e358340c4255"), "48,62619;26,87561", "Baileyview, Barbados", "Saige Coves, 27869", 128 },
                    { new Guid("69fa685e-dae4-4c8c-a240-eaa785690674"), "50,811382;30,372505", "Port Omer, Iraq", "Buckridge Way, 62476", 59 },
                    { new Guid("6c0f4055-2dd6-44a4-a770-add285995e2c"), "48,208736;28,526285", "Port Katlynnland, Virgin Islands, British", "Kovacek Brooks, 103", 66 },
                    { new Guid("6daf3e65-b139-4765-8bb7-2722867ef747"), "50,95476;24,913748", "South Payton, Spain", "Kennedy Trail, 082", 46 },
                    { new Guid("6e0aa184-620e-431a-9c59-04cb40c3596d"), "50,19066;26,417362", "Joaquinfurt, Saint Helena", "Ledner Cliffs, 40885", 86 },
                    { new Guid("6fef0d35-acb9-4ffd-bb62-249a029a8263"), "50,094986;23,104279", "Heatherborough, Antarctica (the territory South of 60 deg S)", "Juwan Key, 60097", 146 },
                    { new Guid("70ca82f4-e016-4979-a860-4b9d640e4a55"), "48,515934;29,92504", "Lake Sherwood, Syrian Arab Republic", "Camron Vista, 9273", 29 },
                    { new Guid("7155d816-4a1b-4633-86c9-38af28091f08"), "49,260284;30,493723", "Lake Otiliaville, Benin", "Austyn Fords, 937", 63 },
                    { new Guid("750fdd11-fde9-4c88-96fd-3a1c137c667a"), "48,030476;23,114487", "Edmondville, Madagascar", "DuBuque Greens, 931", 170 },
                    { new Guid("7847e3e6-e8e7-4793-ae82-f42ffb84862e"), "48,414303;28,043982", "East Adellville, Malaysia", "Leuschke Gardens, 098", 16 },
                    { new Guid("78699364-109f-4f8a-9344-9a91201cf014"), "50,434414;26,564129", "New Melissa, Bosnia and Herzegovina", "Cyrus Inlet, 07597", 42 },
                    { new Guid("78da8dff-a8af-494e-a9f4-887a2e0edf71"), "49,110123;25,685268", "Crooksside, Djibouti", "Hessel Crest, 6086", 79 },
                    { new Guid("7a9316a6-44f7-430f-8e05-a8fd9b2c9186"), "50,516132;28,730278", "Gerhardberg, Saint Martin", "Muller Road, 19073", 163 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("7c7cc635-c7b6-4190-9655-1b8d24188f46"), "50,28898;24,170883", "East London, Singapore", "Greenholt Heights, 60925", 173 },
                    { new Guid("7f7b3ab9-b22c-4d54-b18a-7dee63cba9e9"), "50,185925;24,719175", "Port Daytonshire, Lao People's Democratic Republic", "Leila Drive, 63793", 134 },
                    { new Guid("7ff2c882-495d-449a-979d-840acdef566e"), "50,15487;26,33365", "Torphyside, Philippines", "Kasandra Glen, 186", 89 },
                    { new Guid("8041ce88-8970-4e24-a0cd-0ddb6c08f83a"), "50,466488;30,418196", "South Pearliefurt, Cyprus", "Hilll Causeway, 911", 145 },
                    { new Guid("84421746-346d-46d1-a79e-1bbc028c61a7"), "50,492996;29,767208", "Marlinhaven, Norfolk Island", "Kunde Mountain, 50711", 187 },
                    { new Guid("87114ad0-8653-4a50-ae0d-91b3044d1c1a"), "50,38831;26,164259", "South Evangeline, Swaziland", "Brayan Parkway, 0777", 186 },
                    { new Guid("88151a9e-50d9-4941-bdee-8f0cf3735de4"), "50,83749;29,097408", "Hermanfort, Netherlands", "Schowalter Mountains, 27019", 89 },
                    { new Guid("885b5e6f-393d-4a56-b93a-0c55e4c614f6"), "49,44308;26,784693", "Myrtiehaven, Mongolia", "Lia Forges, 403", 184 },
                    { new Guid("8c2ac402-899a-40a8-a708-5fff489bc2eb"), "49,800148;23,53186", "West Idellborough, Saudi Arabia", "Maegan Greens, 859", 47 },
                    { new Guid("8e6c9373-cbfc-4d97-87e6-6bcd4f58a1a2"), "50,534233;30,607613", "West Jakob, Australia", "Gusikowski Drive, 187", 139 },
                    { new Guid("91bce893-f690-4814-8d4c-7e09b3ea60ec"), "48,270542;25,765984", "Lavadaborough, Philippines", "Herman Via, 21975", 108 },
                    { new Guid("93141f87-a60f-4941-ad1e-888b0517476f"), "49,665672;24,361288", "West Chris, Falkland Islands (Malvinas)", "Jarret Brook, 3416", 42 },
                    { new Guid("9377146a-b019-4d4e-964c-8a6b38349261"), "50,690456;29,698593", "New Kian, Estonia", "Stamm Meadows, 299", 183 },
                    { new Guid("94a78a2e-ff75-4a35-942f-cf68fb7a1e2d"), "48,26845;25,001295", "Neomachester, Saint Vincent and the Grenadines", "Lupe Overpass, 07715", 181 },
                    { new Guid("99e2525e-2bee-4171-afd9-57903a024f99"), "49,42384;28,694513", "West Tad, Colombia", "Ally Neck, 4265", 111 },
                    { new Guid("9b275b60-d52c-4918-bf2d-13a802c5b4e6"), "49,81513;29,716078", "Kathleenfurt, Equatorial Guinea", "O'Keefe Terrace, 754", 153 },
                    { new Guid("9e0caa1a-8096-4717-84ed-da9cafde4a2f"), "48,386997;29,222967", "Lake Kristaside, Hungary", "Schiller Rest, 994", 19 },
                    { new Guid("a51d1973-0f5f-42a4-a8d9-559aa493b64d"), "48,063107;30,781315", "Lake Arnaldoville, Yemen", "Hansen Courts, 7826", 44 },
                    { new Guid("a5cb8000-3c2a-486a-b593-6a21ebe8f367"), "50,411625;30,949438", "Port Kaycee, Saudi Arabia", "Hoppe Junctions, 41072", 8 },
                    { new Guid("a82d9ad3-0d1d-40f1-a64c-3c3ee7ab0bc2"), "50,62171;24,001293", "New Robertoberg, Jamaica", "Hollie Motorway, 6209", 64 },
                    { new Guid("a83d596e-647a-40ce-b349-c0c54bec2d4e"), "50,364418;23,781233", "North Dinoside, Yemen", "Harris Turnpike, 99545", 12 },
                    { new Guid("a987655b-3a56-467b-a70a-6dad466664fa"), "48,03556;23,677126", "West Alisastad, Togo", "Katheryn Fall, 2922", 184 },
                    { new Guid("a9ed5b3e-93a8-42f7-80da-a28cdbb45d7c"), "49,427876;26,43357", "New Breanna, Lao People's Democratic Republic", "Ursula Spurs, 2620", 6 },
                    { new Guid("aae05d17-8b91-4e50-b17e-493c7ecfdd0c"), "50,38923;27,512651", "Port Hailietown, Isle of Man", "Tremaine Extension, 3460", 90 },
                    { new Guid("ab213edf-9504-4cf0-a96a-659a5f48c772"), "48,532753;28,076658", "East Fae, Croatia", "Laney Inlet, 12711", 47 },
                    { new Guid("ae821cda-f212-4c7b-a34c-efb96130c1d9"), "48,44891;29,044094", "Jaskolskiberg, Afghanistan", "Katarina Ford, 6906", 169 },
                    { new Guid("b14fd8d1-eff7-44b8-8cf2-f65ef9342445"), "50,946785;28,394068", "Modestoside, Finland", "Amber Shores, 9018", 60 },
                    { new Guid("b1695177-eec6-472a-a864-a933bc1f22fe"), "49,80463;26,571856", "Gisselleborough, South Africa", "Anderson Lock, 334", 1 },
                    { new Guid("b366a27a-2029-4cf0-8e20-0545c4c9f750"), "48,600018;27,349094", "Port Kari, Grenada", "Leta Shores, 098", 55 },
                    { new Guid("b3695a2b-f9ce-4496-baa3-cfb1a34ff604"), "50,648426;27,642624", "Wilmahaven, Colombia", "Kassulke Port, 71812", 126 },
                    { new Guid("b3e39f0f-915a-443b-b8cf-6e0f778619db"), "50,605366;25,800177", "New Susannashire, Cameroon", "Littel Divide, 433", 20 },
                    { new Guid("bb1afed4-d314-46f8-a76d-81e152deffc4"), "48,272507;30,767395", "Hassieberg, Republic of Korea", "Jordan Lodge, 19079", 181 },
                    { new Guid("c2e9a7ab-37d6-4114-b802-a69f665ecfbd"), "48,542152;25,638834", "West Thoratown, Zambia", "Auer Flat, 413", 26 },
                    { new Guid("c33b27c0-451c-411e-8bf3-ff369d05ea15"), "50,085724;27,847675", "Ortizbury, Montenegro", "Nathen Islands, 443", 156 },
                    { new Guid("c3a29896-e8ae-49c4-8154-fbb6046adfcb"), "48,082336;27,99804", "North Bernardoburgh, Norway", "Orn Locks, 5901", 101 },
                    { new Guid("c486dfc4-46ee-4419-8d90-36a9a8bcd1f5"), "48,56438;30,71254", "Veumfurt, Virgin Islands, U.S.", "Stanton Oval, 25523", 114 },
                    { new Guid("cc19bcc3-319f-43c4-971f-4106c62e8e80"), "48,079906;25,555136", "Eloisafurt, Rwanda", "Walter Lakes, 29438", 122 },
                    { new Guid("d8df15a7-b416-4345-83b3-6f52ea444eda"), "49,658936;25,04896", "Lake Elian, Nepal", "Conroy Vista, 41509", 109 },
                    { new Guid("e1ec5814-cc1e-4c58-a9a9-111e13d6a4fc"), "50,461063;25,00671", "Lake Bartholomestad, Pakistan", "Konopelski Walks, 51656", 17 },
                    { new Guid("e273e9ca-7e68-4789-acd6-035f53923937"), "49,422287;23,859211", "New Lora, Nigeria", "Althea Islands, 774", 159 },
                    { new Guid("e6321b35-1606-41ca-91f6-fab2fd27caa4"), "48,45511;26,416943", "New Harvey, Andorra", "Schoen Point, 77919", 8 },
                    { new Guid("ea290975-bd5f-4617-9651-40dc797eb5fd"), "50,77641;29,081722", "North Stanton, Oman", "Madie Center, 53474", 176 }
                });

            migrationBuilder.InsertData(
                table: "ParcelMachines",
                columns: new[] { "ParcelMachineId", "Coordinates", "GlobalAddress", "LocalAddress", "ParcelMachineNumber" },
                values: new object[,]
                {
                    { new Guid("f09d04f4-274d-43b2-9b40-ace110a9f19f"), "50,635998;28,463724", "New Alejandrahaven, Cuba", "Yazmin Village, 834", 3 },
                    { new Guid("f6425b1a-18b0-44c1-b00b-7929ef9a632a"), "48,968414;23,411175", "Welchberg, Reunion", "Rosenbaum Court, 926", 197 },
                    { new Guid("f6c815a0-a15f-45cb-96e3-9724da561ae9"), "50,512486;24,220938", "Mossiestad, New Caledonia", "Maxwell Fields, 941", 107 },
                    { new Guid("fdb1910e-9488-40a4-8da8-6a89017dd088"), "49,212513;26,667135", "Gabrielville, Maldives", "Gilberto Isle, 4128", 116 },
                    { new Guid("fdfff744-7250-4875-b002-d9f9215938b4"), "48,15964;29,94092", "Toychester, Guinea", "Tremblay Springs, 4306", 165 }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("007374a4-abe7-4cbf-9fe9-dcb4d03d9f29"), 186, "50,239502;25,432377", "South Reymundohaven, Algeria", "Sipes Greens, 35882" },
                    { new Guid("00ddaa3a-fde4-4e97-aeb7-52d7e4ca3192"), 191, "49,816666;27,503279", "East Joshuahberg, Turks and Caicos Islands", "Abbott Lights, 355" },
                    { new Guid("01026e9d-f00b-40ab-967c-4ac2fbf3c254"), 70, "49,260433;30,27602", "South Teaganbury, Azerbaijan", "Helena Mission, 90101" },
                    { new Guid("017bb7de-ec27-4d86-a469-ab6fd845ae9f"), 180, "49,951153;26,506577", "East Traviston, Mayotte", "McDermott Turnpike, 4699" },
                    { new Guid("039d774c-2452-4fff-bc09-c2184ac4b38a"), 135, "49,484837;27,411123", "East Mateoville, Djibouti", "Kuhn Bypass, 539" },
                    { new Guid("064c6484-09e5-4a84-a9dd-f9d19394c044"), 198, "48,794125;27,078938", "Lake Ginaborough, Benin", "Moore Pines, 62349" },
                    { new Guid("081d4e51-afe9-422b-8047-68359f5aa18d"), 168, "50,6187;28,466568", "Roobside, Pitcairn Islands", "Emilio Spring, 63796" },
                    { new Guid("0c193ef9-f65c-4b1f-aec7-d8cb17db12eb"), 138, "49,96236;30,813972", "Nilsfurt, Bhutan", "Merlin Viaduct, 60769" },
                    { new Guid("0cef5f0e-429a-4133-a7c3-70c3681ea8ad"), 13, "49,386784;28,28385", "Shanahanbury, Japan", "Candelario Park, 168" },
                    { new Guid("0ddc1555-5c76-44d4-a961-7f4ace0284f8"), 41, "48,864117;28,374084", "North Eribertoport, Sudan", "Marisol Bypass, 188" },
                    { new Guid("0e0be5e9-ee99-4c4d-82be-3201963132ea"), 64, "50,07254;24,722855", "Alanville, Poland", "Leland Forges, 54561" },
                    { new Guid("0f2c0274-9f31-4129-9902-ee119456101e"), 20, "49,410755;29,577463", "Hermannville, Sweden", "Sid Roads, 427" },
                    { new Guid("10021bbd-275b-4244-a649-f4e367e10866"), 80, "49,43249;27,297646", "New Gilda, Comoros", "Kuhn Grove, 3221" },
                    { new Guid("14f463c4-71a3-4082-9b70-0dc7d2b9ee12"), 123, "48,628017;26,131544", "Jovannyborough, Greece", "Parker Valley, 3804" },
                    { new Guid("15639823-27f1-4765-b3da-2b271bf56359"), 162, "48,562843;28,415419", "Melvinaside, Greece", "Tiana Inlet, 8239" },
                    { new Guid("1568c3ad-cce1-41a0-a0c4-3b5c980c18cb"), 59, "49,49282;23,367344", "West Abbey, Tuvalu", "Schroeder Coves, 9569" },
                    { new Guid("18ab9897-2d52-400f-8efc-9669f0fa195c"), 189, "49,680286;27,510937", "South Maceyshire, Ethiopia", "Rosie Locks, 28881" },
                    { new Guid("19e3b61c-4227-4f32-8244-ec011da8ad0e"), 21, "49,893837;30,449919", "Port Elnaburgh, Cameroon", "Lowe Alley, 0555" },
                    { new Guid("1a7f1fa4-2eaa-4778-b9f9-b2115a812ce1"), 168, "48,112812;26,217968", "Lake Bradly, Wallis and Futuna", "Rohan Islands, 19560" },
                    { new Guid("1b7f2141-b5de-4ea1-aa7c-a3a9785f1825"), 191, "50,59708;26,868986", "Concepcionshire, Saint Lucia", "Don Wells, 9832" },
                    { new Guid("1d59e08c-2cf1-45bd-9d76-a67f55a90a2b"), 198, "48,71675;29,91166", "East Kylabury, Portugal", "Abe Estates, 0288" },
                    { new Guid("1f328772-14da-4083-b929-bfdd2a5a8754"), 37, "50,463024;30,474817", "Murphyhaven, Dominica", "Jeremie Lakes, 9927" },
                    { new Guid("22477692-1451-4988-a58a-5883caf39274"), 19, "50,89285;24,38997", "Port Alvisshire, Tuvalu", "Kylie Vista, 778" },
                    { new Guid("282003c8-be32-42a1-84ec-5705d66a137e"), 55, "50,740597;25,268202", "East Lornastad, Uganda", "Harmon Spring, 468" },
                    { new Guid("28b718ad-2051-4c52-bdbb-a709e7e5027c"), 54, "48,248005;28,166595", "Kovacekport, Estonia", "Von Ferry, 9575" },
                    { new Guid("2a4369fc-937e-4961-be15-b06a63c544ef"), 154, "50,880657;23,802675", "Port Ernestmouth, Hong Kong", "Calista Neck, 21422" },
                    { new Guid("2baca56d-4df7-4e89-9aff-4f010099a57d"), 146, "49,675125;25,662048", "North Hal, Portugal", "Isai Grove, 718" },
                    { new Guid("2c9ab446-ee57-44e2-b641-cda156a85e2c"), 139, "49,821415;30,5409", "Hermanshire, Saint Helena", "Conn Landing, 94208" },
                    { new Guid("2e11e9ef-a8fa-422f-8808-b8fd899710db"), 103, "48,160652;23,410364", "East Ruthe, Cambodia", "Kuhic Walks, 851" },
                    { new Guid("31a3a1a2-9b9f-464e-adbc-382ff6600242"), 111, "49,425438;29,991043", "Osinskiville, Saint Lucia", "Hilario Motorway, 86167" },
                    { new Guid("325bc864-05ad-4f4e-b830-1e06cfa3502a"), 21, "49,84261;24,645035", "East Jarretberg, Costa Rica", "Braun Road, 0134" },
                    { new Guid("331a98e6-2708-4a11-8aa8-2a100175aaa1"), 162, "48,235027;25,559359", "East Elmo, Croatia", "Bauch Trail, 6179" },
                    { new Guid("3c94643c-f35e-4871-b770-b18a23ead247"), 148, "48,056168;30,631828", "Lake Beryl, Fiji", "Wilbert Street, 386" },
                    { new Guid("3e1325a5-64bb-447e-b120-fc30f56dc569"), 139, "50,401493;28,721958", "Ilaborough, Eritrea", "Jazlyn Terrace, 74302" },
                    { new Guid("3f3b9aa0-2710-4d08-baef-8b69239bcd3a"), 58, "49,434998;25,094389", "New Vergiehaven, Comoros", "Murray Crescent, 955" },
                    { new Guid("41aab7dd-4c6a-4b93-9528-c3ea3dc810e7"), 94, "48,73642;30,604828", "Ayanaville, Afghanistan", "Cassie Run, 02251" },
                    { new Guid("44598530-aa18-47a9-8d94-2f501ff27996"), 10, "49,67171;27,157358", "Lake Samarashire, Madagascar", "Maggio Ridge, 1880" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("4500ce4b-6df9-4282-b4d9-8e4c27d25180"), 134, "50,028133;30,023573", "Anibalport, Namibia", "Wiegand Crossroad, 99927" },
                    { new Guid("4a3c1fe1-dac5-4716-9645-a21a1f5fc905"), 4, "50,640186;25,702568", "West Junior, Reunion", "Shaun Village, 41961" },
                    { new Guid("4ce57b74-a6c0-43ca-962c-36b719adebe7"), 187, "50,492836;28,859585", "Lynchview, Ireland", "Becker Rue, 433" },
                    { new Guid("57e685cc-a45c-42f0-94e7-dbf7c6f9e1c8"), 130, "50,2616;24,235348", "Port Everettbury, Macao", "Blanda Canyon, 7365" },
                    { new Guid("594303d8-fab4-45f0-990b-fa30c1d0b9ef"), 36, "50,515884;23,660894", "Schadenfort, Saint Kitts and Nevis", "Wisoky Lock, 89505" },
                    { new Guid("5a910f56-cb2e-472c-ac01-105bd28ffb4f"), 131, "49,013435;30,261927", "Margaretfort, Saint Helena", "Bernhard Squares, 599" },
                    { new Guid("5f2e1df8-79a8-427c-84f4-fcfd68fb4a4f"), 167, "49,329323;30,518593", "Port Aidaberg, South Georgia and the South Sandwich Islands", "Jo Route, 7404" },
                    { new Guid("5f85f1d9-ed5b-4129-81f6-cc4f3dd932bd"), 141, "49,720608;23,176289", "Martineborough, Singapore", "Birdie Track, 89248" },
                    { new Guid("5f8acec4-b62a-4282-bda0-0312b424bdd0"), 15, "48,10031;30,267097", "Desireeville, Togo", "Wisozk Tunnel, 72376" },
                    { new Guid("65469f28-cb68-49a6-90d5-3450a77704b1"), 121, "50,127403;24,382603", "New Antonettaberg, Northern Mariana Islands", "Gay Branch, 696" },
                    { new Guid("666ae465-aab6-4420-bb7f-bc109e5bd3bd"), 186, "49,540867;27,190723", "Aftonton, Tokelau", "Adrienne Springs, 0858" },
                    { new Guid("6fed90bd-b866-4699-951b-6291c2343283"), 95, "50,361744;28,863016", "Freedamouth, Qatar", "Trantow River, 56942" },
                    { new Guid("71559184-39a0-415f-9773-08b701a96d0d"), 82, "48,716637;26,727808", "Elijahhaven, New Zealand", "Herminia Valleys, 90990" },
                    { new Guid("71cd55f8-531e-447c-ba06-934c6fa14f8e"), 168, "49,955494;29,329771", "East Evelinestad, Bangladesh", "Champlin Throughway, 773" },
                    { new Guid("790700ae-4f7f-4063-8470-93b30820d7ec"), 88, "50,529022;24,943668", "Abshireville, Lebanon", "Leatha Bridge, 433" },
                    { new Guid("7b5830d7-1219-4e9f-b107-808652d3d2dc"), 79, "48,98781;28,637491", "Connburgh, Indonesia", "Jeanne Wall, 2133" },
                    { new Guid("7c015125-fcc6-449c-8e3d-716aea32724f"), 142, "50,460426;26,280731", "East Icieburgh, Denmark", "Ritchie Streets, 7518" },
                    { new Guid("7c10d955-5c05-43cc-8294-6a40a0ebde02"), 22, "48,972973;30,605751", "South Ladariuston, Senegal", "Roberts Ridges, 44558" },
                    { new Guid("7dfa3888-1cbe-431d-8f87-73b0001a68ee"), 180, "48,942345;30,610092", "Goodwinberg, Burkina Faso", "Hillary Spurs, 977" },
                    { new Guid("7fe70abd-d465-46d8-8872-b556b9424a16"), 91, "48,255127;29,535688", "South Dylan, Bahrain", "Bradly Fork, 26029" },
                    { new Guid("82af1ae8-f101-4f59-88a9-d28826f75949"), 85, "48,842335;29,064402", "South Nolaland, Montserrat", "Chanel Ridges, 5385" },
                    { new Guid("8b45dde8-a22f-4a68-a19d-be7802733200"), 175, "50,836224;27,312458", "East Emmet, Mali", "Davon Lights, 33929" },
                    { new Guid("8ed56a71-22bb-4438-9035-107f55000c92"), 132, "50,755756;25,386497", "Estellestad, Equatorial Guinea", "Barry Knolls, 1173" },
                    { new Guid("936c72cc-abdd-49da-a82b-b277422a1831"), 194, "49,28703;26,704708", "Lake Wilford, Senegal", "Terrill Green, 75961" },
                    { new Guid("9653df38-e9a4-41fc-8311-e50b68e7d0da"), 183, "50,90271;28,84135", "Kuvalisfurt, Kiribati", "Reese Forks, 821" },
                    { new Guid("96be87db-3e48-45f7-81da-24b12dce5ae7"), 103, "50,143494;29,542728", "Port Johnny, Burkina Faso", "German View, 41621" },
                    { new Guid("9f795109-d9e9-4a1f-b2b5-79638b0e20a5"), 64, "49,1351;23,217112", "North Cindyborough, Albania", "Sally Trafficway, 6542" },
                    { new Guid("9f87c992-10b8-48d2-838a-ac3f61829a5c"), 128, "49,503693;23,466196", "Robelhaven, Netherlands", "Bernhard Crossroad, 224" },
                    { new Guid("a8867a13-04ee-4d0d-ad13-7c3673d57f1a"), 153, "50,799606;29,146114", "Idellchester, British Indian Ocean Territory (Chagos Archipelago)", "Hoppe Tunnel, 2740" },
                    { new Guid("ac0a111e-34a5-43f1-9b4c-fccf13090c17"), 98, "49,002735;25,692215", "Petefurt, Cocos (Keeling) Islands", "D'Amore Ports, 395" },
                    { new Guid("b0f6b08d-5a43-4f56-93c8-1087efa489ce"), 146, "49,91691;23,778078", "East Carli, Denmark", "Steuber View, 79176" },
                    { new Guid("b2ee6013-25c3-4866-b141-7a61390548fb"), 15, "50,04147;24,126245", "Fordburgh, Belgium", "Demetrius Road, 1460" },
                    { new Guid("b54d5ca2-5c75-4eeb-9dbb-05fa5c012899"), 10, "49,37089;28,934233", "Lake Shakirafurt, Haiti", "Meagan Field, 9000" },
                    { new Guid("b8395005-2fee-49a4-b1f0-bd0f178da570"), 39, "48,37711;26,76513", "West Jared, Saint Kitts and Nevis", "Vesta Mount, 577" },
                    { new Guid("ba34515f-a0fe-4a3e-ac8f-a5a86ceee213"), 45, "48,313248;30,586485", "Jessicaton, Namibia", "Kilback Inlet, 11316" },
                    { new Guid("bbf611ba-773c-426d-8e7f-fa8990beaac2"), 128, "49,664722;27,788622", "West Mustafamouth, Saint Barthelemy", "Veum Wall, 853" },
                    { new Guid("be7e17d5-37ca-4c11-a722-100695e0c22a"), 163, "48,223003;27,929646", "North Henriside, Netherlands", "Lysanne Dam, 44342" },
                    { new Guid("c00fd1c1-8cf6-49e1-bdd0-c037f857c502"), 120, "49,055607;24,733885", "South Joanne, Jordan", "Torp Landing, 355" },
                    { new Guid("c29848ff-8bc9-47e0-8b77-b372fc739d91"), 103, "48,086353;26,367317", "Emilieport, American Samoa", "Jody Haven, 99930" },
                    { new Guid("c3cec6cc-40e5-4ec8-9a3c-3aabc13f3c30"), 134, "48,574383;30,94189", "Lake Vivienchester, Costa Rica", "Schinner Well, 6348" },
                    { new Guid("c4c97a1e-9df2-48a2-b4cc-c8d881bd8275"), 89, "49,488453;30,742043", "Maddisonside, Belarus", "Kozey Camp, 1536" },
                    { new Guid("c5dc2358-e948-4030-aad3-23e9c4cec62f"), 95, "50,743134;26,118294", "South Yasmineside, Puerto Rico", "Howe Key, 6521" }
                });

            migrationBuilder.InsertData(
                table: "PostBranches",
                columns: new[] { "BranchId", "BranchNumber", "Coordinates", "GlobalAddress", "LocalAddress" },
                values: new object[,]
                {
                    { new Guid("c6f08209-4966-4c81-81b8-837f3e3c888e"), 186, "49,400005;23,791574", "Araland, Iraq", "Celestino Mill, 016" },
                    { new Guid("c8ffaece-8951-4955-87fd-d8457b06d299"), 14, "50,3955;27,350077", "Swiftview, Greece", "Kuhic Mall, 9543" },
                    { new Guid("cac714e8-865a-4b46-8c36-264847616aaa"), 145, "49,763035;25,072962", "Isaacfurt, Swaziland", "Fadel Square, 044" },
                    { new Guid("d2a5d4d8-e527-417c-a665-2434c248b2b5"), 187, "50,03641;24,681646", "North Leonormouth, Oman", "Gerhold Glens, 5449" },
                    { new Guid("d3b5318a-34c2-4429-88f3-44a3460edd57"), 54, "50,690563;29,638758", "West Tobyshire, Maldives", "Turner Flat, 654" },
                    { new Guid("d9bb5734-4f57-48f6-aaf8-e54dceba0ae6"), 180, "50,564426;25,834986", "Port Lexiberg, India", "Haley Falls, 91128" },
                    { new Guid("db441bd1-6945-4e50-b443-578955319315"), 13, "48,494125;24,987387", "Port Stuart, Philippines", "Ivah Estates, 510" },
                    { new Guid("dc5833a8-3d41-4f91-95ec-9b82ca052034"), 114, "49,456364;30,288008", "Hellerport, United Kingdom", "Oberbrunner Extensions, 10980" },
                    { new Guid("e2d3e1c2-54ad-439b-a92c-b2aa2a2b0dc9"), 95, "49,894855;29,046183", "Myamouth, South Georgia and the South Sandwich Islands", "Parker Way, 393" },
                    { new Guid("e455a539-5549-4129-8501-680db5c739d8"), 172, "50,044415;27,701994", "Walkerside, Panama", "Shaniya Expressway, 5573" },
                    { new Guid("e675a738-0cf4-4390-b426-8725fff588ab"), 41, "48,472523;27,647917", "Sandramouth, United States of America", "Sebastian Heights, 91217" },
                    { new Guid("e6ba4515-df2e-452b-9cc8-660b95ebeff4"), 164, "48,657074;23,318527", "Carlieborough, Congo", "Morissette Dam, 7866" },
                    { new Guid("ec0742ca-b7b7-4190-8de2-0a7cb12afc83"), 110, "48,4785;26,458729", "Mayerbury, Latvia", "Emmitt Skyway, 5670" },
                    { new Guid("ee38c7e2-b40a-4595-894b-032db0ffffbb"), 161, "48,881516;26,882133", "South Emilioview, Nicaragua", "Jose Haven, 58864" },
                    { new Guid("f16c3d18-0604-4234-b25e-a6a03b020347"), 169, "48,287968;28,427198", "Port Bridgetport, Bhutan", "Waters Ville, 80874" },
                    { new Guid("f347ad50-1a3a-448a-ad0c-3c5ac0c97757"), 42, "48,8285;29,934677", "Bodeview, Czech Republic", "Daugherty Causeway, 13464" },
                    { new Guid("f3609b4c-e715-43a7-879c-f4c565d98156"), 165, "48,39973;24,354155", "North Marques, Australia", "Braulio Stream, 53624" },
                    { new Guid("f738473b-1838-4cd9-837c-333542b90b06"), 126, "49,326893;26,677267", "Lake Marilouport, Barbados", "Kris Green, 54261" },
                    { new Guid("f8a0cf82-1a47-4997-be74-0d4b15f2de34"), 69, "49,54288;24,492868", "Port Groverville, Lithuania", "Cassin Falls, 713" },
                    { new Guid("fb383be0-d62d-4ada-9890-ccb09042c420"), 196, "50,190296;25,91033", "Eberttown, Bulgaria", "Korey Stream, 6340" },
                    { new Guid("fe14773f-6691-40b9-8a97-00bd146b272b"), 143, "48,718147;27,563679", "North Wendy, Botswana", "Santiago Mount, 6391" }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("03a1304e-5337-4877-b9fa-cf3d1c75ce98"), 1738822819, 0.7278622446306410m, "MVH2KepcAdqUwzEMvmFC4Z93QGB1", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3508), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3506) },
                    { new Guid("05136b42-e928-49ef-8937-712696df43ea"), 899350887, 0.4352561431448410m, "3vyoJbS8FcPWd5LHAxTmBN4EfCa", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3352) },
                    { new Guid("05290eb6-0aa4-4c2c-8508-90c371e1861c"), 363859967, 0.6190231657285620m, "MHiXJ4asV5AcbWodLUNeBjkrqYQgtZ1", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3270) },
                    { new Guid("066de994-9371-4a7e-b9f8-1624dc43d97a"), 321430556, 0.8051347501919540m, "3qTa3PSAyrHb2wxpz4RZgisdQJ1EXW6Fj9", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3609) },
                    { new Guid("084b14da-2861-42fe-8fca-e59ecedbac19"), -1319697389, 0.1002688486458850m, "3ZLDNszGRTBX6P3tyqQVrWA8fSkCwUH", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7906), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7905) },
                    { new Guid("08ad487b-9055-4972-85d1-4eb4ee9243ff"), -1555514082, 0.28382658254830m, "MQtLvETixU28faoDdjyqPVGeW39p", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3924) },
                    { new Guid("0a6ebfb2-6272-434c-9880-b81d44af2f31"), -1191558466, 0.8632237083564110m, "3norf84JjGwDe2TkCZygYpQi5sN", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3058), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3056) },
                    { new Guid("0b7e3fe6-f879-44e5-af66-00335ef1ad48"), 1011938156, 0.2033044294656340m, "LKaj3Y87NT9CrXkwyHDLU42SVcFvEf", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7886), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7884) },
                    { new Guid("0ed1c849-910b-4015-b3c9-44d990f83158"), 1558912628, 0.5099728404180750m, "LgnY1WP5yrJHMEqDsit23cZTvmzwNUdSk9", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7735), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7733) },
                    { new Guid("1315c238-7843-4b14-a6b4-5cbffad29bc4"), 2092267640, 0.4297070461112770m, "LADUcfTWKnL6Z7y13iQmsrX2C9qpRd", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3983) },
                    { new Guid("1341d321-af65-4ea5-9dfa-3bc9250dd8f8"), -1957611769, 0.9828528592792770m, "L3DgQw5PC4qUkmT6hXN7oe8JyAYKtdzrb", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3806) },
                    { new Guid("15f00b19-255a-4850-b5fa-c9f95bdb571e"), -2040188352, 0.09495684772157890m, "Lm5M1ZFRbqGXtKBaSLnJVfgvA24u", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3390), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3388) },
                    { new Guid("1641013d-0120-4f71-9dda-83496a5d4f8d"), -543101037, 0.4814268516560280m, "LcDEbF9i8keYjCp2dTGWKryvfsNZowt", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8113) },
                    { new Guid("177bed43-060a-40a8-8be3-9e15ad0c0c24"), -1121792759, 0.05237645427904570m, "3qCaNfBsKZcXLMy3vUg652jWtwki", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7991) },
                    { new Guid("182ad6c7-b3f4-4ab4-bc4e-2266bc62c306"), -657154743, 0.1295060310722560m, "MAH7wMjxU82YN3bVnykBXTQDzL6eqJ", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7231) },
                    { new Guid("1a1b6b27-d005-41a9-823c-249ddacd02f5"), -2110617746, 0.818951299729050m, "LNWu5zBDqyMdtmpxEnkb7KHA3aFQg", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3141) },
                    { new Guid("1d133ddf-589d-4955-821a-db1a5fe98e39"), -115505289, 0.03375641932784590m, "3y6vKeECTz8dZJNXLVxW4sfG9Ac2tUDr", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3217) },
                    { new Guid("1d5a7015-c555-4d97-9aed-abc96f45bb2a"), 2002250166, 0.3968997398558850m, "MEwLQDMAehV5SYyqfzvt2Gpm4UX", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3691) },
                    { new Guid("23400754-5aa2-47ee-846d-96582a8bbf0f"), 2100651074, 0.5128659341717720m, "3gLF3MoqN2eDZ9Ws4TawRf5Udct", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3465) },
                    { new Guid("2802155c-eebb-49a7-937f-abd7982da94a"), -1492837477, 0.8380190098047040m, "MSFcxRfXmhkbTsW7zriu1tA45gHZw2LKN", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7663) },
                    { new Guid("28434187-26ed-45e0-9ff1-f23f08f431f3"), -1029455425, 0.01132291029000090m, "3Cf4WZvKnGAmd3NYSrjEiz6LyD9BPFHhqb", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3715), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3713) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("28f933dc-6a64-4ca6-8496-a624ec439cb0"), 1289441976, 0.3583134199787890m, "LyDWqQ1jd6h8Va3ZgxXciTJ7CME2", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3407) },
                    { new Guid("2aff8a1e-2dd0-41a2-80fa-131b55d5b8f2"), -1789650111, 0.5893073360291580m, "Mac64tqz2WTZpLDxvQsu3XogUECdbVe", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7947) },
                    { new Guid("2f72a756-9c56-4923-ad3a-69d91d40f271"), -1558998276, 0.7585057977356980m, "LGXDvqpYC3ixQwfE4uJ7tVhz9rAF6", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8093) },
                    { new Guid("3241c1b6-8e2f-4f0f-8040-3bc891b57d1e"), 365207042, 0.7823510754011490m, "LU5f6WbMdnsGVEJXmK3ki4gHDqQr9p", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3114) },
                    { new Guid("3241cbc8-60c7-4d85-bc94-5e47de93cd50"), 1843977483, 0.5906980497890720m, "LY1ted8MaBr9XKHuPV7wEfgiL6WU", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7866), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7864) },
                    { new Guid("35bb9590-5ac0-4f9d-b997-5dd6a9497951"), 1271073172, 0.2403026829500550m, "LTQxw8Mh4sCFLj7riKopBdk65JDPWbXcE", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8052), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8050) },
                    { new Guid("36cafd7e-b20d-402b-a350-58372bee9783"), -2130966421, 0.3702659961270470m, "LFfgmt1zhL5pJKNVGQ3XsoUY6Hbiq", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7535), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7533) },
                    { new Guid("397b2613-95d9-409b-af58-8033a1e74709"), 1062071177, 0.5347770863159360m, "L2L1c7enTHQMZuqDpAEW3K8dwibfFVa", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3585), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3583) },
                    { new Guid("3b98d78f-29b2-48a5-8b2b-c3adc5dc1afe"), -1517271547, 0.4676228428743610m, "3pHgTN91LFPDnmwWh5QufUx6yqr", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3525) },
                    { new Guid("3ccd91d7-c858-4858-b43c-d198420f531f"), 1607201895, 0.9102928815414360m, "34oayqnL2Q8ST7DUP6bmwgzhsXK", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3888), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3886) },
                    { new Guid("3e6f970f-27b8-47dd-beff-9c334d162bdc"), 161344619, 0.770144675988140m, "371JTKtydUWSCYV23nP9H8pweLF5rBqA", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3668) },
                    { new Guid("44906530-56b2-4dd8-b521-86a89d9194eb"), -404983241, 0.3769776907936150m, "LUX73csagtJBAjwQPVGpDky1FbSMxR", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3181), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3179) },
                    { new Guid("462dfb6b-441a-4279-9954-7920ef68aa68"), -2097799981, 0.4020769016569480m, "3ZmQgfruPt8o9bAV4vSidhYEKBn1MN3FRw", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7758) },
                    { new Guid("4b6606a9-3d10-4e80-b86f-2df77c4371fe"), -2128122196, 0.0191933320477040m, "Me9U6jKoRC5rkPJxaXAFniwbYfmBcsqV", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7179) },
                    { new Guid("4d73d7a5-9db5-4fd2-a0ba-77f294de70c1"), -385617998, 0.6161802989921820m, "LytkfXb7uGmR96nB4MNvdxiVhP8", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7075) },
                    { new Guid("4dab1208-ca7e-4c9f-88c4-3edfcd90a541"), 2107177566, 0.2941394347612420m, "3eb1mRGipSYzNas3r8DdLoXCjBugv9QxM5", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8071) },
                    { new Guid("508a526a-c26c-48d3-a05a-1b93bd50ca4f"), -728548915, 0.4774532431072730m, "31ZaKGWuNTLV9Bkgqr3X7wUSpJ56", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7643), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7641) },
                    { new Guid("51c5d9b5-aeaa-43f3-83db-e90814cff53a"), 1053649517, 0.2256925426604330m, "M8hZ12szbKeQkN4D65rMpgtSHma7", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3647) },
                    { new Guid("550c9908-4284-4c22-8df5-34bf26b7fe12"), 1367047252, 0.353439703429140m, "MAwGC2HbidBENjkDs69P7Mmy3ho81v", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7472) },
                    { new Guid("59500a96-6847-40c0-8c4f-84f196e3d1fc"), -952874347, 0.9037127482510150m, "LpiaAdmDLEF1YHKwevXgz3fc5R9", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2815), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2771) },
                    { new Guid("5c24acb3-ad8a-453c-9bfa-c503ab409e19"), 143372881, 0.4063260170408120m, "LT3hzZND9ryXFRoYPfsbGLBQtMneqW6", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7846), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7845) },
                    { new Guid("5ca15d8d-e0fe-49aa-bf52-230334ba6e4e"), 1189376386, 0.9311081818484490m, "LdJRM7yU2o3rXPFzvsaxpCuYbSNmqi", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7798) },
                    { new Guid("5e3cec8b-6ca4-46ae-9562-5689f87e6a23"), -1674610143, 0.5993837214434660m, "LYCRjKVGHFvm9q6i5yngr4ta2pWu1dT", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3242), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3236) },
                    { new Guid("60544752-385c-4ebf-a9fa-cb3eacc4ddef"), -1889002510, 0.2335097423379830m, "MFgwi5aqpVMuHoSvWxnm6NE9ZQzUh", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7493) },
                    { new Guid("61aef041-ce6e-477d-84ab-e8f461b83707"), -1956505014, 0.6162697119223920m, "35mNZ8tvCPdBDF3nxS6TXKMG7VpysAQq", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7685), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7683) },
                    { new Guid("62e75e25-d657-4e06-88bb-dfdb309f319e"), -748921539, 0.7704123177333530m, "Lbr4RBs1qmH9DMagSFuzykdhKXNvG", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3752), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3750) },
                    { new Guid("69ef6a1b-ea81-4676-bc34-ba5453e63353"), 1513771760, 0.3882244298268740m, "MS9NTzJZqUgmt3MWi4Djuh8dYQpH", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8012), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8011) },
                    { new Guid("6afae337-35fa-4184-8a0d-a2e0301d88b5"), 1994195491, 0.3608891533681210m, "LwneAtf1M7Ed9jimDLG3ap2WVBNyKJo", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7323) },
                    { new Guid("6c0b1a11-643d-4f46-93d0-914c2c02e38d"), -114548739, 0.8009061872868170m, "MmUcbdYNsQk5qXtAwueSWofr72GxJy3", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3038), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3036) },
                    { new Guid("6d9dc965-27ae-456d-9bcc-abc2a9722bb0"), 1891155477, 0.4715581159702460m, "3HEvWjhgpU3Y12sdnGtoTiQwRMe", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3097), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3095) },
                    { new Guid("6e64bda7-b7c3-48c2-b10d-6e986fa22c7c"), -1336718251, 0.8368204381923120m, "3SVbcedhWu3oA92QsXN7KxPjpFGTL1", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3199), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3198) },
                    { new Guid("73c3f388-4483-4f57-a765-623b5f291758"), -366300622, 0.7716426146084340m, "MrDmaXeZVfUBxTCqzM983LWyoQnjdcP", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3312), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3310) },
                    { new Guid("745c3ed8-309c-48a0-80d2-9ac9f2abdb80"), 720935184, 0.2482858864719820m, "LFYQE7aCjzPMm3cv82ni4ekRpb5fqsLH", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3963), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3962) },
                    { new Guid("76003919-6702-4849-a6e1-647b4ec8d669"), 1086852618, 0.5426721070467810m, "MNnVcUkvuQe64oFGBHhy1qsipYTrCZD", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3336), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3334) },
                    { new Guid("7dfd96fe-a7d9-4d15-9eee-95b1cf6fc360"), 384279878, 0.9147238725635710m, "Mc39LHxPKmFAZwEeRvytMjkrUu2X", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3161) },
                    { new Guid("805256b2-0ba6-44a2-b2f4-965606812824"), 2093852577, 0.1634379071757540m, "3epiLnU7C6uyPRbtAXV4J8ravwZQo5DmYf", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7705) },
                    { new Guid("807e1e1a-bb90-4f66-aff3-91c11b0d6da8"), 1538884209, 0.9165433677631340m, "Modu1xHWpfN4DBnRvmXa8AbqeVz2s9EyZ", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7968) },
                    { new Guid("82bbef9f-ed60-4c30-8210-da8359cded31"), 1204133017, 0.3417918677613160m, "Lv2BYgdMWxF7SEbsywGtzmZUrRfpocHn", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7383) },
                    { new Guid("85dc2182-15ce-40dd-8db0-913a904b14d6"), 427596445, 0.7912628427564820m, "3pLQx9nK5gacTGHbyE6jMJFDmkthPoR", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8135), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8134) },
                    { new Guid("894b061a-c302-4b42-b297-7385111f5dbf"), 1882559415, 0.7541752666378090m, "MgxLsNX42EqVAurMTzaW5vYi8KFPd9HQ", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3016) },
                    { new Guid("896a60a8-3bec-471a-887f-1df89dd2672f"), -1243764798, 0.09846921109004670m, "LfGH9WzC8yNoTKpQFBViJrgPRsxvSdmU", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7365), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7364) },
                    { new Guid("8c83bc61-0db1-48c5-8879-4447eccc88b9"), 833137340, 0.7047568089008860m, "MHM1WCqt8gLj6Jo72rcdBEPYwNkFD", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7156) }
                });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "PromoCodeId", "ActivationCounter", "BonusSize", "Code", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { new Guid("9202fcc2-4d19-4821-b69b-bd1c8db99ec9"), 1561314185, 0.2220206576502120m, "MS41zLmteQy3MsncDpWora98NC5AT", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7406) },
                    { new Guid("92f6ff6f-92b7-4837-9fbf-8d10b390723d"), -905835175, 0.05645384544529340m, "3oFbARVqc2tu675MJTE3ZzPUyksQGp", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3628) },
                    { new Guid("9cd18d6a-5047-494f-a7f3-724b371b26c5"), 34727467, 0.2770553960366970m, "LEdvJLn9bHPYM4QCjRaAy5xZNkSoV", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7618) },
                    { new Guid("9e579f54-45d9-4ee3-b108-f6dfadaf0b27"), 352837009, 0.3262675209176690m, "L53JoQS14kvdAXGYtqgCPjaW9n6T", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3768) },
                    { new Guid("a32c30a4-60e0-4aac-8a4f-c84d79b3ed1d"), 1673903939, 0.777835964532660m, "39jpWiVA2wzfPS4boMrnHc7ZNLK", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7304), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7302) },
                    { new Guid("a468a037-a522-4234-85d3-125cb8cb712d"), -1336914743, 0.2728771416971630m, "LPBDWS5TJob9hGtcxAvYk2MjqziE67", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(3945), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(738) },
                    { new Guid("a5b9bb1b-dc20-4179-99ac-343e058d385a"), 1601105622, 0.7087143249125450m, "M6fJZzx4gdc8qsY3yGokU1HuhKVP95t2", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7133) },
                    { new Guid("a9c55dcc-84a9-4ca5-952f-2fade6166ace"), -1035533207, 0.01310365335356020m, "L7DgGNYLRHJQm9cT6VbusqWnC3U28a", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7345), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7343) },
                    { new Guid("ad987145-c689-4742-b9df-801e698f1f9f"), -1177695587, 0.2631739256796430m, "LQBunHz7Zb9PqwVaApfUx4ekg1J5823vL", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7927) },
                    { new Guid("af79ae6f-84c5-4c9d-a0de-9cc01c202476"), 1581247148, 0.5095514078276160m, "LSRgXFMU9mKGnCZJ2DorNqEYvTzjptL", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8031), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8030) },
                    { new Guid("b9e3799d-590d-4d49-a035-339f2d7a3287"), -137460435, 0.6274715316974130m, "3uKqsRDYhfWy1gFpbXarm7jTo9t", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7201) },
                    { new Guid("bef25f38-12fb-444e-a77e-2476d5dba1e9"), 1694513259, 0.6362121277010540m, "MDz6ZoT7HsXPyBN9K8WUd2v3GYnuxMjt", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3907), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3906) },
                    { new Guid("bf92627d-6a1e-464a-bf99-2e82c2acee50"), 1952484707, 0.2842270119504480m, "3yiDbsTPcYXAF74e5dpuEQxj1hMKVLWN6", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7825), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7823) },
                    { new Guid("c162a2d1-fa43-4c01-815e-3045adf099c8"), -496942301, 0.1960226999242450m, "M6QUTv1bj2YsVe87ELgk3dwBNDJWP", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7254), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7253) },
                    { new Guid("c2ed87db-7bf0-4644-ac60-7bad3aca8642"), 1650443208, 0.4907549913086430m, "MQRBVyPj5YnmU8iMK9H1wT7fAENoph4SxG", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2996), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2994) },
                    { new Guid("c46a4569-7ac0-46a0-876e-5abb69913367"), 2004927, 0.7334949716618130m, "LcbXSu9aLoQwdVgYhm17FPW4sHGn3Zej", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3945), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3943) },
                    { new Guid("c53ff1af-4222-43d2-8c23-c6c8e43e1eba"), -1271127116, 0.9151795825201030m, "3scF5Qhb7jmdPf9834VHMiruZywY", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7427) },
                    { new Guid("c69f522b-2a39-4479-8eba-ee82cb8ae53f"), 2028338948, 0.5614665063625940m, "MixgCULb2rufs83pAM9HYTJ4ktdzo", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3076) },
                    { new Guid("c75103c9-7b41-4d33-8475-9e5a5c39fd68"), -1833757756, 0.2382285012489260m, "MHVxJuCaGkE83yULijWKFQdAtfcDms", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2966), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(2963) },
                    { new Guid("c9e6720b-a035-44f9-90d2-931b6d9b8a8b"), 1573019614, 0.8423247026442740m, "3Bqt7vKarMkXPhoGF9QmCc234DxjJRzSUL", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8160), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(8159) },
                    { new Guid("ce261e52-1d13-432b-8ada-e5e43db84e96"), 117751088, 0.1456753883157180m, "36yJrYZRCDoXevLcMPpzT4fgbQUh58i", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7277), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7276) },
                    { new Guid("d2963818-2c87-424d-ad16-4cfbe626dc87"), -1983758301, 0.6402787008161730m, "MfaNpAyn5WtkbqEL4UJhoxsVRGw", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3372), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3371) },
                    { new Guid("d3a196df-89cd-4c64-82d9-876d4104d862"), 1820212452, 0.2555429511219260m, "M7YrFAymsdGPNoCHpzDkTqjLUaiVhvW", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3447), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3445) },
                    { new Guid("d43e7c23-6f66-4058-ab0a-a5863810be26"), -1428517656, 0.276080976816310m, "3rQjvoN8EwGJDmP7RAxzW1eBqLK2uHd", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3868) },
                    { new Guid("d949981c-b0a9-41c3-8bc9-c112d49e3cb2"), -1399052325, 0.9991207717432670m, "LaqtPuU8weNDG2Rm3SkHxMX4iv1yC", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3732) },
                    { new Guid("d94f0f77-4c17-4406-9091-b328170a5f32"), -2125129305, 0.9987063711675680m, "Ln6qFyubiahYKve71UrJt4zfZdH", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3490), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3488) },
                    { new Guid("dd2f65fc-4954-4b3a-98d5-1ee0edfe06de"), 1869608064, 0.723528622707820m, "LPdVcMnyArYCeo2tv7wqG6QhR4EjKsHzU", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7447) },
                    { new Guid("dd5c4f47-8771-41a1-8640-8013524a7dd6"), -246757605, 0.09985024640286790m, "MuaTRW4dbeHzAsLJEwr6PUxVZfYgov5k", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3849) },
                    { new Guid("ddda0bcf-8d86-4f4d-bf76-24a3b0f14dc4"), 1363288017, 0.9344655998364430m, "LxXowetLQNaPhYp78BmAGvsJkgV", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7778) },
                    { new Guid("e001f607-8a32-419f-b6d5-3352260e032f"), -929421272, 0.6054412431886460m, "M26HKQJeAdrsSBmUT5iWDzZcup7", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7513) },
                    { new Guid("e241a9fb-163a-4f56-adbf-6d23b4afeb18"), -1785514221, 0.5771310961609110m, "LhU67cPxmzbJuNYfQHDjKWg5Gqk", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3288) },
                    { new Guid("e3bedcc4-0783-4c3d-b399-faf2eef244be"), -1373478674, 0.848480984156990m, "Mecri2zM1JDwo9yXAu8gEqN5sHLK3PQx", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7599), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7597) },
                    { new Guid("ec6bd611-cbb5-456e-baee-e0704eed4001"), -301836296, 0.5805839305221610m, "3zcZHhmV8KxYLuQed1vCRAs3oaP", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3826) },
                    { new Guid("f3694e36-90ed-4418-aec4-5087aca871fa"), 414508531, 0.9891925578939420m, "LqHE5fjMxtXBzG2c48JSTLV1DF3Urv", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3425) },
                    { new Guid("f98d83d8-093d-4ec6-a393-71e0fcea2bbc"), 2052843290, 0.59732961089250m, "3GpgDx1L3nSoQ6zXPfhK9iUbdMVc4", new DateTime(2024, 6, 12, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 6, 7, 15, 15, 29, 674, DateTimeKind.Local).AddTicks(3787) },
                    { new Guid("fed794d4-8b23-48f1-ba3e-118c3dea9698"), 834752482, 0.3862181951507550m, "3ZAVX3uT5YM1wyjHWRdrtmoekcqb8sQ", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7553) },
                    { new Guid("fffd4be9-6d71-4629-930b-b4a8bca0ab38"), 1002793943, 0.8918256383756240m, "MJ27Qn59DPyEg4FN1UsAWHqXvGkaoYL", new DateTime(2024, 6, 12, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7578), new DateTime(2024, 6, 7, 15, 15, 27, 643, DateTimeKind.Local).AddTicks(7576) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("082d68f3-3ec8-4587-9852-34cd715f794e") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("0f432380-a89c-4564-a477-a1ed20795e01") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("18971e31-ee25-41fd-bafa-129547aefc10") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("19c67f23-dfcc-4228-91b6-db840755a673") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("21856d76-0810-4123-9f39-8fd468591282") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("24292576-82c4-4a01-961e-e050d58bf4a8") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("2a7af252-1892-408c-8a62-8885f15e7f65") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("313a1b63-2c0c-411e-a611-28a27b318502") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("41296760-deca-4b2d-a760-5538da32ccb4") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("51274356-5ef0-4e46-a687-716d200f49e1") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("53792862-da15-45a1-b0ef-d025a7608026") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("61fe1433-1b16-4004-8246-4e030b366c6d") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("65012c66-d07a-40f6-9789-b100201359c2") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("67a0fefa-c903-4326-91fc-981d72b581a8") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("68d876f2-c855-4a3a-b244-f66443d9d833") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("6e90baa7-8b75-4108-acaa-210af704a12f") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("74b3dcc9-46b9-432b-a105-af04273b540f") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8959e331-7a84-433f-9378-9aad487e24b6") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("913aac82-79cd-4930-833a-d54464607133") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("99e79b31-2994-4fd2-956f-0294e124da96") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("9a57b367-770f-4f86-8d83-869ef37800a0") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("a0c72d91-dc13-4995-848c-613286a462f4") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("ad5b9802-88b7-4c47-b138-778817c4050a") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("afa896ab-be1f-4401-923e-90219b5466bb") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b6691519-38b6-436a-a19c-602dda7868aa") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("b80d479f-1611-46e2-a055-1de659d203b8") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("db79945a-0e64-4c97-801f-a38a1e357d12") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("de7d9783-5299-4552-b426-e13c1b4a4995") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("de984da9-04b5-4417-b831-fdf348dbff4e") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("e698e260-89e1-4c83-b493-1379542f5647") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("f50dbc58-9b0d-479e-8402-e939027091e8") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("e89a2c5d-83dc-4035-9b9b-25731d704a0a"), new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4f8fce0f-453e-42d8-ba4a-112b23f1d679"), new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("239fe216-5959-47a2-bb00-9d5288b23c19"), new Guid("fe114181-f2e6-4432-86af-f7d827b491ef") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("00bcc30a-8126-4561-a90e-422ff07d2df3"), "Jalon_Barton@hotmail.com", false, new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("00c5b371-d836-4116-b9bb-30ba106ea82e"), "Roselyn_Metz34@yahoo.com", false, new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27") },
                    { new Guid("011fb34a-f2e5-439c-afea-832b9b600cdd"), "Eugene.OReilly26@hotmail.com", false, new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("0215398d-1d04-4c41-af23-d340fdb7b9e2"), "Tyree77@gmail.com", false, new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("02518cd6-63e3-4830-bbd7-e76497fb396b"), "Pascale39@gmail.com", false, new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684") },
                    { new Guid("028ea07d-1c25-4b40-8edb-6153f17f833e"), "Yoshiko.Considine@hotmail.com", false, new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("02bdc0e2-4d1b-4b22-bb67-6045443c1ff0"), "Madge_Streich@hotmail.com", false, new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("02c3dc29-68d4-492a-a16c-2af77feb34ff"), "Kory.Osinski75@gmail.com", false, new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("03858c8b-5c0b-4b9a-b7c3-7f43466bd400"), "Kali5@gmail.com", false, new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("039f6b23-99de-4647-b777-befdc35a82c7"), "Ford73@yahoo.com", false, new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c") },
                    { new Guid("03b05dbe-1d1d-47b3-99f2-7df4ed084cf3"), "Frederick78@gmail.com", false, new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("042ec348-2f5b-4411-bc42-a5f7cac6b439"), "Lamont69@yahoo.com", false, new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("043ed740-d3de-4d85-8cb5-0a22c764f22d"), "Mack.Connelly48@yahoo.com", false, new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("049448ca-2899-4663-ace6-6c5bcdafa804"), "Drake_Hamill10@hotmail.com", false, new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("04facbeb-49aa-45ff-aeac-5fcda3970fbf"), "Eda_McGlynn89@gmail.com", false, new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7") },
                    { new Guid("0609599f-b905-4612-b6ac-a62c4c7e97fa"), "Hope_Satterfield88@gmail.com", false, new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40") },
                    { new Guid("061eb732-0032-4c2d-aff0-bbe7d65bd162"), "Kade.Leffler36@gmail.com", false, new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("067bbf8d-17a7-4a5d-9d07-bff72cf4ea84"), "Stanford.Daugherty85@gmail.com", false, new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("06bebd3b-bc7a-4c76-b1c8-ed3aaca93651"), "Zoie.Welch@gmail.com", false, new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("07db1d96-1aec-4e11-9034-01592bdc703b"), "Randall.Bayer14@gmail.com", false, new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("07e19a84-6b03-4267-9a90-f2e90496f02f"), "Citlalli_Wolf26@hotmail.com", false, new Guid("24292576-82c4-4a01-961e-e050d58bf4a8") },
                    { new Guid("0867e992-8089-4414-af39-d23ad2f09f3c"), "Larue65@hotmail.com", false, new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("089328f6-d2f1-4e28-81c4-3c4c16c678b8"), "Nyah21@hotmail.com", false, new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("08e4371f-df3c-4586-b503-7878fddc8e06"), "Edmond.Huels74@gmail.com", false, new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("0909a995-d25e-438e-ab08-ad4e43fb9f8b"), "Else53@gmail.com", false, new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("095f39c3-9732-4740-aeee-1a4b9ba63db8"), "Ansley14@hotmail.com", false, new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("09810b01-fe97-4f6c-af12-a0d324249164"), "Filiberto13@gmail.com", false, new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e") },
                    { new Guid("09a3a3fd-5695-4471-b8b3-1509fe5bb59b"), "Ashtyn86@gmail.com", false, new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("0a3409ce-5795-4c5a-bedb-5b1850c69730"), "Clovis77@yahoo.com", false, new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("0a3692c6-1153-4bc9-b11c-5033c9771d17"), "Caitlyn.Breitenberg9@yahoo.com", false, new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099") },
                    { new Guid("0a6a0813-7e1d-4913-816c-5375f2f189c2"), "Dale.Cremin@yahoo.com", false, new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("0a7f6ef6-d839-41fc-82ac-4f22a96f3a46"), "Pearline_Marquardt40@hotmail.com", false, new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("0a95c99e-bfbd-4e35-8928-36ee3d85fac1"), "Winston74@gmail.com", false, new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("0aa3897e-4476-4e32-a1e9-80d3bc49b186"), "Kiana76@gmail.com", false, new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("0ac6f8b4-7ab2-4591-a036-2f9329bdba81"), "Dolly78@gmail.com", false, new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("0ad8cd56-1eb1-45a5-96c7-a31b60cf54dc"), "Jess38@gmail.com", false, new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("0bc43ec9-1087-46ae-9166-02c781fcf736"), "Makayla67@yahoo.com", false, new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("0bda338a-dfc0-4f45-b0cf-9fef12a78fe7"), "Kevon9@gmail.com", false, new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("0bfa26f9-c8e0-467a-afe0-ef8f08b1f1d8"), "Murphy49@hotmail.com", false, new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("0c01be07-960f-43d6-a4ef-7e82c652dbc1"), "Flo.Schowalter@hotmail.com", false, new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c325d84-4c78-4f43-82df-3fae03978d35"), "Wanda92@gmail.com", false, new Guid("fe114181-f2e6-4432-86af-f7d827b491ef") },
                    { new Guid("0c433bb0-e462-4819-abc3-f62c064873c6"), "Tremaine.Langworth@yahoo.com", false, new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("0c999591-c790-49dc-aa86-031bdb4a6a3f"), "Anna_Monahan@yahoo.com", false, new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("0ccb6c44-39fc-4c3e-9743-dfcb8cbfcbb4"), "Andreane.Langosh@gmail.com", false, new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337") },
                    { new Guid("0d732d47-6a20-47ca-8d70-56c211359c3d"), "Jordy.Runolfsdottir@gmail.com", false, new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("0dcab6c7-3fa0-48bd-942e-2d9366bb7bb0"), "Janice_Schumm2@gmail.com", false, new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("0ed270a9-9895-4b60-bd01-4251f12ac934"), "Jessika_Schowalter82@gmail.com", false, new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("0f8d96e8-006a-4ca5-8193-f8e7c02342bb"), "Tyrell.Kutch@hotmail.com", false, new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("0f98124d-ee92-4e5b-854e-5416765d97ae"), "Ilene_Anderson40@yahoo.com", false, new Guid("53792862-da15-45a1-b0ef-d025a7608026") },
                    { new Guid("1009cdcb-c827-4d7a-94b6-2245db0d37f1"), "Mohamed.Roberts72@hotmail.com", false, new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("100ea48f-d7f1-4f4e-a7a6-88e16e30834a"), "Jaime_Ullrich@yahoo.com", false, new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f") },
                    { new Guid("10856bda-46ef-4405-8e0e-af0217ad842f"), "Douglas7@gmail.com", false, new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("10c1bc08-5f99-4726-bbf6-7b7ec1d27f19"), "Winfield_Lesch71@hotmail.com", false, new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("10c69fff-29f7-4715-a25d-0d1e1d5f16ac"), "Jermaine.Hessel89@hotmail.com", false, new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("114aca6e-f28d-403b-aa9c-a00543034e9a"), "Mckenzie_Farrell@yahoo.com", false, new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("121efff7-2341-4bd1-a331-c4fa94431155"), "Santiago.Kunde@hotmail.com", false, new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49") },
                    { new Guid("123b7ac3-471c-45f8-ba53-7758ae4c8428"), "Berenice_Flatley@gmail.com", false, new Guid("ad5b9802-88b7-4c47-b138-778817c4050a") },
                    { new Guid("123ff372-6b8e-4bf3-800d-2fb3916c2062"), "Ayana62@yahoo.com", false, new Guid("68d876f2-c855-4a3a-b244-f66443d9d833") },
                    { new Guid("12693a50-86fa-433b-97d7-eb4b9fd2c2dc"), "Ron83@gmail.com", false, new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("12ee4c82-c5f3-425e-9d64-b90c0afbfeee"), "Destini52@gmail.com", false, new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("12fcb226-a44c-413f-8ba4-ebcd6f47b69a"), "Drake68@hotmail.com", false, new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("1347f766-9274-4a04-b5de-2a13dfbe8ff6"), "Milton.Borer15@hotmail.com", false, new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("13928ab1-a22b-49c8-81ec-805593751506"), "Stacy.Jaskolski46@hotmail.com", false, new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7") },
                    { new Guid("13c594b9-9b02-45a0-b85c-29b0aa448794"), "Roxanne_Nitzsche40@hotmail.com", false, new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("13cf08f5-83a7-4a8a-b420-6be1dd33ef57"), "Napoleon34@hotmail.com", false, new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("13e53605-e83f-47b6-bc78-95cb3ddd8419"), "Donnell59@yahoo.com", false, new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d") },
                    { new Guid("144c2f1d-bb31-4a9e-a5ff-185eb6427900"), "Kayden30@hotmail.com", false, new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("1450dc5a-ec2d-42f4-9ade-a99f8a507ef6"), "Estelle.Rohan@hotmail.com", false, new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35") },
                    { new Guid("146e2c2f-b17b-44c2-912c-3ca0a6fbbe64"), "Leonel_Stamm@hotmail.com", false, new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("14a58a32-f1db-46dc-a2cd-7b196a332649"), "Harmon19@hotmail.com", false, new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("151f3e55-2689-4a00-bfff-68e7715e26a2"), "Tracey.Grant67@gmail.com", false, new Guid("21856d76-0810-4123-9f39-8fd468591282") },
                    { new Guid("15a21d65-1c0a-4fbb-92a1-0b26bf397b37"), "Lucious_Sipes99@hotmail.com", false, new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("15d1ddcc-7d8a-4219-bdf6-15ebe0825090"), "Ollie.Senger44@yahoo.com", false, new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("1662590b-7695-4fdb-9d7e-a00c9009384b"), "Thomas.Ritchie11@yahoo.com", false, new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("16a036c5-52c7-4ebd-a738-cc1ca787da67"), "Serena.Lakin10@hotmail.com", false, new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("1708006c-d5a9-42d5-99a7-b49ffebb200c"), "Lacey_Feil@hotmail.com", false, new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c") },
                    { new Guid("1730dc9b-a6c3-4ec9-90da-9913bcc402ad"), "Rod2@hotmail.com", false, new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("1861d354-1b33-48d4-81b9-e3a4a506aadf"), "Daisy29@yahoo.com", false, new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("1886f8ac-af74-48bc-984a-4c05f9e6bd5d"), "Cierra_MacGyver@gmail.com", false, new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("190b51da-0dfa-4978-a041-04c5b1c352cc"), "Julian.Kertzmann39@hotmail.com", false, new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("191c60cc-2903-4900-b571-a6a6c247198a"), "Emilie_Bernier11@yahoo.com", false, new Guid("b6691519-38b6-436a-a19c-602dda7868aa") },
                    { new Guid("193af8be-aaa2-4861-9e57-50d336809a6e"), "Kaycee.Langworth@hotmail.com", false, new Guid("8861729f-4a56-4d39-bc73-6365e353facd") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("198d92f0-2817-4b8f-818b-d5e21f346301"), "Adell53@yahoo.com", false, new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("19e3f9a6-4217-4273-b92b-dd9d6dc2383b"), "Kim25@yahoo.com", false, new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374") },
                    { new Guid("1a0a8161-bb7d-42cf-9768-0a0337bbb0cb"), "Ona_Breitenberg91@hotmail.com", false, new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("1a6161b8-966c-43ed-82c8-0edf3830c431"), "Maybelle.Stokes@gmail.com", false, new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615") },
                    { new Guid("1aa74547-6696-45e1-afa0-28b892dafbf2"), "Caden_Schamberger@gmail.com", false, new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("1adc3184-9473-4a9b-83ee-7800b02bdd92"), "Domingo5@hotmail.com", false, new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("1bc071c7-e507-4be5-821a-0dfbdc7c580c"), "Tyrel.Conroy@yahoo.com", false, new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("1bdd137e-130e-4786-83d5-7c67a0019b45"), "Clyde66@gmail.com", false, new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f") },
                    { new Guid("1c091528-904c-4dc0-bfa8-d18cecab2eef"), "Jermey68@hotmail.com", false, new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc") },
                    { new Guid("1c16e9db-efb4-49a4-860d-e0366a8178fe"), "Fatima_Feest@yahoo.com", false, new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("1d32008f-6716-4d2a-96c8-d7e850d1b6f4"), "Jacey.Williamson23@hotmail.com", false, new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("1de86438-308e-4028-b28d-2395f149dfa3"), "Marcos24@yahoo.com", false, new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("1df55275-ef97-44dd-b34a-168714195b80"), "Martine_Ernser63@hotmail.com", false, new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a") },
                    { new Guid("1e3c12ea-b59a-42f6-bedf-900c319d2e5e"), "Nola71@gmail.com", false, new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("1e690f91-0f2b-4243-8251-5135bd3cffc0"), "Hulda_Littel18@hotmail.com", false, new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("1e9d5236-bc7d-40c7-846d-d88302a78922"), "Gino_Denesik65@gmail.com", false, new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("1eeba8ba-a606-40d3-a504-50175e40766f"), "Louvenia56@hotmail.com", false, new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("1f307175-9ec5-450a-bd99-42f376b1ca4e"), "Gwen_Jaskolski80@yahoo.com", false, new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("20b24299-3648-486e-bcf3-540cfcb8ab2f"), "Lexi.Cummings39@yahoo.com", false, new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a") },
                    { new Guid("210996ed-7d30-4ef0-bf45-9530bb1fe06c"), "Ally_Rice@hotmail.com", false, new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("214f2502-d904-4055-85b4-580ba212d4c1"), "Rashad_Kovacek@hotmail.com", false, new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("22282381-260d-4511-9e9f-e726a3b1032f"), "Kayden.Okuneva@hotmail.com", false, new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("22445346-5fa7-458c-be23-657702da7b45"), "Ivy_Dicki@gmail.com", false, new Guid("53792862-da15-45a1-b0ef-d025a7608026") },
                    { new Guid("22acdf97-2907-4325-8316-05b6caab7c25"), "Margarette.Christiansen@hotmail.com", false, new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("22c39e36-b05a-4ce0-8862-2a5148d2a590"), "Ardith_Bogisich@gmail.com", false, new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245") },
                    { new Guid("22f45c46-35e8-4fd2-b94f-ffca834c587e"), "Kory38@yahoo.com", false, new Guid("8959e331-7a84-433f-9378-9aad487e24b6") },
                    { new Guid("231f250d-04c8-48f0-8397-21836a4d2c9a"), "Aletha84@yahoo.com", false, new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("23b1b61e-a247-4266-bb60-2a41629520e1"), "Maurine.Johnston91@gmail.com", false, new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("240db29f-e3c2-4aa2-8c7e-42c593f57bdd"), "Frieda_Hansen@yahoo.com", false, new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1") },
                    { new Guid("246ed563-bba1-44a4-bfb7-42f0ff35fbdf"), "Jean_Waters33@yahoo.com", false, new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b") },
                    { new Guid("24aea5c8-eea1-4bc7-b484-de8b1b08e0d8"), "Skylar11@gmail.com", false, new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7") },
                    { new Guid("24bad318-9bbb-42ff-912a-53241ded21d0"), "Jules.Schmitt@yahoo.com", false, new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("24d10ed2-5856-447b-82d1-6c393ecc0a77"), "Enos49@gmail.com", false, new Guid("afa896ab-be1f-4401-923e-90219b5466bb") },
                    { new Guid("24d8297e-4b8b-406d-b89d-ae4eb22c297c"), "Carmel.Mertz@yahoo.com", false, new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387") },
                    { new Guid("25620a7b-4002-4a0e-a20e-9c214c5e5347"), "Bennett90@hotmail.com", false, new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("260e0ab5-3850-42f1-a269-7d6b8846f38a"), "Evan_Wolf17@yahoo.com", false, new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("2657c0fe-c062-44e0-b6da-28bb309b49cc"), "Brenden.Keeling55@yahoo.com", false, new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("26656c87-df5c-435a-833e-1f53e90831cf"), "Norris1@yahoo.com", false, new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("267a026c-63bd-4f91-830d-1a3bfa39eef5"), "Ray75@yahoo.com", false, new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("26a0300c-c922-4e3a-81b5-eec396fae7d0"), "Stephon29@yahoo.com", false, new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("26ae24fc-bf6b-47b8-87a1-20560ef416ee"), "Alexys0@hotmail.com", false, new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8") },
                    { new Guid("283ac853-f571-41b9-b61d-154d084255d4"), "Kelton.Gutmann97@gmail.com", false, new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("284228ca-8cfa-4084-b827-6ce21910a810"), "Merle_Farrell79@hotmail.com", false, new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("28463e7e-6475-4d30-aba7-5941db8dcfa6"), "Augustus.Christiansen70@hotmail.com", false, new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("294f9564-40a5-4a52-b05e-2edea894ce88"), "Eulalia.Frami4@hotmail.com", false, new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("297c8a2e-233d-4d16-8c25-9aa14d8ad02c"), "Candace19@gmail.com", false, new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("2a564d1c-8cc2-4a2f-86fc-cfacbb7c4282"), "Deontae88@yahoo.com", false, new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f") },
                    { new Guid("2b393a01-b44f-4389-be7d-26985ace3377"), "Judson_Hermann@gmail.com", false, new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49") },
                    { new Guid("2b7ee16b-738a-4767-9672-ad88dc8735a7"), "Bernadine3@yahoo.com", false, new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("2bb676d0-7b5f-45d4-98b2-5d7ff3dd7905"), "Tara_Thiel12@hotmail.com", false, new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("2c328648-c258-4526-b96e-ad5d3627bc6d"), "Ahmad.Spinka@gmail.com", false, new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("2caba6af-3fb8-451e-841d-93efc5d281f0"), "Hershel.Reichert18@gmail.com", false, new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee") },
                    { new Guid("2d782e58-b981-4f3f-b00b-dfef8ecbaeca"), "Nels_Jast@hotmail.com", false, new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f") },
                    { new Guid("2d9c791b-50a5-40c5-b413-f30faad1177d"), "Dangelo.Bosco@yahoo.com", false, new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("2dcf2b11-ce4a-4062-a148-17188c52c30e"), "Donnie.McLaughlin@hotmail.com", false, new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("2dd868e2-7977-4e99-abc7-85a22ee722cc"), "Noemy.Parisian45@yahoo.com", false, new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("2e2e14c0-c883-4ba5-9878-189736be4aca"), "Jayden_Moore@hotmail.com", false, new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("2ebed4c4-d60c-4c5e-adab-b89f19db1322"), "Saige_Ward@gmail.com", false, new Guid("de7d9783-5299-4552-b426-e13c1b4a4995") },
                    { new Guid("2ee3d7a4-f23f-4cc7-836f-499a0d55b636"), "Evelyn84@yahoo.com", false, new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5") },
                    { new Guid("2f56ffb1-b91b-47aa-bb4d-d12148fc3992"), "Paolo8@yahoo.com", false, new Guid("67a0fefa-c903-4326-91fc-981d72b581a8") },
                    { new Guid("2f6d9b6e-1e14-4888-9c64-59e315eb0517"), "Crystel_Rowe63@hotmail.com", false, new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("2fec250b-fc75-4f99-881d-161e11337120"), "Ethel_Waelchi@yahoo.com", false, new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("30081379-1140-4453-adf1-17fc0960420b"), "Cale15@yahoo.com", false, new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2") },
                    { new Guid("301181da-b9df-4626-ae7b-b43d21042e9f"), "Roger_Cremin21@yahoo.com", false, new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("3023c74f-8236-4ace-aa21-6e29168811f5"), "Augustine20@yahoo.com", false, new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("30491364-42f0-4985-96f9-6d10c76fb32f"), "Caden.Rodriguez9@gmail.com", false, new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("30833b5b-d665-4c16-ab9b-d0f4c20dfe3e"), "Leone.Price@yahoo.com", false, new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("309c2589-39b0-4930-a1fa-c698286c9393"), "Sharon50@hotmail.com", false, new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("30ccaf3c-f47a-4dfe-8eea-ec8f30224bc9"), "Tyler.McClure@yahoo.com", false, new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("313014ef-a410-4610-a694-0ce329bd8f11"), "Favian_Fisher@hotmail.com", false, new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5") },
                    { new Guid("316baeef-fd30-4748-b363-5bde04cec36e"), "Lew.Emmerich19@hotmail.com", false, new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a") },
                    { new Guid("31ca3671-082e-4ed5-92d3-b45199591fee"), "Myrna.Shields87@hotmail.com", false, new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("322c9fcb-1038-4b08-895e-9964fdbdd084"), "Marianna.Muller@hotmail.com", false, new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714") },
                    { new Guid("326b4dc7-55a3-407c-830d-dcedecf69aca"), "Donnie55@yahoo.com", false, new Guid("b80d479f-1611-46e2-a055-1de659d203b8") },
                    { new Guid("32ac76b0-595d-4362-accf-66e336a1ded2"), "Wilbert_Effertz@yahoo.com", false, new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba") },
                    { new Guid("32c5279d-a69f-4738-9db3-e6e064046803"), "Ida51@gmail.com", false, new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("32fdd036-bdc4-455b-ba10-48ca0f057471"), "Althea_Kuhn65@hotmail.com", false, new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f") },
                    { new Guid("33169e4f-ecd1-4aaf-ad1c-de40645fc7f4"), "Mustafa_Pfeffer@yahoo.com", false, new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("33e8916f-710d-447d-8718-affe2bc82a08"), "Brandy_Mayer73@hotmail.com", false, new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8") },
                    { new Guid("340fe37a-e420-4b95-8e9e-f6a3b35f65a0"), "Jennyfer.Schaden@hotmail.com", false, new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("3426a91e-dbfa-44c6-8458-fd77cad6e77f"), "Kenyatta.Macejkovic10@hotmail.com", false, new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("342e01fc-dbac-4972-b310-92c8998b1525"), "Manuel_Bernier@gmail.com", false, new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("34596465-8340-4986-b7d2-dbd7c5ce8061"), "Herminia.Hartmann@hotmail.com", false, new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3") },
                    { new Guid("35adff65-853b-4737-9b7a-0e0c3c494a1d"), "Sienna.Ruecker76@hotmail.com", false, new Guid("74b3dcc9-46b9-432b-a105-af04273b540f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("35ea671d-ed40-4dcf-b859-747b88b6963e"), "Lina.Towne@yahoo.com", false, new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("360af2eb-7d43-46c0-8f74-6ed5d73e2908"), "Everett22@yahoo.com", false, new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("364a3652-c853-4fbe-b8b7-6291c58aee30"), "Tod.Gaylord35@hotmail.com", false, new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("36a80e46-1c23-4ccb-982c-16053dfe53d7"), "Kyla54@hotmail.com", false, new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("375f4c09-91aa-4f26-b41c-a1b7ed8ecb23"), "Emmy40@gmail.com", false, new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("379209d4-de63-4df9-9487-dbb3de9190fe"), "Vincenza.Hilll@yahoo.com", false, new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e") },
                    { new Guid("37963008-60de-43bb-aa94-5f66b4e86ed2"), "Bella33@hotmail.com", false, new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("3856983c-113d-47b4-afd1-300af9be2e1b"), "Godfrey69@gmail.com", false, new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("3868bf9d-708c-407f-a174-d52b08b92d07"), "Samir_Ortiz@gmail.com", false, new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("38dd3a1c-91c0-41b3-8db9-3912e1c73b78"), "Buford.Osinski@yahoo.com", false, new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("38e59e78-f52f-41e4-abbb-be9b076913ee"), "Cristobal_Rippin54@yahoo.com", false, new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("39217ad7-f145-403b-8c83-179d3ce45b4b"), "Ron63@yahoo.com", false, new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("39a2d04a-72c7-4339-a95d-c13f6c030725"), "Tate69@yahoo.com", false, new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb") },
                    { new Guid("39c541ca-a9e3-4ef7-9741-b1dc219de333"), "Elmo.Haag@yahoo.com", false, new Guid("65012c66-d07a-40f6-9789-b100201359c2") },
                    { new Guid("3a18302e-a6c4-48d4-8a5d-8addf83f026a"), "Jacky_Cruickshank@hotmail.com", false, new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("3a92eadb-7780-4746-b88d-98a9330cc36d"), "Aaliyah_Fahey@hotmail.com", false, new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("3b14a7e0-2b85-4e96-9ca6-0a0660a574ba"), "Leda47@hotmail.com", false, new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757") },
                    { new Guid("3b3596de-86f3-4e6a-b400-18d7501694d9"), "Guido2@yahoo.com", false, new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("3b479d0b-e891-458c-aa7a-e3099bf83bc6"), "Donnell.Runolfsson@gmail.com", false, new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("3b4b4f36-10c5-4cc4-9f9d-c000416ae204"), "Frankie84@gmail.com", false, new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d") },
                    { new Guid("3b78ed8a-d24e-4d73-b7ec-bfea474938c0"), "Arno.Bahringer35@yahoo.com", false, new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("3b8e4f26-3d1e-442f-a8ab-017de62af065"), "Cecelia.Heller@hotmail.com", false, new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("3b905ee6-fba3-4600-aa98-eb9a66cc9b37"), "Reyes.OConnell@hotmail.com", false, new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("3bfbb03e-9ce9-4f7a-b18f-5d6fbcf4a9ec"), "Carmela53@gmail.com", false, new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("3c4c7bc3-8a2c-443f-8191-037dd81e8f21"), "Ransom_Pfannerstill44@yahoo.com", false, new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("3d7aab17-05fb-4026-a8bc-5ae2081621e1"), "Ellis22@hotmail.com", false, new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2") },
                    { new Guid("3d901c1c-3e23-49c9-a5be-01e7e1bf9b0b"), "Wilton27@gmail.com", false, new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("3d9b53ba-00bd-4371-837a-060f1663bc7d"), "Jeromy18@yahoo.com", false, new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("3e67bfe0-ccd6-44ce-a9de-47d3aebfccfa"), "Oda48@yahoo.com", false, new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e") },
                    { new Guid("3ec5afae-cd5f-4acd-991c-0bd3123c3cef"), "Ken_Hand16@gmail.com", false, new Guid("ad5b9802-88b7-4c47-b138-778817c4050a") },
                    { new Guid("3ec66bc6-70fc-4f47-99db-f2a886f09879"), "Isadore.Swaniawski@hotmail.com", false, new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("3ee248fb-c7db-43ce-a889-965983eddbf6"), "Jude24@hotmail.com", false, new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9") },
                    { new Guid("3fcef7cf-bab0-4a80-ab81-341329331d5f"), "Corbin.Lebsack39@gmail.com", false, new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("3feb3953-1ac0-46e1-8a6a-331c3cf79341"), "Emely.Casper@gmail.com", false, new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e") },
                    { new Guid("405e1b09-c20e-452e-ba48-aafc15bfad2b"), "Napoleon_Pollich@gmail.com", false, new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("40639aa1-210c-45df-aa86-58915233619f"), "Dominic.Jacobson@hotmail.com", false, new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985") },
                    { new Guid("4069c9a5-739f-4110-bb6b-4feda53b0ef4"), "Hunter17@gmail.com", false, new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("40a1d844-a342-4ed5-90c7-fc5d7c00586c"), "Mariana.Ortiz42@gmail.com", false, new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("40e70008-89df-46ef-a428-d89889cb7bf9"), "Judd49@gmail.com", false, new Guid("21856d76-0810-4123-9f39-8fd468591282") },
                    { new Guid("410215d7-0ff0-4972-b034-a1bd4e3672b0"), "Emory.Heller@gmail.com", false, new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("411ba570-665d-4676-a00b-0b81c5f3ea94"), "Maryjane_Bechtelar@gmail.com", false, new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("418636b4-753e-4501-8ecd-c4338d1dbb40"), "Carley62@hotmail.com", false, new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("41901a4b-a889-4431-873f-eb7a022696cf"), "Clare16@gmail.com", false, new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("41b76d87-a9c7-488b-8271-550387380636"), "Johnathan42@gmail.com", false, new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911") },
                    { new Guid("41cc8cd2-30f8-4a78-aca3-64a620e940c5"), "Coby_Pfeffer@yahoo.com", false, new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("4215ffe8-5812-4b37-9537-0a31780eecde"), "Madalyn72@hotmail.com", false, new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c") },
                    { new Guid("421e9d1e-37a1-4a1b-9069-f2acd5264345"), "Kobe46@yahoo.com", false, new Guid("61fe1433-1b16-4004-8246-4e030b366c6d") },
                    { new Guid("4220f9db-0015-4558-a4c4-eb264ebd4107"), "Mozelle.Zulauf25@gmail.com", false, new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("42a88c07-873e-45ce-94b7-e358d2bbe723"), "Kathryn53@gmail.com", false, new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("42cd47ef-7070-4f98-98d9-47880695fcd7"), "Joannie_Stehr@yahoo.com", false, new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8") },
                    { new Guid("42e97eb0-6ddb-4f36-9912-4974deb92abf"), "Kathryn.Zulauf48@hotmail.com", false, new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("43965182-cd46-4eab-94d7-44f714d02564"), "Beverly_Johnson69@hotmail.com", false, new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079") },
                    { new Guid("4428675c-63fa-41d2-9a3a-e0f6987cdc10"), "Terrence16@hotmail.com", false, new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("444e7b5e-9561-4d5f-8811-74328e7762dc"), "Mohamed36@hotmail.com", false, new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("445efbfe-5731-4b3a-93e2-2ea6c5fa6928"), "Jerod.Macejkovic15@hotmail.com", false, new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("44fdda58-1a26-4797-980d-dfefc1cca249"), "Vivienne51@yahoo.com", false, new Guid("082d68f3-3ec8-4587-9852-34cd715f794e") },
                    { new Guid("45ee8e71-0282-4a8b-a0f4-2ba4bcc31ec3"), "Martine52@gmail.com", false, new Guid("51274356-5ef0-4e46-a687-716d200f49e1") },
                    { new Guid("46298a0e-55fa-43d3-902d-811a0e76c6bc"), "Kenna.Bayer@hotmail.com", false, new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("4639c53f-a556-4de6-86b9-1287b978faf8"), "Cory20@yahoo.com", false, new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("465f9fe0-8e67-4418-a2b2-9b41f51894d2"), "Hipolito.Wyman88@gmail.com", false, new Guid("913aac82-79cd-4930-833a-d54464607133") },
                    { new Guid("4676720a-7c8b-4a66-96ae-8fb8fd0ccfb6"), "Parker.Upton23@hotmail.com", false, new Guid("b80d479f-1611-46e2-a055-1de659d203b8") },
                    { new Guid("46c90a5b-9b80-4ccc-a33d-f736482d2b74"), "Kayden.Kuhic6@gmail.com", false, new Guid("18971e31-ee25-41fd-bafa-129547aefc10") },
                    { new Guid("46f1a193-eddf-403a-b728-c1a9d8623dec"), "Dino.Moen21@hotmail.com", false, new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e") },
                    { new Guid("47bc55fa-33c5-4182-a196-a7d42c3ee57c"), "Jocelyn63@yahoo.com", false, new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("47fce0ec-dd0c-4cad-95f6-90024e0720b0"), "Roberta67@hotmail.com", false, new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("4824e903-0d5d-4f58-a1af-52c0763b4dc3"), "Macy_Tremblay55@hotmail.com", false, new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("48d6ab1e-18ea-42a1-9cb1-7686719e2e1f"), "Kacey_Fahey76@gmail.com", false, new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("4902de27-d42a-4c04-b329-4a35381579a7"), "Loren_White82@yahoo.com", false, new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9") },
                    { new Guid("4a233c3d-f240-445d-b0e9-c52da5a75d42"), "Conner.Paucek@yahoo.com", false, new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("4a4694e2-c0c0-4013-8f51-edef4408fbcd"), "Houston.Thompson47@hotmail.com", false, new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("4a6f2de7-cb49-452d-8e1c-b140b18a6c3c"), "Horacio_Thompson@yahoo.com", false, new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("4a7c31f4-bfff-4c7e-a48c-f30980daa6f8"), "Joel_Reichert25@gmail.com", false, new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("4ab0f143-c398-430a-9a91-de43830fd9d3"), "Lawrence75@gmail.com", false, new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("4b75c0d2-83a5-4ded-b44e-e007d5eafa0d"), "Cordie_OConnell27@hotmail.com", false, new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("4bbebbc6-f56f-46a3-9252-a7c78f7db267"), "Amalia35@yahoo.com", false, new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("4c0669da-fae9-4cec-9d3d-c991869ab706"), "Mario.Greenfelder@gmail.com", false, new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("4c843ac6-c9ba-4398-ba2e-ea9286ea0719"), "Darrick_Christiansen55@yahoo.com", false, new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("4cd1598c-a0f2-4d86-b93a-3a8ef6cb579c"), "Lourdes50@hotmail.com", false, new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("4cf0446f-cba1-41d7-99a8-9ec718c2e695"), "Melany.Schmidt47@yahoo.com", false, new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("4d9ac448-9972-4421-a06d-0d7636c95d45"), "Marion_Abshire@gmail.com", false, new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("4debbd3d-4e20-4802-8ddd-0cbbbd8480e2"), "Hillary.Zemlak@gmail.com", false, new Guid("24292576-82c4-4a01-961e-e050d58bf4a8") },
                    { new Guid("4dff409e-6f9a-49f2-a504-3e84000405e6"), "Madison.Quigley@gmail.com", false, new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("4e2656ab-ebc8-43eb-b715-9b154c7ea328"), "Roberto7@hotmail.com", false, new Guid("6e90baa7-8b75-4108-acaa-210af704a12f") },
                    { new Guid("4ea358af-c112-4c02-be83-8a8899ca1f17"), "Lilla.Koch73@gmail.com", false, new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("4ebd0af7-46bc-4447-987a-1e581ff98662"), "Albina31@hotmail.com", false, new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197") },
                    { new Guid("4eda0287-2370-4179-a17d-b651f05f2347"), "Rosamond_Torphy@gmail.com", false, new Guid("9a57b367-770f-4f86-8d83-869ef37800a0") },
                    { new Guid("4f5a245d-9539-49bf-91e7-178b665cac06"), "Jaylon10@yahoo.com", false, new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63") },
                    { new Guid("4f887428-08fb-482f-9202-34f34e9d519b"), "Katrina78@hotmail.com", false, new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("4f932891-fa7c-42b0-89fe-2586dcc7fa10"), "Blaze_Torp@yahoo.com", false, new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("50055765-54c9-47b4-953e-22233ad7ac8d"), "Creola24@yahoo.com", false, new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("50400e34-f050-4d4a-9c02-a6def747c720"), "Alisa_Rodriguez@yahoo.com", false, new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("5049483a-fcb4-4b3c-89c9-6ae1eab9ad23"), "Rico77@yahoo.com", false, new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a") },
                    { new Guid("50532443-ea5f-46b4-9f1a-e138759bc815"), "Mollie76@hotmail.com", false, new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("50966f4e-415f-4873-a3dd-ee107d06b468"), "Terrell.Metz@gmail.com", false, new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("50cca5a7-706a-4186-ac5a-037f461f807c"), "Mariah_Glover@yahoo.com", false, new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd") },
                    { new Guid("515a9e21-613d-4ba4-9acf-6a238f4618c8"), "Meagan.Lakin3@hotmail.com", false, new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("519e0a40-ad2b-49a7-b8ae-7e81e66afb6d"), "Lane_Powlowski63@hotmail.com", false, new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a") },
                    { new Guid("51a4bf2c-e00d-49ec-9a5f-4a46b7da8f1d"), "Winona.Howe@yahoo.com", false, new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75") },
                    { new Guid("51f836d8-2072-446d-8d35-da79b3aeb395"), "Virgil22@gmail.com", false, new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("5210f897-f768-495e-ad0f-930884e964f1"), "Concepcion.Gottlieb13@yahoo.com", false, new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("53130052-4254-42b0-af5e-efc2ca50a54f"), "Luisa.Adams91@hotmail.com", false, new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("531d6c58-8878-4cbb-9f4b-54176b7d7452"), "Jamison_Veum96@gmail.com", false, new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("538a5a07-78bc-4c1a-bb8b-c5229939ac24"), "Shawna.Simonis95@hotmail.com", false, new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("53fa597a-841f-4c62-ad2e-c7b73af0a14d"), "Kasandra36@hotmail.com", false, new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("54513084-3d47-43f6-8c28-0714893b9b45"), "Marcos.McCullough18@hotmail.com", false, new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374") },
                    { new Guid("5467f046-7073-40c7-9328-5c438f99e71c"), "Krista95@hotmail.com", false, new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("54806883-829d-4620-b439-54312086fdfa"), "Jacinto40@gmail.com", false, new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("54c3622c-a90f-4cd5-897b-eb8e56a5f338"), "Austin_Kunze31@yahoo.com", false, new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("54e5a967-70c3-44ba-b08e-a5a996e761cc"), "Samson77@yahoo.com", false, new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("559c5878-7cb5-4de5-aa0a-6e19154029b8"), "Elna.Mann24@gmail.com", false, new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("55bacb34-f4bd-4f6b-991d-97514e228526"), "Roma25@yahoo.com", false, new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("55dc1a45-9c96-4458-a9f8-38bce2a7270c"), "Zena.Daniel86@gmail.com", false, new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("5608d430-b2dc-4ea1-adfd-4b98134a6640"), "Erick_Keeling@yahoo.com", false, new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("562dc458-af5b-40af-9812-1e5cad59d573"), "Edna.Stark@hotmail.com", false, new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("571459b4-1a36-47bd-93aa-78024bdc8772"), "Demarco_Mills@hotmail.com", false, new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("575b7a9d-1425-482b-b943-b3e99b1b8582"), "Katlynn_Shanahan10@hotmail.com", false, new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e") },
                    { new Guid("575e47b4-7f7e-4320-96aa-fb9cd13390c7"), "Izabella70@hotmail.com", false, new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("57733b78-6100-4c31-8556-1c637c16dab3"), "Stacy70@yahoo.com", false, new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("57c4ca87-a8d4-4e36-9d48-3b65e9e4f1fe"), "Colt0@yahoo.com", false, new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("580f4fce-b72f-4a6a-a695-841e1b7df148"), "Mallory.DuBuque@gmail.com", false, new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("59cc885c-07a3-4ba6-b51d-61c6bf7514c9"), "Jacquelyn.Kohler16@hotmail.com", false, new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("5a0cbf90-335a-4365-8ee2-5d2576970445"), "Reyna_Heathcote15@yahoo.com", false, new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("5a40a157-fe1c-4cb6-8a6f-6fc0399a8e85"), "Eliza_Dickinson@gmail.com", false, new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead") },
                    { new Guid("5aa3370b-d469-4c79-bbd3-af71a77fb2eb"), "Jerad.Reynolds@yahoo.com", false, new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("5aa37af6-bef8-479e-8178-0ca5364da38a"), "Randi_Halvorson@yahoo.com", false, new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("5ab8385b-1e6b-48af-b0d5-2dca25d75e1c"), "Oswaldo82@yahoo.com", false, new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ad2e29f-8270-4074-86c3-58d842c55d62"), "Lonnie79@yahoo.com", false, new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f") },
                    { new Guid("5ad3e917-e254-46c0-8af5-577d6856a9ec"), "Bernadine90@yahoo.com", false, new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760") },
                    { new Guid("5b65bb44-3d7d-4bb4-8644-9799bfbc4aae"), "Johnpaul_Abernathy26@hotmail.com", false, new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("5b6ce3ec-5d1a-4d3f-be98-443102578983"), "Declan.Casper@yahoo.com", false, new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093") },
                    { new Guid("5bd52f24-1bf5-45a5-8c84-c69afe3efd04"), "Dixie.Larson13@hotmail.com", false, new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("5c28c930-0348-4f8d-807d-4e9109f260ca"), "Coty_Kub@yahoo.com", false, new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("5cb4a895-0b3c-42db-8853-da1eb1275753"), "Maximus_Kutch@hotmail.com", false, new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("5cd963c6-1bc2-4eed-8246-150cd3ac14ab"), "Jackie.Price30@gmail.com", false, new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("5cefd818-c2cf-4dec-a285-ffa9c1359f28"), "Leann_Bernier55@yahoo.com", false, new Guid("f50dbc58-9b0d-479e-8402-e939027091e8") },
                    { new Guid("5d16a5c4-f010-4aef-af38-bd40917f4454"), "Tatum.Corwin@gmail.com", false, new Guid("99e79b31-2994-4fd2-956f-0294e124da96") },
                    { new Guid("5d7025f0-9d66-4ebe-9295-7ba98a7ea789"), "Else_Wehner@hotmail.com", false, new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c") },
                    { new Guid("5db63eda-c553-4fae-8ee2-431bdd28b75c"), "Hilbert_Murazik@yahoo.com", false, new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("5dd25b62-a291-440f-a553-a5daf171e412"), "Assunta_Swaniawski79@hotmail.com", false, new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab") },
                    { new Guid("5ddfce8f-21d1-4fab-bae4-59605cfc3a28"), "Kelsie93@gmail.com", false, new Guid("913aac82-79cd-4930-833a-d54464607133") },
                    { new Guid("5dfae76a-d915-420b-9753-4ae5ff90af22"), "Forest13@hotmail.com", false, new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("5e34e122-498e-4f50-a098-e41f971053c7"), "Salma.Hagenes39@yahoo.com", false, new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("5ebed7ac-e257-4d4f-a59c-6952fc373a87"), "Isadore.Bosco94@yahoo.com", false, new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("5ec217e0-9374-415b-a7c1-b661d150f6eb"), "Frank_Jenkins@hotmail.com", false, new Guid("8959e331-7a84-433f-9378-9aad487e24b6") },
                    { new Guid("5eff3ec9-0795-460c-8d82-c958bb883839"), "Freda.Effertz@yahoo.com", false, new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8") },
                    { new Guid("5f067201-3076-4437-93e1-b68a00e99995"), "Hunter_Swaniawski@yahoo.com", false, new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552") },
                    { new Guid("5f1dd3e7-2b12-4931-8128-7c85e119b427"), "Pete61@hotmail.com", false, new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb") },
                    { new Guid("5f4cae62-7845-47d6-92bf-1b894764823a"), "Bernard99@yahoo.com", false, new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63") },
                    { new Guid("5fb09eea-1a7d-48ba-acd6-93750574e4a8"), "Gwendolyn50@hotmail.com", false, new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("60203a1e-d4e0-4b86-884d-f918686f5199"), "Pauline.Conroy@yahoo.com", false, new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("603403e6-9de1-4d88-ba66-1e686475f551"), "Verla.Kuhic@gmail.com", false, new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("6052b162-cde6-4efd-a1ac-f23fa81e589d"), "Bette_Hansen90@hotmail.com", false, new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("60f62b96-165c-40af-a942-36b5954920da"), "Alexandrine_Rosenbaum@gmail.com", false, new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553") },
                    { new Guid("61059ea0-557a-4762-8aea-8e12b81be9b2"), "Braulio_Kuvalis74@hotmail.com", false, new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("610fa90d-2ad6-42dd-93d7-89fba09796d9"), "Erica.Kassulke88@gmail.com", false, new Guid("51274356-5ef0-4e46-a687-716d200f49e1") },
                    { new Guid("611069c4-d92b-4ed4-9eee-ca6045ab4de5"), "Vilma.Stanton@hotmail.com", false, new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("61115db4-9cae-4643-85de-73f598b1ed6f"), "Mose_Streich20@hotmail.com", false, new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("611b36c2-6330-4da6-8bc7-266326e07a7a"), "Leopoldo23@hotmail.com", false, new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("614314a5-5bb2-4b57-99da-df156ac68534"), "Soledad.OHara@yahoo.com", false, new Guid("db79945a-0e64-4c97-801f-a38a1e357d12") },
                    { new Guid("616aa51b-e0c3-4627-a280-d3e4f414e6b5"), "Giles_Botsford89@gmail.com", false, new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("6194ad2f-e1ad-4b66-8ae7-f99fbdba51fc"), "Margarita_Ernser58@yahoo.com", false, new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("61da2dcf-1d5d-4b2a-a6d9-1729f3ba903c"), "Myrtle.Dietrich98@yahoo.com", false, new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("61f71280-0cc1-49a9-9105-447d04f96263"), "Angie_Davis72@yahoo.com", false, new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("6200bd3a-9851-4517-9886-ebf3ad3b685f"), "Jay_Schmitt30@yahoo.com", false, new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("6280b30e-9167-48dd-b089-129056db4aa4"), "Melyna.Upton@yahoo.com", false, new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("629e94f4-9668-4673-9167-fcf02f193acf"), "Frederik_Schumm@gmail.com", false, new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("62b35e67-e998-4542-a8df-de9759b4a305"), "Casey90@yahoo.com", false, new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("62e5be1f-4904-4b03-a6c9-08a26cd60ebe"), "Boyd53@gmail.com", false, new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("633a3b33-4512-49c3-b72c-12157893f4a6"), "Khalid.Volkman@gmail.com", false, new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("64823d7c-3677-4fdb-b679-54024c9a906f"), "Junior53@yahoo.com", false, new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("64cbcd3b-ab18-42e1-89b5-227502982c69"), "Carleton_Hammes11@hotmail.com", false, new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("64d6eb31-eb70-4f37-9f4a-90b12ec14d93"), "Axel99@yahoo.com", false, new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1") },
                    { new Guid("651cf962-f759-4412-8e58-dd8e5492889f"), "Madelynn95@yahoo.com", false, new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("657b1a42-653e-4232-b7f5-b885aeb4f520"), "Meagan.DuBuque@hotmail.com", false, new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("658f3640-8aa8-4837-8564-fd645a9414ce"), "Lorenza51@hotmail.com", false, new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("65a96556-f22b-4f76-b6ff-a420708e2e21"), "Rosario92@gmail.com", false, new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("65ddb10a-c161-4dca-b7a1-dc6142ed4e59"), "Jacynthe_Marvin86@yahoo.com", false, new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700") },
                    { new Guid("663927ea-792f-4b14-8e51-115ec6a51050"), "Alexane_Paucek57@gmail.com", false, new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("6639cde2-1b08-4aab-a5fb-41a281656ec0"), "Jacques.Wolff@yahoo.com", false, new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("664c1217-7584-4c2c-ae04-6452686d5bfd"), "Moriah_Blick86@yahoo.com", false, new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("6699b350-ce09-44ea-b085-ab84cd54767e"), "Cathy_Kilback@yahoo.com", false, new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079") },
                    { new Guid("66d07f69-34f2-4601-9956-64a7441ac016"), "Era98@hotmail.com", false, new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b") },
                    { new Guid("66fcc08a-4f85-4561-a2fa-b83203b48f12"), "Darryl_Weimann@gmail.com", false, new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("675ad063-185d-440d-b3c0-a5b622d84609"), "Eldora50@gmail.com", false, new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("677d7489-1927-4457-b4d8-a43e284332bb"), "Brandy_Kuhic@yahoo.com", false, new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("68327b46-dba0-4418-b5c8-1bfa01c5fce4"), "Annetta64@yahoo.com", false, new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("684310f6-9f28-45e0-8b8d-de7e8843ea92"), "Shany.Wiza55@hotmail.com", false, new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("687702d5-4a55-4cf3-874c-1f98a7a5d5c0"), "Jeremy_Rempel@hotmail.com", false, new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("688812e9-4b4e-40e5-96ae-4109085bf3e0"), "Bethany.Rau@gmail.com", false, new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007") },
                    { new Guid("68919b63-3827-4cb4-b2fe-2efd19199b21"), "Ebba_Nader@yahoo.com", false, new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("68b7e73a-c666-44fd-bca0-13574ac44874"), "Hailie_Boyle@yahoo.com", false, new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d") },
                    { new Guid("68db2096-5f53-44d0-8ad5-1e06741a7c4f"), "Meghan97@hotmail.com", false, new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("690ca64f-f795-451d-b1fa-5cd8adcb9581"), "Rhett_Herman@hotmail.com", false, new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75") },
                    { new Guid("69213d37-5c2d-4834-b8e4-96ee0d3bfbc9"), "Lillie5@hotmail.com", false, new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553") },
                    { new Guid("693b9d5a-5136-472c-a2d3-447e57a32038"), "Helga.McLaughlin@gmail.com", false, new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("69c62b97-8b81-4d95-bb31-a0b247b9ec01"), "Amos.Moen@gmail.com", false, new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("6a3f5a6f-59ce-4cc2-9e32-1acf98cd3755"), "Magdalena.Cruickshank@gmail.com", false, new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("6b590e70-64ec-4bcb-8780-5d886e66d630"), "Malika13@hotmail.com", false, new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("6b774821-bcd0-462f-86ce-459b1e834c72"), "Daphne_Cremin@hotmail.com", false, new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("6bb49848-43af-4e63-8ddb-73a4c89b17b9"), "Dolores_Daugherty86@gmail.com", false, new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("6be58760-0d34-4f22-b692-3700435f8eb9"), "Uriel26@hotmail.com", false, new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("6bf9f61f-6537-46fc-8360-85528429a8ec"), "Cleve.King@hotmail.com", false, new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e") },
                    { new Guid("6c3c2a79-f497-49f6-9e04-25f77a13d520"), "Vince.Champlin64@yahoo.com", false, new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("6d678020-9c42-4d4e-bf5c-1abb69864b1c"), "August_Shanahan@yahoo.com", false, new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("6db7e382-74bf-4e9e-a7d7-fa61fe54601f"), "Buford91@gmail.com", false, new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("6dc58ff3-2b89-4c74-b534-b9e93b8a7d77"), "Robyn_Powlowski@yahoo.com", false, new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("6df4987f-1dc7-48c4-81d6-e5421c1d4992"), "Jamir.Morissette@hotmail.com", false, new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328") },
                    { new Guid("7002471b-e6b6-47e2-8e79-66d3ed11c4bd"), "Lolita.Cassin97@yahoo.com", false, new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("7125ea8e-6424-4916-9fa6-ddf8d6c4d7a7"), "Keshawn_Terry@hotmail.com", false, new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("7126857f-b1f2-441a-8ceb-82e58fd897cd"), "Linnie.Cartwright73@hotmail.com", false, new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("7143fa6b-16de-4186-a820-3f716c6984cc"), "Doug94@yahoo.com", false, new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8") },
                    { new Guid("7191383b-e4cc-4044-b6ba-461c156d9637"), "Katlyn.Homenick58@gmail.com", false, new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("71d7f185-a80d-45c1-9747-9b2f1cb43f6f"), "Leda.Kunze66@hotmail.com", false, new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("721a077a-054f-4f99-b257-948b7f1503df"), "Germaine_Kessler@gmail.com", false, new Guid("18971e31-ee25-41fd-bafa-129547aefc10") },
                    { new Guid("7221681b-da0c-4b07-9ed4-ef01f039ed06"), "Godfrey28@hotmail.com", false, new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("725ebca4-a36b-42d5-9b4c-118281b5ef46"), "Nina.Ullrich@hotmail.com", false, new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("72a85c31-b4d7-41a2-bde6-d9d94fc42786"), "Sonny95@yahoo.com", false, new Guid("b6691519-38b6-436a-a19c-602dda7868aa") },
                    { new Guid("7365342f-490f-4696-a0b7-6517593cf3f5"), "Laurence7@yahoo.com", false, new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("737b3574-b8c5-41a0-8ad4-d2a3b802896a"), "Eusebio_Goodwin@hotmail.com", false, new Guid("67a0fefa-c903-4326-91fc-981d72b581a8") },
                    { new Guid("73bb2fd1-4ac9-4380-8590-5177e4a4585b"), "Kenton.Christiansen1@yahoo.com", false, new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("750bcca4-e02c-4d07-a4cb-a051109e93a5"), "Ida_Collins68@gmail.com", false, new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("7520203a-fcbd-4d2a-ac53-b8a0055e4d02"), "Harry_Gulgowski69@hotmail.com", false, new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("753080f1-8f31-4861-ac98-6fb8b61a200f"), "Isidro27@hotmail.com", false, new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("75490f86-c37d-4f72-bf4b-385daab6d58c"), "Norwood84@gmail.com", false, new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("75643462-14f4-43c1-a316-bcd5b34235c2"), "Dorothy_Koch82@hotmail.com", false, new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("7568defc-65ea-4057-8a0f-5d221ec8342a"), "Nicolette88@hotmail.com", false, new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("75a75524-f663-499b-b2ea-64f5f1dbadfd"), "Isaias.Stroman38@gmail.com", false, new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c") },
                    { new Guid("75af294e-00ac-47a9-a248-43f8d54aa2ef"), "Ezekiel19@gmail.com", false, new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("7633a556-e34d-4acb-9021-ea84ab4b2ae5"), "Khalil_Reynolds@gmail.com", false, new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("763b84a1-ebcc-4347-a751-3b5394af9114"), "Jessie_Hegmann32@gmail.com", false, new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("76b701a4-3acb-420f-8beb-de1ae74c5dbc"), "Araceli_Hessel23@yahoo.com", false, new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6") },
                    { new Guid("773f757b-727c-4f71-8a88-e742dd272041"), "Flo36@gmail.com", false, new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("775e1b6d-7ca7-4e55-8c5b-29a226f1deaf"), "Julio42@hotmail.com", false, new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("79a22331-ecaa-48ec-8bf8-233311e98992"), "Grover_Osinski49@gmail.com", false, new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("79ab6e86-42fb-4234-9528-97804adfb95a"), "Emery11@hotmail.com", false, new Guid("a0c72d91-dc13-4995-848c-613286a462f4") },
                    { new Guid("79ede80e-2b47-4586-99f2-bd3f66814ce3"), "Glenda23@yahoo.com", false, new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d") },
                    { new Guid("7b0c453e-3c9f-4a6c-9e6d-defdcc21ad36"), "Okey.Ledner@yahoo.com", false, new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("7c44c4c9-e5a9-483a-893b-22ac3da9b0de"), "Verlie_Franecki65@yahoo.com", false, new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("7c7b6dd6-9cf4-4dae-b0b1-3bb4af256e12"), "Hank_Parisian@gmail.com", false, new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("7c8cb8e7-79df-4626-a8ed-c1abfa494c0e"), "Chadrick.Frami31@gmail.com", false, new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("7c8cff24-172f-42f8-bcb4-ed5e4176911d"), "Katelin_Schneider48@hotmail.com", false, new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7") },
                    { new Guid("7cb2eb31-e6b4-4a42-b8e5-1ad704c84dea"), "Malcolm.Bernhard@hotmail.com", false, new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("7cc6bbe9-9d82-4bf3-bc10-aa8cd54871f2"), "Reese_Dare@hotmail.com", false, new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("7cd58ce7-f85b-460e-b4d2-92a242b817b2"), "Jacques_Koelpin67@yahoo.com", false, new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a") },
                    { new Guid("7d6dd72c-bb43-4eb4-b0cb-491039645dad"), "Vinnie65@hotmail.com", false, new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("7d7fe425-1077-4388-8778-9489d41f56e2"), "Darren_Witting21@hotmail.com", false, new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("7d9e260e-9b88-442f-8d9f-b1353162f90d"), "Terrence.Willms77@hotmail.com", false, new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("7e1c517b-900c-4414-a87f-513677d78bd7"), "Icie_Wolf92@hotmail.com", false, new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("7e74b02e-45cd-4544-8b87-24ceb36f4415"), "Therese81@gmail.com", false, new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40") },
                    { new Guid("7ea88e2a-7df2-470a-b92c-c4d9693a460c"), "Joel_Crist17@yahoo.com", false, new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("7ee67873-867e-4e96-a438-73e37ef56152"), "Brycen.Herzog@hotmail.com", false, new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("7f0ac336-29e9-46ee-b7be-fd59c981946a"), "Nelda.Lockman@hotmail.com", false, new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("808bbe76-66ff-4cb2-98fd-473a5234ede1"), "Edmund69@gmail.com", false, new Guid("082d68f3-3ec8-4587-9852-34cd715f794e") },
                    { new Guid("80b6ecfd-32ae-430a-8ef3-ab3d74daf478"), "Janis.Schaefer86@gmail.com", false, new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("80b7c973-dcc6-496f-94bc-e0eb3c7ce051"), "Henriette_Kertzmann36@yahoo.com", false, new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d") },
                    { new Guid("8121c4bb-6cca-4c46-b73a-7c915164fd4b"), "Bulah.Cole49@gmail.com", false, new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("81482191-2893-41c7-b71f-d8c31ea4d167"), "Hermina.Stroman21@hotmail.com", false, new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("8173a4f3-2f3f-4806-8cc9-db1e0c512434"), "Flavie84@yahoo.com", false, new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("82da9e92-074b-4651-8acf-017c206a3a36"), "Therese_Macejkovic56@gmail.com", false, new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("8310aa0b-0b32-4318-ab18-2c9e27bb8eb1"), "Jayme68@hotmail.com", false, new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("83f287aa-ab98-4893-8abe-977ad4f5103a"), "Daphney_Von3@yahoo.com", false, new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058") },
                    { new Guid("84110d81-5f17-4996-aae0-4ed95d6c8c0a"), "Reymundo_Schamberger@hotmail.com", false, new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("847e456a-f357-419b-ab80-48035bcf897d"), "Rickey.Hamill53@hotmail.com", false, new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("84bcb0dc-718f-4458-9914-abef29af1e72"), "Devin.Murazik@gmail.com", false, new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce") },
                    { new Guid("84d41c47-4ec7-40b3-8e47-ba74259d7778"), "Aliya47@hotmail.com", false, new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714") },
                    { new Guid("86117fe5-8e14-4310-a799-eda8797f86ca"), "Camryn62@hotmail.com", false, new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("8638c1a6-a8ad-4194-834a-208663c6e929"), "Adella64@gmail.com", false, new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("865c767f-2398-4af5-9041-67a276bb1fcc"), "Bulah_Mayer@yahoo.com", false, new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684") },
                    { new Guid("86ba3c3c-6ee7-476d-adcf-afe2590300e4"), "Nichole.Towne66@hotmail.com", false, new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("86c1d473-1e0b-4fd1-b4ba-649b86ee809c"), "Arnulfo.Ortiz@hotmail.com", false, new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce") },
                    { new Guid("86d0b465-50ff-48cc-97b8-ea2fcc87b15e"), "Sarai_Harvey8@yahoo.com", false, new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f") },
                    { new Guid("876b5e6e-7f55-4167-a068-a2e5c0646798"), "Quincy20@gmail.com", false, new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("8770bc13-94c0-47ef-a52b-b7b704a222be"), "Joannie_Beier61@yahoo.com", false, new Guid("0f432380-a89c-4564-a477-a1ed20795e01") },
                    { new Guid("87905f59-8325-4257-a034-5c7d403e5308"), "Branson_Boyle@yahoo.com", false, new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1") },
                    { new Guid("87933bad-7773-477e-8568-5f345667f7d7"), "Thea_Raynor@hotmail.com", false, new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("87d453b9-3b6e-4e75-af34-db3c1475e5b6"), "Jaime34@yahoo.com", false, new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("880c62fd-d256-4cff-b4f1-d53ba7501eda"), "Retha.Hoeger42@hotmail.com", false, new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("881a810d-2706-4e72-81d6-beb36402c2bb"), "Jayda.Metz62@hotmail.com", false, new Guid("2a7af252-1892-408c-8a62-8885f15e7f65") },
                    { new Guid("8823a54b-5b0e-41ae-97b5-7335e0aafe47"), "Walton88@gmail.com", false, new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("88420c83-7669-4d19-9d2d-964bf18f6bcf"), "Jennie.OKon73@hotmail.com", false, new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("88511402-87ea-4a98-a9c9-6f41c95e9251"), "Sean83@gmail.com", false, new Guid("fe114181-f2e6-4432-86af-f7d827b491ef") },
                    { new Guid("887d97ee-13ad-40a5-b8f6-6c31c75cb19a"), "Janis59@hotmail.com", false, new Guid("de984da9-04b5-4417-b831-fdf348dbff4e") },
                    { new Guid("88b2a21f-ced4-4447-86cc-4b6d8b967492"), "Destany.Gerlach31@gmail.com", false, new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("8a55cb11-6445-4ab8-9932-cca7d5a63f72"), "Hilario.Hessel92@hotmail.com", false, new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("8a9e463d-ce5e-4282-82b7-43cbe2e01fdc"), "Darian20@gmail.com", false, new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("8c054656-3655-4041-9869-6e1c9c835a21"), "Sherwood48@gmail.com", false, new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("8c2085ca-04c7-4e04-82a5-7a8f487d38ca"), "Jannie.Rogahn@yahoo.com", false, new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35") },
                    { new Guid("8c45f03e-d101-43b2-b666-38f2bfa16b63"), "Natalie_Mueller75@hotmail.com", false, new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("8ca611e9-f985-4fd5-8666-fc304cb25165"), "Jeanie_Jacobi@yahoo.com", false, new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("8d040e35-5925-4fea-9aef-ca04adc2fae3"), "Tressie0@gmail.com", false, new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("8d0e701e-57d3-4494-a793-30b7256f4770"), "Francis95@gmail.com", false, new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("8d929ba5-ea8e-4d7d-9779-ec818ff44354"), "Rene.Braun@hotmail.com", false, new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("8dd4e65c-1d2b-40ca-a4ff-e7b3b03e8c01"), "Verona.Ernser96@hotmail.com", false, new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("8e6c5cdf-e982-49db-b24f-0fb8d417e3fd"), "Gerard.Corkery35@gmail.com", false, new Guid("f4943944-5289-42df-aed1-a6281dd934db") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("8e98e9d8-212c-4b15-8613-a6221e4d3298"), "Kyler.Botsford64@gmail.com", false, new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("8eb1f69c-f937-4cc6-902f-02f9d852b082"), "Mary_Schimmel13@gmail.com", false, new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("8f6fb6a8-24b6-49d1-b3b1-3609f94613d2"), "Dexter17@gmail.com", false, new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7") },
                    { new Guid("900d592b-260a-4040-866a-702954283adf"), "Alexis_Bergstrom@gmail.com", false, new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("90684247-cffa-4016-8aea-cb35e9130f5c"), "Lexi_Nicolas@yahoo.com", false, new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("90acc7a1-4700-4b66-b94c-e84364070cd1"), "Tyrique.Conn93@yahoo.com", false, new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("90acdb7d-8f94-4f16-a512-3a20cf86afce"), "Keanu_Lueilwitz@gmail.com", false, new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803") },
                    { new Guid("90f3e3bd-a20d-4e89-a5bc-f8dcac859cfc"), "Blair_Schiller46@hotmail.com", false, new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba") },
                    { new Guid("91000795-e454-4ba0-94f2-223f9c989179"), "Theresa.Pfannerstill13@hotmail.com", false, new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("9131c80f-4eec-44bc-b1c0-1640e6a44d9e"), "Torey.Denesik91@gmail.com", false, new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("91de8b26-42b0-425b-b01a-92b7e7f68bef"), "Alia.Koss73@gmail.com", false, new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("9284f2fc-47ec-4d81-b8f1-6178aed9ecda"), "Claude_Hackett8@gmail.com", false, new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("93266fea-cd30-4f73-9417-837ce8b6475a"), "Emmanuel.Ernser13@hotmail.com", false, new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("93992550-388d-4849-b563-7ccda403d20b"), "Jaquelin34@yahoo.com", false, new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("9439f2a4-039d-4022-9a25-ea6a9f9aab83"), "Luis.Miller@gmail.com", false, new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("946d9e38-3506-46de-b38d-6713b190cc67"), "Marcelo88@hotmail.com", false, new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2") },
                    { new Guid("9471fc1f-8367-4618-9e68-8fe7f3d6fe2e"), "Damien23@yahoo.com", false, new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("9476310e-0d3c-41a7-b173-4fa573024477"), "Earnestine_Weber@hotmail.com", false, new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("94d5229d-a5ae-4d96-bbbb-f8354e6ae01a"), "Coleman_Tillman17@hotmail.com", false, new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803") },
                    { new Guid("95227ab2-f6d1-4f1a-b6cb-969d0b72932f"), "Oliver18@gmail.com", false, new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("9522af94-c789-4a24-8031-cea8d32954f6"), "Alvina91@gmail.com", false, new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6") },
                    { new Guid("9531a509-f560-44bc-becf-984321eea88d"), "Patsy_Renner@yahoo.com", false, new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd") },
                    { new Guid("95870c72-4d08-4dce-a7ab-83b60d34febf"), "Sandra_McKenzie23@gmail.com", false, new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("9664f84e-9304-4352-9bf9-828026a963cf"), "Layne_Boyle@hotmail.com", false, new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("96dd6f50-c3c1-4ec5-bf94-f22786f033f6"), "Antonio.Senger84@gmail.com", false, new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("97834ad5-c7f5-4c14-80fe-f92ac19313f2"), "Melissa_Labadie@yahoo.com", false, new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("97a07948-cd4a-4de4-9657-23868a16b9c9"), "Zachariah47@yahoo.com", false, new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("97a21cd5-0238-4f2f-a7f1-6b671b4076af"), "Zella.Gislason@hotmail.com", false, new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("97a29505-8705-40fa-b5f5-0f8e112b8f8b"), "Mara_Dietrich@yahoo.com", false, new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("97b821f1-a5ee-4741-a2c6-fa22501551e0"), "Melany.Morar@hotmail.com", false, new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("98f47c21-8a66-4787-8814-ab00e215b363"), "Easton.Blick5@yahoo.com", false, new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("995298e9-8c7c-4fc0-927f-cfd153f893d7"), "Watson.Emmerich62@hotmail.com", false, new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("99572021-6b48-4461-ba1c-5497925a0d53"), "Alexa30@yahoo.com", false, new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("99af67ea-bdef-44e3-b935-080b174ac4c7"), "Leonardo.Langworth@gmail.com", false, new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("99b08f03-a64f-4eeb-b4cc-c19bf00e226b"), "Cody8@hotmail.com", false, new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("99b221c3-6170-45c9-9ca4-f4d97499171e"), "Verna_Kulas@yahoo.com", false, new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("99cddb67-453f-47ae-939b-d221146602ee"), "Hoyt22@yahoo.com", false, new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("99cedfb9-8943-496c-95b4-aac3e2edeca4"), "Tate_Langosh@gmail.com", false, new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("9a0a2973-a3c6-4a71-b5ab-1c34baa84030"), "Lexie74@yahoo.com", false, new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("9a3bc557-058a-473e-84d4-38a6d64102a4"), "Katheryn93@yahoo.com", false, new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37") },
                    { new Guid("9a6a484c-1075-48a3-8e1a-fc9cdcb5e586"), "Dereck78@hotmail.com", false, new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("9b131c97-a2dd-47fb-b378-1e891a269be7"), "Bruce_Auer44@yahoo.com", false, new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b2c01c8-32c1-43cd-9a81-bd4a16d0bb19"), "Yesenia_Ward@gmail.com", false, new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("9b4a9974-eda4-4d55-94ce-248d94451d42"), "Estevan19@hotmail.com", false, new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("9b6cc781-1eab-4b11-86c3-a216496bc057"), "Elenor27@yahoo.com", false, new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("9ba2e5a8-b37c-4088-bed9-754880104611"), "Rhianna.Schmeler@yahoo.com", false, new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7") },
                    { new Guid("9c230d2b-150c-460c-b34f-429794c18d69"), "Daniela.Fisher53@gmail.com", false, new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("9c62c38d-433e-437a-9d88-d2d182a44085"), "Newton66@yahoo.com", false, new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("9c78dab3-02d9-4fac-8502-1ed4ee59e9e5"), "Isai_Feil16@hotmail.com", false, new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e") },
                    { new Guid("9cc6c2d8-0480-47d7-860d-2d24aff59128"), "Elisabeth.Steuber96@gmail.com", false, new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("9ddc582d-17e7-4f45-86a5-502004be1d09"), "Alisa89@yahoo.com", false, new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("9de0ba30-2439-404e-8d8c-b26915f572db"), "Margarette.Nolan@yahoo.com", false, new Guid("2a7af252-1892-408c-8a62-8885f15e7f65") },
                    { new Guid("9e71cbbe-0878-41b9-9a52-d91d766e7b7b"), "Aisha_Lakin79@yahoo.com", false, new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("9e862bbf-c9a6-469e-a519-7e06498e23fa"), "Rickie_Robel20@hotmail.com", false, new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("9fb876b5-7b43-47d0-9cc7-8e3392daaf00"), "Monte_Wisoky9@gmail.com", false, new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb") },
                    { new Guid("a04c144d-c1fa-431b-9a28-a4f7f135252a"), "Mortimer_Hartmann@hotmail.com", false, new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("a06bfdfa-693d-44fc-9377-97915f45e789"), "Jamil86@hotmail.com", false, new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("a156fbf0-fed2-4fc5-88b1-a6836c04623a"), "Mollie_Smitham20@yahoo.com", false, new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("a17a3a28-fd16-42e2-8728-1b096e65814c"), "Emmet66@hotmail.com", false, new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("a2aecc04-5522-44eb-b0ee-4ded970dd658"), "Baron_Deckow28@gmail.com", false, new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("a2efaa07-5486-48a7-87cd-98605fd8acea"), "Charity_Ferry@gmail.com", false, new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("a3763955-1366-421f-a26a-99309fb530a0"), "Landen_Dickinson@gmail.com", false, new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245") },
                    { new Guid("a3acc1de-2221-4c94-80b5-d45c82078140"), "Macy_Kerluke57@gmail.com", false, new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332") },
                    { new Guid("a4974067-c31d-46ed-9f0a-dafb74036cee"), "Arnaldo32@gmail.com", false, new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("a4a88e7a-cf5f-4de7-a2f3-02009962ca5e"), "Berta_Fisher@hotmail.com", false, new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("a526d7de-cc02-487e-a0b6-c72a2335eba6"), "Efren.Kovacek36@hotmail.com", false, new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("a54df39e-e618-48c7-995a-d286dee88ffa"), "Elyse4@yahoo.com", false, new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("a5a3dc0e-4a01-4359-af6f-31f423001c94"), "Hilton38@gmail.com", false, new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("a5b4a9e3-83b6-496f-b58f-cd6c060fee88"), "Tatyana_Schmeler43@hotmail.com", false, new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab") },
                    { new Guid("a5e8c5e5-a341-4305-96be-4425a9a7d3b4"), "Roslyn_Davis40@hotmail.com", false, new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("a636f1b1-530e-4b3d-9cce-0549be3532bf"), "Adolfo_Kshlerin@hotmail.com", false, new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("a6518f07-0ab7-4133-a13d-de5f445c2d89"), "Chanel.Douglas68@yahoo.com", false, new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("a68f75a9-9ed9-4923-80d8-e2996f957783"), "Janet_Conn@hotmail.com", false, new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("a6997a42-bb93-42e8-99c2-ef47b3877fc3"), "Ernestine_Mayer@hotmail.com", false, new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197") },
                    { new Guid("a6bbb209-3a72-4640-876f-ad94fc58ccaa"), "Jamil_Bogan@yahoo.com", false, new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("a6c734a4-0fb2-40d0-836c-c3268e0fb116"), "Eugenia.Prohaska@hotmail.com", false, new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("a6f0d1af-8edc-4a8f-9079-0f9b9dceefa6"), "Frieda.Weber@gmail.com", false, new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("a6f4ba2e-268b-4d4e-8f26-d0de56c04335"), "Enoch.Buckridge@yahoo.com", false, new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("a72cc208-14f4-4773-aa4b-194dc671980a"), "Chelsie.Bartoletti@yahoo.com", false, new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("a786aada-d943-475c-83f2-3c5ed2db46ed"), "Francis_Bins5@gmail.com", false, new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("a7ab3492-9578-4bdc-b59d-64cb3c9bcf96"), "Camille55@hotmail.com", false, new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803") },
                    { new Guid("a828a085-e7a9-412a-9a89-557e798641ff"), "Nestor19@yahoo.com", false, new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328") },
                    { new Guid("a82d4313-4931-4bce-8c66-94dd3e9f77dd"), "Eugenia10@gmail.com", false, new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("a8436792-8996-4941-9de3-da741bce7b7a"), "Elinor26@hotmail.com", false, new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("a855c011-914a-495d-8f89-77e04ee9ff67"), "Clifton_Mante@gmail.com", false, new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("a862cd33-d5cd-437d-b591-14f531b11ad5"), "Ephraim_Treutel67@yahoo.com", false, new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("a8798716-194b-454c-8463-2bc4bbb46fa5"), "Moriah.Larson70@hotmail.com", false, new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b") },
                    { new Guid("a8852100-fed2-4d3a-9092-0108b0e53d64"), "Clara.Denesik@yahoo.com", false, new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("a907f169-4bb9-4367-ad57-26426e874921"), "Lexie_Schumm@gmail.com", false, new Guid("99e79b31-2994-4fd2-956f-0294e124da96") },
                    { new Guid("a9ea5111-f8cf-4172-a853-7d5b2f81a44a"), "Danika_Stamm@yahoo.com", false, new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("aa475c96-0a04-4e39-84f6-8972c6a67887"), "Kiarra.Legros@hotmail.com", false, new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760") },
                    { new Guid("aa856420-cff5-42e8-9d28-76c36f24e41f"), "Christiana_Jast95@yahoo.com", false, new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("aad8d6ac-e79e-4d05-adf4-fbe30b0145b1"), "Aliya86@hotmail.com", false, new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("ab2a8a47-42ac-48ef-a899-bb251b510e85"), "Theresia_Crooks@gmail.com", false, new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("ab575904-61be-43a6-8d8e-3e5ea84c951c"), "Franco25@yahoo.com", false, new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("ab78e6bd-3c79-440a-8678-6c594245dbd7"), "Kirsten_Denesik@hotmail.com", false, new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("ab99e929-5816-4eb9-a228-1095b93a3b3f"), "Simeon_Medhurst40@yahoo.com", false, new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("abb7d4fe-d1fa-4137-8542-650f5b0a3288"), "Gunner28@hotmail.com", false, new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("abdaf534-4756-4f69-ab35-4320e9114bed"), "Winston.Roberts@gmail.com", false, new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("ac19fa5a-3ffa-4ead-bfa1-3b3e7e93e69e"), "Wilford.Grady@gmail.com", false, new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc") },
                    { new Guid("ac3323d9-ce7d-4107-82c9-6748da59b420"), "Kianna.Kilback32@hotmail.com", false, new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("ac358cf5-3862-4925-8b06-78f2cb704d12"), "Nyasia.Will@hotmail.com", false, new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("ac7e272a-3a14-41e0-851b-53ae6a22bd4c"), "Thurman_Prohaska11@hotmail.com", false, new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("ac80dfd9-e46a-428a-830a-3a2c5b9836ce"), "Hermina4@hotmail.com", false, new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("ad2495e9-c44c-4ea8-bd8d-17b89da9ad68"), "Helen_Boyle@hotmail.com", false, new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("ad440bea-b363-4ea1-aeb0-125db4155815"), "Cleve.Legros17@hotmail.com", false, new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("aed4a8e8-2b9d-4973-8a58-9ca203af02cd"), "Norberto.Hilpert@hotmail.com", false, new Guid("de984da9-04b5-4417-b831-fdf348dbff4e") },
                    { new Guid("af1119d6-f1c6-4491-8330-2b6b7fc6eeb9"), "Isabell.Dare@hotmail.com", false, new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("af18052b-1e7c-4e87-9758-699e6d19ebc0"), "Jerrell.Trantow@hotmail.com", false, new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("af575719-7ed7-4835-afe1-9e69d1eeb692"), "Alberto.McLaughlin16@yahoo.com", false, new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("af63de9b-f584-46d2-a79e-bc80f4521e4a"), "Danny9@yahoo.com", false, new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("b07be602-d7fc-4293-9675-8cf60e1ab341"), "Arthur_Kuhn52@yahoo.com", false, new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("b0effd70-0f4c-49ed-ba78-c6292569664d"), "Mackenzie62@hotmail.com", false, new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("b16541d5-bf59-44b2-8916-da44c1b15cbd"), "Cleve72@yahoo.com", false, new Guid("e698e260-89e1-4c83-b493-1379542f5647") },
                    { new Guid("b19d1b83-1102-450e-a6c5-c572b86ef003"), "Kaitlyn.Nikolaus5@hotmail.com", false, new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("b1ec9dcc-9a3a-4473-afe6-7bce3b9244fe"), "Blanca_King@hotmail.com", false, new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("b1ff4cb7-98fb-45bd-8e25-e263b0eb3a99"), "Sheridan.Herman56@gmail.com", false, new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("b289f25c-633f-4295-9766-e242b252867b"), "Shanel_Hodkiewicz18@gmail.com", false, new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("b2cc2c84-6d50-4e6c-91d3-2dcb58ba41f9"), "Delpha.Greenholt12@gmail.com", false, new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("b305b2dd-c551-493f-b02a-0a2b14a05d7b"), "Jeanne_Cole16@hotmail.com", false, new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("b320f1af-b1f4-461b-af8f-05bf3c3beef8"), "Zelma_Deckow87@gmail.com", false, new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("b3d3df51-0ecc-4609-8eb6-9ff32773ff27"), "Emma44@yahoo.com", false, new Guid("313a1b63-2c0c-411e-a611-28a27b318502") },
                    { new Guid("b411ae20-f895-4325-8513-4305a10c62ab"), "Lottie61@hotmail.com", false, new Guid("f50dbc58-9b0d-479e-8402-e939027091e8") },
                    { new Guid("b4388c57-88fa-4589-b0e2-020be5ded572"), "Naomi36@gmail.com", false, new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("b4577b13-5847-4de0-9236-cd58e325e464"), "Claudine_Hansen@gmail.com", false, new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("b47a1ec8-b83d-4efd-a3f6-691e31ef6b20"), "Mason.Pacocha99@hotmail.com", false, new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("b48a658c-bbf3-4c92-8d56-501e1e0accd2"), "Carolyn_Langosh71@hotmail.com", false, new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("b4a84837-cd00-46ab-ade1-5f33c231e6a4"), "Halie_Gorczany@hotmail.com", false, new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("b4ade9a1-669d-49c2-83e5-07a0fb00bc51"), "Miles_Hane65@yahoo.com", false, new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("b4b7dac2-0e7b-4441-9d2e-3204511a1dd7"), "Ewell_Schowalter@hotmail.com", false, new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0") },
                    { new Guid("b4cdf2d8-eb45-46e4-ab04-630ded2399d7"), "Tyshawn.Keeling14@hotmail.com", false, new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("b60309bf-99ca-4031-94ce-8e72ded3e33f"), "Braxton.Harris67@yahoo.com", false, new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("b608e84b-02fc-4373-9dc5-e23e228ac1bf"), "Antone_Jones21@yahoo.com", false, new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8") },
                    { new Guid("b6685bdd-e70d-4cf1-8ece-168578b922e2"), "Isobel78@yahoo.com", false, new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("b6dddc8a-a31c-4e90-9cef-5edc356ae0f2"), "Hollis66@yahoo.com", false, new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c") },
                    { new Guid("b6e49223-acb9-439a-8aaf-9a5af0e27ac2"), "Milo19@gmail.com", false, new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("b6f2ac8a-2bf7-4135-8cde-b3217df970a6"), "Theodore14@gmail.com", false, new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("b70b3f7d-9137-4edf-8e31-ab6c2e090ec5"), "Leonardo_Leuschke21@hotmail.com", false, new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("b73894f8-db4b-48e1-b102-4bec199cbba9"), "Chyna.Miller@hotmail.com", false, new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("b7848e71-9c9a-4071-afea-c5f299f97b6c"), "Watson_Ratke45@gmail.com", false, new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("b7880d73-ac0d-4ce4-8329-093bd894391d"), "Furman.Predovic@yahoo.com", false, new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("b7a98f2e-cd8f-450a-9ff4-ad1e102f19be"), "Morton92@gmail.com", false, new Guid("61fe1433-1b16-4004-8246-4e030b366c6d") },
                    { new Guid("b7b52678-ede9-4d6f-bc64-e06785c1b2f5"), "Mariah.Greenfelder38@yahoo.com", false, new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("b7dc8f0b-1d61-43fd-8974-43fdeb4d5956"), "Albertha.Kilback53@hotmail.com", false, new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("b7f6351d-54e2-40f6-aa3e-0b4eacd121b1"), "Liza_OConnell@yahoo.com", false, new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("b7f9a642-2491-4a57-88cb-e469b327040a"), "Ken_Frami65@yahoo.com", false, new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("b8e1e3a9-942a-4b2e-ba21-e84306e81cf3"), "Monique_Casper80@yahoo.com", false, new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("b8e3dbf1-a000-49c5-be63-a9b1cabe609c"), "Abigayle.Bergstrom84@hotmail.com", false, new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3") },
                    { new Guid("b8f820db-2f06-4544-bbc8-92332ce39a07"), "Sally35@hotmail.com", false, new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094") },
                    { new Guid("b91c7044-4f0b-43ab-b182-581056209a72"), "Rey82@hotmail.com", false, new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("b9c99021-5a1e-44ec-b1b7-2b3f95129502"), "Lexie_OKeefe@hotmail.com", false, new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("ba44202d-4523-4b30-8f9d-69045652a43d"), "Percival51@hotmail.com", false, new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f") },
                    { new Guid("bb3edf2c-807f-4617-b843-0f4fd4e76394"), "Carmine.Kiehn21@hotmail.com", false, new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007") },
                    { new Guid("bbb740ac-f0a1-4012-b056-658dbdfe2b03"), "Garnet.Gibson@gmail.com", false, new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("bc262785-6f3c-4f8e-820f-a2f533d52858"), "Dandre.Mitchell@yahoo.com", false, new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("bc48e792-55e6-4e07-ac78-c41a4f7a9cd4"), "Dagmar_Harris@hotmail.com", false, new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387") },
                    { new Guid("bcd6fae9-1fc1-4b74-9148-d163b195d2ac"), "Toni_Jacobson@gmail.com", false, new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9") },
                    { new Guid("bd38effa-5510-4b80-8474-777db5603c5d"), "Kenya32@hotmail.com", false, new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1") },
                    { new Guid("bd4bf5be-1a22-4af5-a78c-8f8c9bef701e"), "Helena.Douglas@yahoo.com", false, new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("bdba3004-6ffb-40a6-a395-ed98ff1d3987"), "Alex81@hotmail.com", false, new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("bdf55a9e-4995-4bd5-b1d1-982509bff46d"), "Sidney46@gmail.com", false, new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("be73697a-b80a-4cdd-943d-891f7006e14d"), "Queenie_Smitham22@gmail.com", false, new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7") },
                    { new Guid("beb9c4ea-0c53-4ad4-a3fd-c741442321a1"), "Laila_Hammes@yahoo.com", false, new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("bec710b8-81e0-4f97-818c-b1153df2c539"), "Martine.Watsica21@hotmail.com", false, new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb") },
                    { new Guid("bee9458c-ff4a-4c84-b168-e0c695d8ee02"), "Sophia_Jakubowski72@yahoo.com", false, new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d") },
                    { new Guid("bfe7a62e-3ca1-45c6-879e-cbcdb88f91c3"), "Destin.Cummerata@gmail.com", false, new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("bff6ce80-c224-4cb6-bfaa-3a7d3d8b1909"), "Ricardo_Treutel@hotmail.com", false, new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("c016d31b-931d-42cb-9f5a-d02446710d62"), "Rita_Hessel@gmail.com", false, new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("c0340eb6-2378-47bf-a106-cd158cee4b3e"), "Ethelyn.Block@hotmail.com", false, new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17") },
                    { new Guid("c07601e5-734d-4414-9385-bc9e3385b54a"), "Carson.Dickens@hotmail.com", false, new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("c0d8becb-79b5-47fc-af2a-e6ca3dcb91cc"), "Roberto_Lueilwitz62@gmail.com", false, new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("c0ec374f-d362-471c-b3a3-e8eca667de31"), "Susanna_Bednar98@yahoo.com", false, new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d") },
                    { new Guid("c12e5952-edac-4439-a8b8-e3cce4b85adc"), "Hilario_Swaniawski@yahoo.com", false, new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("c1fa23c3-f942-462a-b5bc-2f4cdd8c5c74"), "Lilliana.Rosenbaum41@hotmail.com", false, new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("c264ae5b-21ee-4cf0-978f-771c296d1481"), "Carlos_Fritsch@yahoo.com", false, new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192") },
                    { new Guid("c28a1e82-3e81-47a6-8fa5-1c02c8b19ded"), "Mertie_Carter@gmail.com", false, new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("c37d97e2-3973-4b22-ae76-cc2e39e78f6a"), "Lexi17@hotmail.com", false, new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("c39b5241-e459-46bb-9088-80f8aeb5efbd"), "Chad.Franecki@yahoo.com", false, new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7") },
                    { new Guid("c466eed8-4073-43c7-9f48-5d141baf9287"), "Nakia.Kris12@yahoo.com", false, new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("c502e46d-1802-4887-a98e-7fc7b5d269c1"), "Omari_Herman50@gmail.com", false, new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("c556c4ee-0414-4b1b-bf04-a58c1bfca751"), "Ludwig_Treutel@hotmail.com", false, new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("c5a0124f-405a-4520-98fd-b72bf067b7e4"), "Audie19@gmail.com", false, new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("c5cc03ef-d773-4b72-a60e-91ed5bbdc0bd"), "Ferne_Grant@gmail.com", false, new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("c5ea9855-52ae-4b3b-b26b-ef8a284b709c"), "Stone86@gmail.com", false, new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("c62b37eb-782e-4153-80cb-cd82a8f58906"), "Lolita46@hotmail.com", false, new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("c64e4fc6-a092-43fa-9148-e48abd66ac21"), "Bailee_Cronin49@gmail.com", false, new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("c729a416-6720-4b3b-bdb0-4231acda54c2"), "Vernon.Roberts37@gmail.com", false, new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("c758eba7-9513-4539-9f70-16d35500ffa3"), "Lia72@gmail.com", false, new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("c842744f-6a12-4d54-9a05-2316882162ad"), "Bret_Herman35@hotmail.com", false, new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7") },
                    { new Guid("c892562f-2028-4e0e-bff7-cdac925cfd74"), "Wyatt_Kub@hotmail.com", false, new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("c8b14b08-d009-4949-9ccf-1490f63ea8f1"), "Brendan54@yahoo.com", false, new Guid("41296760-deca-4b2d-a760-5538da32ccb4") },
                    { new Guid("c8bc7804-8b7b-4911-a3ac-eaca65674df8"), "Lula35@gmail.com", false, new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("c8c16e3d-3ff7-4b1f-86e3-3dcfee0fd1f4"), "Tiana_Daniel@hotmail.com", false, new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63") },
                    { new Guid("c944f2f0-3f92-4b48-bcf3-c3d52c686d2b"), "Ari_McClure30@hotmail.com", false, new Guid("6e90baa7-8b75-4108-acaa-210af704a12f") },
                    { new Guid("c94cc76c-d116-4b6c-8766-fcc60c1b856e"), "Maurine39@yahoo.com", false, new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("c99ad10f-b8fc-4cf5-b57f-c15452d1025f"), "Clemens_Crist26@yahoo.com", false, new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("ca5055b3-c63d-47fa-8878-97fc6a2799b0"), "Sallie30@gmail.com", false, new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("ca63a125-71c1-4579-89be-9c80bcb84398"), "Kelsie20@yahoo.com", false, new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("ca6c67ea-89da-49bf-abfc-13b539a5d5dc"), "Hal_Kling15@hotmail.com", false, new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("ca8082f2-813f-448c-87a3-aa9e65620372"), "Lenna6@yahoo.com", false, new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("cac54e16-b96e-4845-a127-74d38daa943a"), "Kameron22@hotmail.com", false, new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("cad59540-9d37-4bbc-a902-12b433d21e57"), "Wilson_Wiegand5@gmail.com", false, new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192") },
                    { new Guid("cb589944-7bd0-4fbc-840d-fd9ec4fdf35e"), "Fermin.Wuckert36@yahoo.com", false, new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("cb6a4804-87a2-431d-a955-3b07c2c4e35e"), "Elsa_Corkery@gmail.com", false, new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("cb914a85-b7bc-4e33-8f38-4a9c95d9a74f"), "Giuseppe46@yahoo.com", false, new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e") },
                    { new Guid("cba543c1-fd0b-4067-b396-d521dc1b551f"), "Joy.Hickle@hotmail.com", false, new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("cbafef12-7656-4f79-adb5-5964a7d13212"), "Federico_Stamm@yahoo.com", false, new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("cbc0321d-b26c-4aaa-99a7-f5f68ce9e9da"), "Oran98@gmail.com", false, new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("cbdd0e8a-a8ee-46f8-b1cd-d9963c0de3a4"), "Miguel21@gmail.com", false, new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("cc4a83c9-343a-4d87-8815-bca0aa272f21"), "Jan10@hotmail.com", false, new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("cc993fe8-417a-466d-a553-eab028bdad63"), "Furman36@yahoo.com", false, new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a") },
                    { new Guid("cda353d4-3999-4937-9d4b-00ce11da1632"), "Nicola2@yahoo.com", false, new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("ce862cd9-123b-40c7-8de0-0e1642069eb6"), "Larue.Ankunding77@yahoo.com", false, new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("cebe9fb3-b91e-40ed-82b2-6bee59fb4a7d"), "Antoinette.Carter@hotmail.com", false, new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a") },
                    { new Guid("cede498e-f12e-4cab-92ee-0c5dfca813ef"), "Vesta1@yahoo.com", false, new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb") },
                    { new Guid("cf7d7fe8-9a1e-4804-b06a-0ec50dc4e61d"), "Rene_Greenfelder@hotmail.com", false, new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("cfdab41a-a40c-48da-a2d6-7696b0c07376"), "Isabel95@gmail.com", false, new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("d0285182-622b-4850-a29f-4b134c06c18f"), "Vivianne29@gmail.com", false, new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("d0292fca-0301-4ada-874a-5bebcd1a1e9c"), "Earl92@gmail.com", false, new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("d062765c-cb73-42b8-9d38-185b24bb74a0"), "Leonardo_Herzog@yahoo.com", false, new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("d06c404b-fb85-414a-85e1-66b621a6b2d1"), "Alden.Lehner7@yahoo.com", false, new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63") },
                    { new Guid("d06cf3f6-e8c9-4bbb-99c1-3b01d4f531b2"), "Clifton_Considine96@gmail.com", false, new Guid("afa896ab-be1f-4401-923e-90219b5466bb") },
                    { new Guid("d09645f0-deaf-4f11-b5fe-3ecee4bb7904"), "Noble.Weber@yahoo.com", false, new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("d0fca850-b19f-4c5b-af37-894898e3cb32"), "Garrison.Murazik80@hotmail.com", false, new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("d100ac82-87b3-4472-8501-4625e7b6d1b2"), "Bridget_Stoltenberg@hotmail.com", false, new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("d14fdf2b-4571-4eee-9828-8129d2bbb261"), "Jayne_Rempel58@hotmail.com", false, new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb") },
                    { new Guid("d169adb5-1324-4e9f-af01-12550c9c9091"), "Ayla.Howe@gmail.com", false, new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("d17375ba-b116-42b4-89ab-a5f4c90596ea"), "Kyra18@hotmail.com", false, new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2") },
                    { new Guid("d1a55eb3-4baf-46c5-a720-db7ba6d2ca51"), "Kennith10@hotmail.com", false, new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("d1b1258a-e740-49c1-aed8-6a69acdb55f6"), "Zechariah_Veum35@gmail.com", false, new Guid("41296760-deca-4b2d-a760-5538da32ccb4") },
                    { new Guid("d23c2ca8-dd68-455a-ab5a-4150a5e658b8"), "Sam23@hotmail.com", false, new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("d2650517-11f6-4930-b321-be8f37699e4c"), "Valentina24@gmail.com", false, new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("d26cf9ac-d1b2-4aca-8856-6e1fcd98df36"), "Dianna36@hotmail.com", false, new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("d2b30d73-85a8-4d43-8874-c1f0ad44ee7b"), "Carole.OConnell@hotmail.com", false, new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("d2c6b542-8bba-447f-9609-46977c749dec"), "Jace7@gmail.com", false, new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("d2ca8f4a-30d4-4ac7-ab21-79e5e701fc2b"), "Margarette.Wilderman46@gmail.com", false, new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf") },
                    { new Guid("d3ad4c68-bcd6-4a2c-bf64-e44d27648dbc"), "Rahul_Stehr12@gmail.com", false, new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("d3b6bf40-88ec-41c7-bb93-c3e881c0d938"), "Maiya_Schultz30@hotmail.com", false, new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("d40e04b9-8d4e-4bd5-8564-dc79dd99d7fd"), "Dorothea84@hotmail.com", false, new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("d45516f1-3ec0-46c6-aedc-a28f94e226b5"), "Abbey99@gmail.com", false, new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("d45bab3a-77f0-48c0-992c-1253bbf5e0b8"), "Augustus58@yahoo.com", false, new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("d47a5b20-0a19-420b-9519-3aa0c929a929"), "Stuart91@gmail.com", false, new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7") },
                    { new Guid("d4a174d7-9d82-4a20-b0fe-aade9d29a9e9"), "Lizzie82@yahoo.com", false, new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("d4cd48a1-3836-4c08-a415-18b0ff988154"), "Vivianne74@gmail.com", false, new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("d4edd75b-0d5d-43a4-a9ff-56a013014946"), "Dennis22@hotmail.com", false, new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("d5230154-bf49-4c71-b6fb-3ac92609144f"), "Mathias43@yahoo.com", false, new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("d58a5f23-34cb-428d-a74c-e6e886cbe37a"), "Jayda.Boyle@hotmail.com", false, new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("d58faaad-6563-44d6-a657-2fa19c172576"), "Jadyn0@hotmail.com", false, new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("d5aa07aa-6768-444d-87c0-8a8c456ed579"), "Kaci_West89@yahoo.com", false, new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("d5b8ebfb-bea3-4cd2-a18d-f66e9d4552db"), "Carter_Leannon@hotmail.com", false, new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a") },
                    { new Guid("d5f6d321-9234-4b13-ac52-cd4f2038f5dc"), "Burley_Quigley@gmail.com", false, new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("d626e791-f983-49e7-bcb5-71862d17caa2"), "Vernice_Stiedemann65@hotmail.com", false, new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("d6674faa-4664-462d-b080-3c3a275ed037"), "Vivien66@hotmail.com", false, new Guid("65012c66-d07a-40f6-9789-b100201359c2") },
                    { new Guid("d6823e09-4d14-4e0a-b462-9c138464c540"), "Chanelle.Robel7@yahoo.com", false, new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615") },
                    { new Guid("d6ad952e-5bba-4dd7-99d6-55ff798f38ec"), "Jameson87@hotmail.com", false, new Guid("de7d9783-5299-4552-b426-e13c1b4a4995") },
                    { new Guid("d6f3379a-9506-4b2c-a298-459ee2fdd29e"), "Dortha.Shields41@hotmail.com", false, new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("d706e708-4277-4521-84c2-27d04f0904e4"), "Pietro_Kunze66@gmail.com", false, new Guid("68d876f2-c855-4a3a-b244-f66443d9d833") },
                    { new Guid("d7c3b4ac-96a6-445b-8bf0-a8f55982593d"), "America_Schneider97@hotmail.com", false, new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b") },
                    { new Guid("d85dfab7-43aa-42e0-bafc-f1b0cbbef273"), "Quinten_Tillman@gmail.com", false, new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("d8916436-2ab3-4cfb-8d81-b7319ce2b804"), "Darrion.Jerde@yahoo.com", false, new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("d8f04afa-f986-4e57-ae2e-8f2bdefc7ab0"), "Myrtice.Stoltenberg@yahoo.com", false, new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("d910aa66-fc1d-427d-b4a5-0d953af8fe4c"), "Tito.Jacobson@yahoo.com", false, new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("da7ddc3a-2b1e-44c7-b352-a653bc70f74f"), "Neva.Kihn@hotmail.com", false, new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("da9b2826-a9a1-4b74-9ecf-dbffc58b3bc5"), "Norval_Parker68@hotmail.com", false, new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("dabbb72c-0a86-4a43-9643-9b3fda5da32f"), "Katlynn.Roob@gmail.com", false, new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("dabc221d-a7f0-4254-8695-6b05182579a1"), "Bobby_Kutch60@hotmail.com", false, new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("dbb1852d-a115-458b-ba8d-1e71507c7de6"), "Cassie.Crona@gmail.com", false, new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("dc9436ed-f1be-4aee-bbd6-2b0e75aa7cba"), "Ramona48@gmail.com", false, new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093") },
                    { new Guid("dceb3d1d-61ce-4ffd-ba8f-2ef2e0debda3"), "Erling_Moen10@hotmail.com", false, new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("dd09e68d-bb39-4764-a13d-90784f2fedc6"), "Ona_Lockman30@hotmail.com", false, new Guid("0f432380-a89c-4564-a477-a1ed20795e01") },
                    { new Guid("dd22fd54-bea2-4dc8-b01d-d4ecb635c253"), "Hellen88@gmail.com", false, new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf") },
                    { new Guid("dd5902b8-3336-47e6-a98f-d039d6117579"), "Otis.Jakubowski75@hotmail.com", false, new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("ddddaba0-fc67-49e3-a30a-da2717efd78f"), "Brain_McLaughlin@gmail.com", false, new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("ddfdb0b7-86ef-44a1-9e07-fe9e6228ee74"), "Lukas.Dickens78@gmail.com", false, new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb") },
                    { new Guid("de9f46e5-f79a-41a0-ba41-02eaa06bbcd1"), "Lydia_Kunde15@gmail.com", false, new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("df240e7d-307d-489f-8a75-b5401ecab57a"), "Harry.Bashirian31@hotmail.com", false, new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("e0039101-b91a-4b76-9d95-874d320bab66"), "Toni.Hagenes3@gmail.com", false, new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("e0ca2fdd-3a3d-4095-a279-5a4fe046a49e"), "Lee_McGlynn63@yahoo.com", false, new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("e0d912b9-6f2a-4308-9362-dd8bebb41753"), "Josue.Pagac@hotmail.com", false, new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("e0ded983-4c3d-4a17-8b67-79185c407199"), "Darrick88@gmail.com", false, new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("e0fc466b-158b-45d5-be95-ab39f8ce6a98"), "Eleanore93@yahoo.com", false, new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("e106f1c8-c859-40b6-99b2-d442e90d5a3d"), "Toney.Nienow46@yahoo.com", false, new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803") },
                    { new Guid("e10a8183-3e3e-4a44-bd17-c1ea155e6273"), "Jorge.Nolan@yahoo.com", false, new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e") },
                    { new Guid("e150b7b4-50e1-481b-9901-11534c796ca3"), "Olen.Ledner@yahoo.com", false, new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("e25a6ce9-9557-4f46-b523-ba9700e51862"), "Katrine.Hyatt99@hotmail.com", false, new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337") },
                    { new Guid("e2d98698-71a0-4379-966c-753f202cd2fd"), "Nola_Littel46@hotmail.com", false, new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("e3606637-c1dd-425c-ba05-4274f298850f"), "Noelia.Olson82@gmail.com", false, new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("e3641748-8c51-477d-9e71-a77e0f3cb382"), "Margie_Purdy@gmail.com", false, new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("e376e799-f6ec-46eb-b625-99a879b3972f"), "Guiseppe_Nader2@yahoo.com", false, new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee") },
                    { new Guid("e3bc8494-d683-4b82-abe3-c13e2eee2810"), "Carroll_Braun@hotmail.com", false, new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("e4c76f09-11fa-4845-97e1-0279543ab74d"), "Leslie28@hotmail.com", false, new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("e4e51060-5395-40e5-ad16-55564395f9d1"), "Aleen22@gmail.com", false, new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0") },
                    { new Guid("e53a31c3-3f24-4463-9577-d41ee12e945a"), "Enola60@gmail.com", false, new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("e540830b-16e0-4a47-a00a-18ba3196bb26"), "Sonia_Langosh3@yahoo.com", false, new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("e545de11-add5-4e4d-ace1-be1f630be180"), "Breana_Marvin17@yahoo.com", false, new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e") },
                    { new Guid("e55adfaa-e326-48a8-8fc0-8c4d98640b89"), "Amanda94@gmail.com", false, new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead") },
                    { new Guid("e586693d-fe70-44f9-8ab9-8fdc4e3a1e20"), "Demetris_Mayert@hotmail.com", false, new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("e72c3d98-12ee-4fd2-b665-e51d7e600605"), "Maurice.Schowalter60@yahoo.com", false, new Guid("db79945a-0e64-4c97-801f-a38a1e357d12") },
                    { new Guid("e7622c14-9fbf-4c98-9909-a4f90fe538c2"), "Amber.Wehner@yahoo.com", false, new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("e772ea30-5234-4a18-8835-48c2c86f5066"), "Kayley_Littel94@gmail.com", false, new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37") },
                    { new Guid("e7a60bdd-5090-42c3-b546-ca954b26424a"), "Franz.Kutch@gmail.com", false, new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("e7b9da4c-4c79-4b29-b011-871408425c22"), "Flavio_Runte48@gmail.com", false, new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c") },
                    { new Guid("e81fdbec-cbd3-4270-9025-bbe85e515fc7"), "Megane_Sipes10@hotmail.com", false, new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("e82827ed-9983-4347-812a-374165ce113b"), "Ronny.Haag@gmail.com", false, new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9") },
                    { new Guid("e925f611-cdf7-4d23-8bfb-bf7e8cc35d95"), "Jean.Zboncak4@hotmail.com", false, new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("e937dec2-c1ec-42e7-8db5-db8bb631d4b3"), "Junior.Schneider75@gmail.com", false, new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("e96c2c68-bce7-400a-9f66-f552c64c6b7b"), "Jazmin.Monahan10@gmail.com", false, new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("e9f6efe3-0f21-45d1-8659-4cd1b6267c20"), "Wilfredo.Labadie94@gmail.com", false, new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("ea619d98-5fb6-47d1-b8f1-1b5b3dd236be"), "Athena.Schneider@yahoo.com", false, new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("ea8e720b-2df5-4faa-a350-7f27f8368b0d"), "Theresa.Grady@yahoo.com", false, new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099") },
                    { new Guid("eb156a52-01f1-4d64-a7c4-f8a22957c517"), "Alicia_Upton33@hotmail.com", false, new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("eb7a248a-1f61-4508-8f68-dc4fae541ed7"), "Kelly_Kilback95@gmail.com", false, new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("ec075963-db02-41d8-a9f4-913ee5695ded"), "Norma_Frami90@yahoo.com", false, new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("ec65cdda-7cc0-4be7-a051-e6f5fceb472f"), "Vivianne14@gmail.com", false, new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("ee7b1f78-94b3-4a8a-81e4-601ff8d88644"), "Marietta.Rau3@hotmail.com", false, new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("ee9e9e83-63a0-4c21-a3ed-f82f010a70ae"), "Fern_Armstrong11@hotmail.com", false, new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("eeacee33-5839-42ac-9726-0a4b8e25b29b"), "Howard.Jerde54@hotmail.com", false, new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("eeb0117f-40e5-4540-bf79-19da63c05698"), "Jovan_Adams@gmail.com", false, new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("ef0981a2-2979-4958-970d-1576060ef211"), "Bria_Crona63@yahoo.com", false, new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("ef0d38ec-29e2-4a76-add3-54e7fe5d198d"), "Joanny.Gislason@yahoo.com", false, new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("ef4f82ea-12c6-4bd7-8df9-46baffc8192f"), "Harry_Predovic89@hotmail.com", false, new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("ef645c4e-d130-448c-a8d8-723961a99128"), "Brandt.Carter@gmail.com", false, new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("ef810464-9570-43f5-88b2-366c8565b19d"), "Magdalena_Johns9@gmail.com", false, new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("efa732b7-00bd-4404-a650-0663d46c86bc"), "Giuseppe.Kshlerin@yahoo.com", false, new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("efd7ff6e-ed7f-4f29-921b-194ffe282f55"), "Providenci49@yahoo.com", false, new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("f02f2701-6f7b-4bd6-bb60-c7025ac186c4"), "Buster.Ratke@gmail.com", false, new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("f07e6bfa-6bf7-4825-a15a-f1c76f19f7d3"), "Eve.Metz@yahoo.com", false, new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("f0e5658e-d207-4f59-a7c1-a4b575463c44"), "Asia.Wunsch@yahoo.com", false, new Guid("74b3dcc9-46b9-432b-a105-af04273b540f") },
                    { new Guid("f104b706-0c74-48ed-9c6f-a623f8d33667"), "Bryon91@gmail.com", false, new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("f13b30de-4337-42d1-835b-9a2a1127e316"), "Brian33@yahoo.com", false, new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a") },
                    { new Guid("f1642cb5-16c5-4c7e-94c4-9b07b82cc035"), "Damian64@gmail.com", false, new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27") },
                    { new Guid("f19c1793-831a-4f07-bbfd-448f566469b9"), "Webster.Hoppe82@gmail.com", false, new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("f1eb580f-b912-43ca-ac43-bd61d39e1f84"), "Isai_Metz58@hotmail.com", false, new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("f21f3440-0cc4-4ef5-896f-175768930b34"), "Arielle20@yahoo.com", false, new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("f2949b19-7925-4258-80ba-0e6f47af9f40"), "Keagan_Blanda30@gmail.com", false, new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d") },
                    { new Guid("f2f57e7c-ea24-497d-b29a-f776b8649f7b"), "Justine92@yahoo.com", false, new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("f33237e0-6c07-4404-926a-de7ba5f8f692"), "Tyrique.Skiles98@hotmail.com", false, new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("f3aadad8-081e-4f22-abcb-782b5be0b298"), "April38@yahoo.com", false, new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a") },
                    { new Guid("f45fa2e5-2dee-4089-a785-dcfdb9a74ac5"), "Anika_Bogan82@gmail.com", false, new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("f46ce551-f3a2-4e98-a52d-4ffef5e590d2"), "Krystel84@gmail.com", false, new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("f46f36cf-b6d4-4f6d-982a-73fdc05d952c"), "Lance.Dicki6@hotmail.com", false, new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757") },
                    { new Guid("f4a8aac7-e84a-495f-b393-9bc27685ae20"), "Trevion16@hotmail.com", false, new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a") },
                    { new Guid("f4c2134a-929d-41c0-b890-96dfe3668128"), "Catherine14@yahoo.com", false, new Guid("e698e260-89e1-4c83-b493-1379542f5647") },
                    { new Guid("f4c88415-7a45-43e3-a7d0-673741fb0a50"), "Oswaldo_Doyle@yahoo.com", false, new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("f50886e5-2c49-4821-98be-4bc53deaa2cc"), "Ila9@gmail.com", false, new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("f508ffe6-a9c4-4411-a842-fa9e26faf542"), "Augustus_Rodriguez@hotmail.com", false, new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("f51c77fd-50f8-493b-ba91-7ff42858cd3d"), "Jane_Huel@yahoo.com", false, new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e") },
                    { new Guid("f55cc70f-345b-4fb0-9e43-bef443637cf3"), "Fermin_Marquardt61@hotmail.com", false, new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("f5996090-bd2d-49ab-a390-656f31c11e0f"), "Kattie24@gmail.com", false, new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("f5a4f396-a72c-4245-9c9d-e6a359a21fa0"), "Charity_Wiza@gmail.com", false, new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("f5b213ff-0248-40a0-939d-2c03d5723650"), "Abe.Shanahan83@yahoo.com", false, new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("f5b72210-b5ed-441e-b53e-e182410cbf68"), "Elizabeth_Cartwright@yahoo.com", false, new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("f5eabc16-965a-407f-9e2d-b26461096696"), "Monserrat_Sipes@gmail.com", false, new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("f61e62f9-e598-49be-b06d-e024f9b1f73b"), "Clara_Schimmel16@yahoo.com", false, new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("f6af3a48-e5bf-4068-9f31-c9ecadc79a55"), "Nettie.Gulgowski75@hotmail.com", false, new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700") },
                    { new Guid("f6b6315b-cc8d-4dae-a449-149d158f5967"), "Rafael85@yahoo.com", false, new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094") },
                    { new Guid("f6e0d8dc-67f0-45b6-b18c-50d8b3b67fd2"), "Oma_Anderson30@yahoo.com", false, new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058") },
                    { new Guid("f7cca901-e5c1-4209-9eb0-abae586f7028"), "Kenya_Rutherford12@yahoo.com", false, new Guid("a0c72d91-dc13-4995-848c-613286a462f4") },
                    { new Guid("f7d015bb-3aed-4a43-bed8-a274e907cc27"), "Webster.Crist@hotmail.com", false, new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("f82d2a34-3f1f-407f-90a0-42b8cf966c00"), "Kay.Tromp64@gmail.com", false, new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("f82e1166-ed74-463a-89c9-05bc78c4a3f1"), "Dorothea_Schmidt@gmail.com", false, new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("f86392f1-79ce-4e1f-814c-71c5ef76e5cb"), "Madeline.Satterfield11@hotmail.com", false, new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("f92e1d22-fd54-44dc-bef7-a04bb7981c09"), "Graham.Heaney79@yahoo.com", false, new Guid("313a1b63-2c0c-411e-a611-28a27b318502") },
                    { new Guid("f9ad300b-b058-4c9f-ade3-3e598a096659"), "Filiberto_Okuneva91@hotmail.com", false, new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985") },
                    { new Guid("f9c6a154-4f39-4220-ad49-ba6fb28bfea5"), "Dawn.Cummerata31@gmail.com", false, new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911") },
                    { new Guid("fa4dd226-647e-470b-a03f-746ae0cc9c9d"), "Lupe.Murphy88@hotmail.com", false, new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("fa957cae-82af-474b-ac5d-bab375098489"), "Novella.Bosco32@gmail.com", false, new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("fa9e3da6-b5b7-4c4b-adc3-796ebe4dd06d"), "Yolanda48@yahoo.com", false, new Guid("9a57b367-770f-4f86-8d83-869ef37800a0") },
                    { new Guid("fac106c2-ab08-48b5-be3f-07d94c6f458d"), "Eugenia_Raynor@yahoo.com", false, new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("fad43beb-1de9-47b7-bbfb-91f7a1419317"), "Wendy.Lindgren89@yahoo.com", false, new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("fc4cf145-f4f3-4151-b8aa-7165d68d3bc1"), "Anne54@yahoo.com", false, new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("fc934ec8-4957-4a54-8bb9-b8f2b74e5f88"), "Emiliano_Dooley29@gmail.com", false, new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552") },
                    { new Guid("fca0f4f0-482f-4321-a091-19b5b3cd5851"), "Pink_Hansen@gmail.com", false, new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("fdc9f262-9153-4ab9-a638-260c2ec0a1ca"), "Renee.Conn81@yahoo.com", false, new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("fe826451-e80b-4cfb-81e5-b259379d8111"), "Rickey.Boehm89@yahoo.com", false, new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("fea2f97f-957a-48df-b4e6-f20b27089e74"), "Robin28@gmail.com", false, new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("feb052ed-8372-4228-97c3-c33fb4d7107f"), "Dayana_Hayes@hotmail.com", false, new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("ff0adecf-5b33-42dc-881e-0cdf3c2fd130"), "Chase.Glover@yahoo.com", false, new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") }
                });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "EmailId", "EmailAddress", "EmailConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("ff3707ec-cddb-4e84-98e4-91f82d8d78ce"), "Jeff.Erdman35@gmail.com", false, new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("ff9546a9-5eb5-4b7c-b396-fddc75c2f103"), "Cullen.Rodriguez51@yahoo.com", false, new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("00d4c667-2a1f-47b0-b4cf-caa580cc299e"), new DateTime(2023, 10, 16, 0, 35, 30, 483, DateTimeKind.Local).AddTicks(9656), new DateTime(2023, 10, 26, 0, 35, 30, 483, DateTimeKind.Local).AddTicks(9656), 25.59m, 9179658365980736m, "Super", 1, 43.513805f, "9256 Kemmer Well, West Korbin, Malta", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "03123 Schaefer Grove, Rosaliachester, Equatorial Guinea", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("09e42c27-e23b-4ed0-b515-71ae479887ed"), new DateTime(2023, 8, 10, 17, 53, 0, 814, DateTimeKind.Local).AddTicks(7182), new DateTime(2023, 8, 20, 17, 53, 0, 814, DateTimeKind.Local).AddTicks(7182), 10.76m, 3308843138810104m, true, "ParcelMachine", 1, 48.21417f, "215 Hackett Neck, Boehmstad, Comoros", new Guid("2a24280c-6e79-420d-bd19-903d44c42081"), "5687 Antonetta Mall, Groverview, South Africa", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("0f5f66c3-75ce-4e29-98d9-5a16d864f1dc"), new DateTime(2024, 3, 11, 12, 11, 44, 777, DateTimeKind.Local).AddTicks(599), new DateTime(2024, 3, 16, 12, 11, 44, 777, DateTimeKind.Local).AddTicks(599), 17.29m, 8652447307603877m, "Special", 3, 5.9376993f, "81515 Yadira Groves, Rodtown, Congo", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), "35586 Herminio Drives, Shawnton, Indonesia", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("10f6c989-2dba-44e5-8ffc-366f9457e3eb"), new DateTime(2024, 2, 26, 11, 35, 56, 239, DateTimeKind.Local).AddTicks(7989), new DateTime(2024, 3, 7, 11, 35, 56, 239, DateTimeKind.Local).AddTicks(7989), 21.71m, 4869491970846006m, true, "Special", 4, 13.088984f, "4049 Maribel Circles, Elvashire, Spain", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "467 Powlowski Corners, New Melbaview, Russian Federation", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("119fa478-befe-4ceb-9103-571c6d2a84cb"), new DateTime(2023, 12, 23, 9, 14, 42, 652, DateTimeKind.Local).AddTicks(4076), new DateTime(2023, 12, 29, 9, 14, 42, 652, DateTimeKind.Local).AddTicks(4076), 31.68m, true, 6464290421801191m, "Special", 2, 0.3316735f, "21706 Georgianna Path, Tracefort, Turks and Caicos Islands", new Guid("0f432380-a89c-4564-a477-a1ed20795e01"), "87186 Oma Neck, New Nedland, Iraq", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("16397b41-e6ac-4f13-a7f9-085919f2ef46"), new DateTime(2024, 1, 10, 15, 33, 6, 100, DateTimeKind.Local).AddTicks(4950), new DateTime(2024, 1, 15, 15, 33, 6, 100, DateTimeKind.Local).AddTicks(4950), 39.13m, 5183745940617234m, "ParcelMachine", 3, 49.388493f, "94583 Rutherford Port, Lucasmouth, Equatorial Guinea", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), "660 Rhianna Mission, Lake Clifford, Cayman Islands", new Guid("03f69888-97c1-4626-8453-7ac762327e44"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("16b9e995-f7cd-4012-a17a-58017cdd5ec9"), new DateTime(2023, 11, 10, 12, 33, 21, 911, DateTimeKind.Local).AddTicks(8271), new DateTime(2023, 11, 19, 12, 33, 21, 911, DateTimeKind.Local).AddTicks(8271), 15.53m, true, 3092919886209900m, "Special", 2, 7.348397f, "499 Jennings Landing, East Cristina, Saudi Arabia", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), "62212 Jack Estates, New Marlinmouth, Turks and Caicos Islands", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("185c4509-f06a-42cf-9999-ddef2d64a3c3"), new DateTime(2023, 9, 11, 14, 7, 36, 753, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 9, 18, 14, 7, 36, 753, DateTimeKind.Local).AddTicks(2615), 90.95m, 2368110910993639m, true, "Super", 3, 40.079628f, "34553 Kub Ford, South Shermanport, United States of America", new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553"), "198 Mayer Divide, New Kurt, Lao People's Democratic Republic", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("191bc237-2c32-402c-995e-a8612c260833"), new DateTime(2024, 1, 17, 9, 48, 13, 146, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 1, 23, 9, 48, 13, 146, DateTimeKind.Local).AddTicks(8527), 59.39m, 7237815622984226m, "ParcelMachine", 5, 14.035048f, "287 Rod Track, Colemouth, Guernsey", new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0"), "7650 Corbin Circles, West Melodyborough, Germany", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("19adf313-df9c-4c06-8500-c763efe20517"), new DateTime(2024, 2, 6, 10, 47, 41, 899, DateTimeKind.Local).AddTicks(8923), new DateTime(2024, 2, 10, 10, 47, 41, 899, DateTimeKind.Local).AddTicks(8923), 54.24m, true, 4473530076692120m, true, "ParcelMachine", 4, 49.13137f, "758 Kennedi Mall, Lake Ryanmouth, Malta", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede"), "7340 Maya Falls, New Amber, Liechtenstein", new Guid("2a7af252-1892-408c-8a62-8885f15e7f65"), "Delivered", "CardboardBox" },
                    { new Guid("1a64ebe7-54f5-470b-ac07-b87cb019054d"), new DateTime(2023, 12, 12, 0, 21, 58, 504, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 12, 21, 0, 21, 58, 504, DateTimeKind.Local).AddTicks(7765), 74.42m, true, 7711745886893051m, true, "Special", 5, 39.873226f, "447 Avis Haven, Toyfurt, Lao People's Democratic Republic", new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9"), "21337 Angus Prairie, North Charlotte, Guam", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "Sent", "CardboardBox" },
                    { new Guid("1ffd46d8-2707-498c-8f72-a3eed2b1f187"), new DateTime(2024, 2, 4, 13, 8, 14, 268, DateTimeKind.Local).AddTicks(7829), new DateTime(2024, 2, 8, 13, 8, 14, 268, DateTimeKind.Local).AddTicks(7829), 46.56m, true, 8494326785881168m, true, "ParcelMachine", 3, 26.903214f, "305 Aubrey Rest, New Cecilside, Papua New Guinea", new Guid("b80d479f-1611-46e2-a055-1de659d203b8"), "690 Herzog Center, New Elainaton, Israel", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("254e5562-cd45-4173-aa1f-fa03b92e873d"), new DateTime(2023, 9, 19, 22, 41, 7, 442, DateTimeKind.Local).AddTicks(9420), new DateTime(2023, 9, 22, 22, 41, 7, 442, DateTimeKind.Local).AddTicks(9420), 79.01m, 5148693366236400m, true, "Super", 3, 33.90281f, "2179 Grady Estate, East Hassieberg, Wallis and Futuna", new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8"), "79421 Rogers Causeway, Lake Dantefurt, Afghanistan", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), "OnTheWay", "CardboardBox" },
                    { new Guid("267d2358-ce0d-4e9d-aef2-8bab1f52d84a"), new DateTime(2023, 12, 4, 21, 26, 56, 728, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 12, 5, 21, 26, 56, 728, DateTimeKind.Local).AddTicks(6215), 93.56m, 4234559628764866m, true, "Courier", 4, 41.069904f, "51677 Buford Harbors, Kittyberg, French Southern Territories", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "0902 Morton Motorway, Lake Schuyler, Liechtenstein", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "Registered", "PlasticBag" },
                    { new Guid("28122301-86f0-45cc-93cf-1d8def97b681"), new DateTime(2023, 9, 25, 23, 22, 25, 264, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 9, 30, 23, 22, 25, 264, DateTimeKind.Local).AddTicks(6554), 69.19m, 6059405650776890m, true, "ParcelMachine", 5, 49.310455f, "525 Granville Port, South Ledafurt, Hong Kong", new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b"), "63783 Foster Skyway, Port Bruceshire, Bahamas", new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2"), "OnTheWay", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("295b142b-d964-4bc1-a454-a526e19052cc"), new DateTime(2023, 9, 7, 21, 56, 33, 37, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 9, 10, 21, 56, 33, 37, DateTimeKind.Local).AddTicks(476), 58.07m, 6757112449791609m, "Courier", 2, 45.264095f, "017 Hane Mill, Lewfort, Mongolia", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "51504 Weimann Springs, East Rosellachester, Kyrgyz Republic", new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8"), "OnTheWay", "CardboardBox" },
                    { new Guid("2f091c4f-a704-49c2-a6af-bbb9706f48f1"), new DateTime(2024, 2, 18, 13, 22, 17, 585, DateTimeKind.Local).AddTicks(6290), new DateTime(2024, 2, 25, 13, 22, 17, 585, DateTimeKind.Local).AddTicks(6290), 37.11m, 6277488179032588m, "ParcelMachine", 2, 11.73291f, "64904 Louvenia Rest, East Demarcomouth, Djibouti", new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9"), "154 Ruben Extension, North Alvis, United States of America", new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("315d2348-438f-405f-a11d-04c11c10182e"), new DateTime(2023, 7, 29, 3, 30, 39, 21, DateTimeKind.Local).AddTicks(9700), new DateTime(2023, 8, 3, 3, 30, 39, 21, DateTimeKind.Local).AddTicks(9700), 35.34m, true, 7910219412004069m, "Courier", 2, 31.534771f, "45007 Kaleigh Dale, Port Alessandra, Spain", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c"), "2960 Torphy Knolls, Hoppeport, Fiji", new Guid("24292576-82c4-4a01-961e-e050d58bf4a8"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("324ca956-95cb-4459-9c87-73c823039013"), new DateTime(2023, 6, 25, 5, 47, 35, 953, DateTimeKind.Local).AddTicks(1994), new DateTime(2023, 6, 28, 5, 47, 35, 953, DateTimeKind.Local).AddTicks(1994), 72.88m, 7942507696565314m, true, "Courier", 5, 17.384277f, "087 Tremblay Plains, Cierraview, Virgin Islands, U.S.", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), "46155 Dahlia Mall, New Timmybury, Peru", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("34eef8d3-b6c7-4069-9464-a553cc37dc49"), new DateTime(2023, 6, 21, 5, 52, 35, 521, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 6, 29, 5, 52, 35, 521, DateTimeKind.Local).AddTicks(6062), 97.55m, true, 1852036440664467m, true, "ParcelMachine", 4, 24.167723f, "12714 Devante Parkways, New Faustobury, Lesotho", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), "7074 Orn Pass, Lindmouth, Malawi", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3a261103-d12b-4ac1-8a5c-8752949c4ae0"), new DateTime(2024, 5, 7, 10, 50, 36, 783, DateTimeKind.Local).AddTicks(3214), new DateTime(2024, 5, 11, 10, 50, 36, 783, DateTimeKind.Local).AddTicks(3214), 65.68m, 7660405635324192m, "Standart", 1, 44.176723f, "02494 Grady Common, South Kyleebury, Bangladesh", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b"), "7239 Trudie Loaf, North Elinorestad, South Georgia and the South Sandwich Islands", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3b939588-c7d5-416a-97e9-d285afa943bd"), new DateTime(2024, 4, 12, 22, 20, 17, 529, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 4, 18, 22, 20, 17, 529, DateTimeKind.Local).AddTicks(9899), 33.78m, true, 1029837419365049m, true, "ParcelMachine", 2, 25.183456f, "66215 Thad Shore, Schaeferland, Peru", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "8210 Einar Island, Vandervortmouth, Estonia", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("3e927c87-c4b4-41af-85f4-9f11cb8c5566"), new DateTime(2023, 8, 29, 1, 48, 2, 938, DateTimeKind.Local).AddTicks(4690), new DateTime(2023, 9, 7, 1, 48, 2, 938, DateTimeKind.Local).AddTicks(4690), 43.27m, 5791492120272330m, "Standart", 1, 46.542923f, "57000 Zora Rapid, Jerroldtown, Russian Federation", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), "144 Quigley Loaf, East Greta, Austria", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("40b4b2e8-5592-4392-8c01-284378f0d58e"), new DateTime(2023, 7, 29, 5, 38, 38, 484, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 8, 4, 5, 38, 38, 484, DateTimeKind.Local).AddTicks(3028), 95.93m, true, 1041110445926674m, "ParcelMachine", 4, 8.989531f, "5598 Schultz Branch, West Nashchester, Australia", new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094"), "13978 Clemmie Fort, Thielbury, Brazil", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("42d37e05-4bdd-4295-a3dd-70681c307e6d"), new DateTime(2024, 1, 22, 8, 39, 14, 889, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 1, 28, 8, 39, 14, 889, DateTimeKind.Local).AddTicks(1753), 39.54m, 4371676311985664m, true, "Courier", 5, 20.710636f, "002 Douglas Trace, North Rodhaven, Samoa", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "463 Fritsch Springs, New Savannaview, Jamaica", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("457b3a41-511a-49ef-a563-fd5ec035bcf2"), new DateTime(2023, 10, 15, 6, 30, 14, 913, DateTimeKind.Local).AddTicks(2517), new DateTime(2023, 10, 25, 6, 30, 14, 913, DateTimeKind.Local).AddTicks(2517), 26.24m, true, 1925520181438944m, true, "Special", 4, 26.716627f, "729 Buckridge Burgs, South Sidville, South Georgia and the South Sandwich Islands", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e"), "61720 Jasper Mall, Lake Tomasaberg, Seychelles", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("4aaba9c4-336a-4905-b0ef-3dad7d4b0d94"), new DateTime(2023, 7, 30, 22, 0, 4, 638, DateTimeKind.Local).AddTicks(337), new DateTime(2023, 7, 31, 22, 0, 4, 638, DateTimeKind.Local).AddTicks(337), 11.06m, true, 5075655359030838m, "Special", 1, 29.625475f, "5359 Schumm Lake, Port Jordyn, Netherlands Antilles", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), "130 Adams Corners, New Fordmouth, India", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("4b0dc4b1-ba41-4863-8abc-ad0c89550a97"), new DateTime(2023, 8, 1, 17, 50, 31, 363, DateTimeKind.Local).AddTicks(7692), new DateTime(2023, 8, 7, 17, 50, 31, 363, DateTimeKind.Local).AddTicks(7692), 27.39m, 3133377038030526m, "Courier", 2, 14.076526f, "74695 Pfeffer River, South Cleorabury, Norway", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "31700 Janick Lake, Ondrickaland, Ireland", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "OnTheWay", "CardboardBox" },
                    { new Guid("4b1ce75b-1d70-49af-b3b5-397ecc0302a0"), new DateTime(2023, 6, 18, 22, 24, 29, 600, DateTimeKind.Local).AddTicks(480), new DateTime(2023, 6, 22, 22, 24, 29, 600, DateTimeKind.Local).AddTicks(480), 76.85m, 2397631654925922m, "Standart", 5, 36.052418f, "8300 Sporer Gateway, Port Monserrate, Venezuela", new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757"), "92568 Hackett Gardens, Lake Bernard, Iran", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("53ece3ec-ae37-4ba5-aace-c641f1102333"), new DateTime(2023, 11, 21, 12, 30, 39, 482, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 11, 23, 12, 30, 39, 482, DateTimeKind.Local).AddTicks(4151), 81.99m, true, 5404256416378709m, true, "Super", 4, 22.91408f, "353 Farrell Center, East Freddieport, Congo", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "5387 Feeney Drive, North Angelbury, Russian Federation", new Guid("69335634-41ba-4400-a54f-e27126ae5352"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("56e633f3-13cc-4284-b1c1-d9106529a7e3"), new DateTime(2024, 3, 12, 13, 39, 58, 828, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 3, 17, 13, 39, 58, 828, DateTimeKind.Local).AddTicks(5916), 19.27m, 5135593033109834m, true, "Courier", 5, 41.5919f, "9775 Little Locks, Lake Jaedenstad, Azerbaijan", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "04850 Reynolds Ports, Hoegerfurt, Armenia", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5c6750cf-a7dd-43d2-97e6-0349923b4b49"), new DateTime(2023, 11, 23, 9, 49, 58, 462, DateTimeKind.Local).AddTicks(7909), new DateTime(2023, 11, 27, 9, 49, 58, 462, DateTimeKind.Local).AddTicks(7909), 81.58m, true, 1938830685381326m, true, "Courier", 1, 30.940056f, "54451 Nannie Trail, East Linwoodville, Gambia", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), "87346 Larue Isle, Lake Lunaberg, Saint Lucia", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), "Registered", "PlasticBag" },
                    { new Guid("5eb6e8f0-5f26-45e2-b411-c3c00a26e75f"), new DateTime(2023, 12, 9, 18, 41, 58, 953, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 12, 18, 18, 41, 58, 953, DateTimeKind.Local).AddTicks(578), 94.74m, true, 9149367771568652m, true, "Courier", 5, 32.842617f, "576 Cale Stream, Port Bradlytown, Dominica", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a"), "372 Marcus Drive, Lake Amiemouth, Saint Lucia", new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007"), "Delivered", "PlasticBag" },
                    { new Guid("5f56a6ae-67b4-4c1d-8176-e3d911157a86"), new DateTime(2024, 4, 26, 19, 42, 18, 378, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 5, 6, 19, 42, 18, 378, DateTimeKind.Local).AddTicks(9366), 77.62m, true, 1111315393331458m, true, "Courier", 3, 4.1015615f, "204 Koch Vista, Kieranhaven, Cape Verde", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), "533 Schaefer Neck, Anahihaven, Slovakia (Slovak Republic)", new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615"), "Sent", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("5f6e76b9-0001-495a-8e35-201e4d5c4621"), new DateTime(2023, 10, 29, 17, 56, 21, 915, DateTimeKind.Local).AddTicks(779), new DateTime(2023, 10, 31, 17, 56, 21, 915, DateTimeKind.Local).AddTicks(779), 79.36m, 9427295278794994m, true, "Super", 2, 31.177748f, "340 Elliot Wall, New Dante, Bermuda", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "6108 Katherine Alley, East Braden, Azerbaijan", new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a"), "Sent", "CardboardBox" },
                    { new Guid("607146f6-afbe-46f6-8a4a-ef77ad478bdd"), new DateTime(2023, 12, 12, 9, 28, 36, 366, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 12, 14, 9, 28, 36, 366, DateTimeKind.Local).AddTicks(4806), 89.60m, 6779683289852434m, true, "Super", 5, 45.068966f, "8409 Rupert Pine, Lilachester, Myanmar", new Guid("61fe1433-1b16-4004-8246-4e030b366c6d"), "4623 Marquardt Mount, New Gardner, Tuvalu", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("61c179e6-aa82-4fc5-9332-0b20d6edc37d"), new DateTime(2023, 8, 31, 15, 52, 19, 652, DateTimeKind.Local).AddTicks(1951), new DateTime(2023, 9, 2, 15, 52, 19, 652, DateTimeKind.Local).AddTicks(1951), 10.47m, 1590547881056842m, "Courier", 3, 24.422987f, "4933 Ettie Crest, East Samirmouth, Montenegro", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), "3483 Colton Square, West Brendamouth, Antarctica (the territory South of 60 deg S)", new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6263dea4-ce1b-4464-ac61-a869faf77041"), new DateTime(2024, 4, 23, 21, 21, 43, 215, DateTimeKind.Local).AddTicks(7240), new DateTime(2024, 4, 30, 21, 21, 43, 215, DateTimeKind.Local).AddTicks(7240), 22.88m, 8826939122133830m, true, "Super", 1, 47.496243f, "5006 Ziemann Junctions, Maggioburgh, Bermuda", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f"), "523 Luella Roads, Port Reinhold, Costa Rica", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("64a344fd-e9df-4dd6-91e6-2b39eaa8a04b"), new DateTime(2023, 8, 8, 1, 3, 47, 930, DateTimeKind.Local).AddTicks(4159), new DateTime(2023, 8, 10, 1, 3, 47, 930, DateTimeKind.Local).AddTicks(4159), 87.17m, 6516842778509768m, "Super", 3, 25.086626f, "33481 Brekke Ranch, Micaelaland, Gibraltar", new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d"), "600 Cecilia Spur, Crookschester, Saint Martin", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("64ba45a3-169a-43fd-9086-3618cfa7e240"), new DateTime(2024, 5, 12, 2, 52, 34, 329, DateTimeKind.Local).AddTicks(2800), new DateTime(2024, 5, 13, 2, 52, 34, 329, DateTimeKind.Local).AddTicks(2800), 69.06m, true, 6464169054552015m, true, "Courier", 5, 33.32829f, "170 Feil Lodge, Jeffereyton, Greece", new Guid("b6691519-38b6-436a-a19c-602dda7868aa"), "1613 Romaguera Dam, West Isaiasbury, Lao People's Democratic Republic", new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("65308cf8-c7fa-49a5-97cd-7e80383f0ece"), new DateTime(2023, 11, 2, 23, 2, 12, 444, DateTimeKind.Local).AddTicks(2467), new DateTime(2023, 11, 11, 23, 2, 12, 444, DateTimeKind.Local).AddTicks(2467), 95.94m, 2013059858287182m, true, "ParcelMachine", 2, 39.858784f, "68953 Cruickshank Road, West Rozella, Mozambique", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "40456 Briana Station, West Karina, Saint Martin", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0"), "Registered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("653aa141-91c3-492d-b00c-4d95ed4d9015"), new DateTime(2024, 4, 11, 4, 4, 33, 429, DateTimeKind.Local).AddTicks(5913), new DateTime(2024, 4, 18, 4, 4, 33, 429, DateTimeKind.Local).AddTicks(5913), 27.17m, true, 8617972580303518m, true, "Special", 2, 28.047556f, "9444 Carmen Roads, West Elvaport, Botswana", new Guid("afa896ab-be1f-4401-923e-90219b5466bb"), "6098 Wintheiser Stravenue, Bednarstad, Bolivia", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "OnTheWay", "PlasticBag" },
                    { new Guid("67c170ba-2552-4182-a8f1-14e4d76f2e2e"), new DateTime(2023, 11, 8, 15, 30, 31, 381, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 11, 13, 15, 30, 31, 381, DateTimeKind.Local).AddTicks(8811), 71.28m, true, 5653735913676289m, true, "Standart", 5, 45.65384f, "66679 Magnus Orchard, New Hollieberg, Nigeria", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "175 Una Ferry, Treutelport, Belize", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("67e1a262-09bf-4965-b841-b9753d1b7962"), new DateTime(2023, 11, 19, 17, 52, 37, 794, DateTimeKind.Local).AddTicks(5714), new DateTime(2023, 11, 22, 17, 52, 37, 794, DateTimeKind.Local).AddTicks(5714), 33.25m, true, 6039353673988002m, "Super", 4, 44.661346f, "872 Macejkovic Walks, Abernathychester, Samoa", new Guid("67a0fefa-c903-4326-91fc-981d72b581a8"), "5401 Ernser Turnpike, West Wade, Philippines", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "Return", "PlasticBag" },
                    { new Guid("69e92056-403f-4bc4-9927-5443da0a4cc4"), new DateTime(2024, 5, 12, 2, 50, 45, 603, DateTimeKind.Local).AddTicks(4083), new DateTime(2024, 5, 13, 2, 50, 45, 603, DateTimeKind.Local).AddTicks(4083), 11.97m, true, 4962575621559147m, "Special", 5, 18.873444f, "7774 Arnold Stream, West Dawsonshire, Sao Tome and Principe", new Guid("41296760-deca-4b2d-a760-5538da32ccb4"), "051 Schneider Vista, Erdmanton, Russian Federation", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), "Sent", "CardboardBox" },
                    { new Guid("6adae9e6-deb8-4299-a841-2a11283d9c70"), new DateTime(2024, 6, 1, 4, 30, 0, 595, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 6, 4, 4, 30, 0, 595, DateTimeKind.Local).AddTicks(8273), 89.83m, true, 3972849864872834m, "Standart", 2, 33.78837f, "92076 Kip Track, Zackeryland, Palestinian Territory", new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), "6532 Schuppe Stravenue, Laurineland, Bouvet Island (Bouvetoya)", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "Delivered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6ae045dc-ce56-4c8a-bd13-fe0dd8263312"), new DateTime(2023, 10, 31, 12, 8, 53, 745, DateTimeKind.Local).AddTicks(6893), new DateTime(2023, 11, 10, 12, 8, 53, 745, DateTimeKind.Local).AddTicks(6893), 54.18m, 9776920775826816m, "ParcelMachine", 4, 25.918571f, "824 Lavern Course, New Beatrice, Cambodia", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "105 Jaron Divide, North Gilbert, Panama", new Guid("b6691519-38b6-436a-a19c-602dda7868aa"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6dddfb6c-1a42-4a10-8099-acfcf8a1099f"), new DateTime(2024, 1, 13, 16, 21, 13, 634, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 1, 19, 16, 21, 13, 634, DateTimeKind.Local).AddTicks(6705), 74.77m, true, 2435958897505070m, true, "Super", 2, 22.679472f, "164 Charley Stream, Efrenchester, France", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2"), "871 Wilkinson Path, Zackaryfurt, Armenia", new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6f121a65-3f18-4c79-87cb-8bf5b1dc7e96"), new DateTime(2023, 10, 1, 0, 11, 43, 903, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 10, 10, 0, 11, 43, 903, DateTimeKind.Local).AddTicks(6690), 64.42m, true, 4270643167544679m, "Standart", 2, 34.333435f, "61758 Josianne Village, Hansenmouth, Liberia", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "54120 Enola Shoal, West Guidomouth, Macedonia", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("6f2ac005-0afe-4908-a31c-fc554ff1e7fd"), new DateTime(2023, 7, 19, 1, 32, 36, 376, DateTimeKind.Local).AddTicks(6568), new DateTime(2023, 7, 22, 1, 32, 36, 376, DateTimeKind.Local).AddTicks(6568), 36.74m, true, 5150244484460752m, true, "Standart", 4, 4.8778944f, "006 MacGyver Dale, Watsicaview, Puerto Rico", new Guid("a0c72d91-dc13-4995-848c-613286a462f4"), "0360 Cole Mews, Schneiderberg, Cuba", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef"), "Return", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("6f55a285-5658-40a1-a855-67550e763a9a"), new DateTime(2023, 6, 17, 17, 24, 43, 956, DateTimeKind.Local).AddTicks(9240), new DateTime(2023, 6, 23, 17, 24, 43, 956, DateTimeKind.Local).AddTicks(9240), 55.45m, 9969471050426902m, "Special", 2, 11.730146f, "35056 Wiegand Point, South Nedra, Burundi", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834"), "24658 Jenkins Drives, Reicherttown, Martinique", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), "OnTheWay", "CardboardBox" },
                    { new Guid("70a71ed0-2811-424a-9f52-7f9d81cc6715"), new DateTime(2024, 6, 6, 18, 53, 17, 923, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 6, 13, 18, 53, 17, 923, DateTimeKind.Local).AddTicks(600), 29.75m, 9114503971553380m, "Super", 1, 40.99037f, "48745 Wyman Brooks, Carterchester, Falkland Islands (Malvinas)", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), "829 Marks Mall, Runolfssonstad, Andorra", new Guid("19c67f23-dfcc-4228-91b6-db840755a673"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("7658850e-267e-4a6f-90b2-ee5863d8c813"), new DateTime(2024, 4, 9, 16, 36, 41, 143, DateTimeKind.Local).AddTicks(882), new DateTime(2024, 4, 17, 16, 36, 41, 143, DateTimeKind.Local).AddTicks(882), 16.53m, 1001585821268190m, true, "Courier", 2, 42.83041f, "42655 Steuber Pines, Morarchester, Argentina", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), "5981 Hellen Squares, South Anabelle, Benin", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), "Delivered", "PlasticBag" },
                    { new Guid("7902892d-b6f6-4226-ba75-fe8d6561c9f2"), new DateTime(2023, 8, 30, 2, 23, 22, 977, DateTimeKind.Local).AddTicks(3010), new DateTime(2023, 9, 5, 2, 23, 22, 977, DateTimeKind.Local).AddTicks(3010), 55.21m, 8587091568411162m, true, "ParcelMachine", 3, 36.7136f, "871 Aida Burg, New Aron, Azerbaijan", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834"), "602 Terry Hill, Gleasonstad, Anguilla", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "Registered", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("7aa2bbe3-a3f9-4eed-bff3-63591f82f04a"), new DateTime(2023, 11, 3, 14, 39, 0, 364, DateTimeKind.Local).AddTicks(8232), new DateTime(2023, 11, 4, 14, 39, 0, 364, DateTimeKind.Local).AddTicks(8232), 65.73m, 4104029596024166m, "Courier", 3, 15.285861f, "1945 Johnston Viaduct, New Juvenal, Guadeloupe", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), "1753 Adrienne Crest, East Eldred, Bhutan", new Guid("e698e260-89e1-4c83-b493-1379542f5647"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("7aa4bc92-d3d5-4900-8337-9dec4e23e3ad"), new DateTime(2024, 1, 20, 12, 10, 13, 934, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 1, 24, 12, 10, 13, 934, DateTimeKind.Local).AddTicks(1821), 57.23m, true, 3848682309369836m, true, "ParcelMachine", 1, 28.975315f, "50057 Monahan Place, Calistatown, Iceland", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c"), "9859 Stefan Junctions, New Greta, Philippines", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "Registered", "CardboardBox" },
                    { new Guid("800e02bf-0a4d-4b93-a740-86d7909aace1"), new DateTime(2023, 8, 22, 14, 16, 46, 397, DateTimeKind.Local).AddTicks(621), new DateTime(2023, 8, 31, 14, 16, 46, 397, DateTimeKind.Local).AddTicks(621), 66.10m, true, 1496001578709948m, true, "Special", 2, 37.8299f, "61114 Kellen Unions, Lake Chaunceystad, Anguilla", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), "222 Harvey Overpass, Adolfobury, United Kingdom", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("81a87338-1af2-4a38-b3c8-618a2a5211b3"), new DateTime(2023, 11, 13, 11, 33, 20, 654, DateTimeKind.Local).AddTicks(9941), new DateTime(2023, 11, 15, 11, 33, 20, 654, DateTimeKind.Local).AddTicks(9941), 25.63m, true, 9153792493437884m, "Standart", 4, 6.01597f, "8700 Heller Fords, South Alexie, Ghana", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), "149 Lillian Ports, South Shea, Taiwan", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2"), "Delivered", "CardboardBox" },
                    { new Guid("820df50b-4f42-4913-8582-7455a12e598e"), new DateTime(2024, 1, 3, 8, 59, 41, 204, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 1, 4, 8, 59, 41, 204, DateTimeKind.Local).AddTicks(4812), 40.50m, true, 8658476407090138m, "Super", 1, 42.001747f, "8460 Michale Port, Burniceshire, Malawi", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f"), "390 Blake Tunnel, Myrtisfurt, Paraguay", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("895c7984-50a9-4243-9c99-f433001b5056"), new DateTime(2024, 2, 28, 12, 56, 4, 110, DateTimeKind.Local).AddTicks(1856), new DateTime(2024, 3, 1, 12, 56, 4, 110, DateTimeKind.Local).AddTicks(1856), 13.34m, 4317794519291278m, true, "Super", 5, 15.797901f, "165 Eloise Port, Gulgowskiberg, Barbados", new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332"), "4510 Jesus Brooks, Schmidtmouth, Cambodia", new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552"), "OnTheWay", "CardboardBox" },
                    { new Guid("8a6f1b2f-07c7-4e4f-ad99-9e2832ba8503"), new DateTime(2023, 11, 18, 10, 30, 26, 441, DateTimeKind.Local).AddTicks(8117), new DateTime(2023, 11, 27, 10, 30, 26, 441, DateTimeKind.Local).AddTicks(8117), 19.16m, 1269119758716264m, true, "ParcelMachine", 4, 17.56275f, "071 Labadie Turnpike, East Bradford, Reunion", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "116 Rhett Manors, North Maud, United States Minor Outlying Islands", new Guid("edf37002-a546-4d28-acd9-2614759e640d"), "OnTheWay", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("8b93c17f-96e5-4778-a770-02a9d7f13d82"), new DateTime(2024, 2, 26, 12, 19, 47, 145, DateTimeKind.Local).AddTicks(1705), new DateTime(2024, 3, 3, 12, 19, 47, 145, DateTimeKind.Local).AddTicks(1705), 80.29m, 9156688399543806m, "Special", 2, 17.693998f, "62985 Lewis Route, East Magali, Japan", new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328"), "8650 Tillman Landing, Cristalfort, Suriname", new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("91b5de07-3eac-4209-b8b0-e3d1fb531096"), new DateTime(2023, 12, 7, 13, 16, 43, 592, DateTimeKind.Local).AddTicks(1225), new DateTime(2023, 12, 13, 13, 16, 43, 592, DateTimeKind.Local).AddTicks(1225), 72.29m, 9797308663566188m, true, "Courier", 2, 39.021667f, "919 Nicolas Extension, Port Viviane, Saudi Arabia", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), "2725 Carleton Turnpike, Simonisburgh, Kenya", new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), "Delivered", "CardboardBox" },
                    { new Guid("93628869-d32c-41b0-9ebf-c0469322a161"), new DateTime(2023, 8, 24, 21, 19, 51, 798, DateTimeKind.Local).AddTicks(9958), new DateTime(2023, 8, 25, 21, 19, 51, 798, DateTimeKind.Local).AddTicks(9958), 50.16m, 8316960142390017m, true, "Courier", 1, 33.086166f, "39259 Trace Crescent, West Kenyattamouth, Singapore", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "9844 Block Springs, Flatleyberg, Liechtenstein", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("9e156c67-da6e-46d0-95d4-464ae88055ee"), new DateTime(2023, 12, 14, 21, 41, 34, 833, DateTimeKind.Local).AddTicks(8511), new DateTime(2023, 12, 18, 21, 41, 34, 833, DateTimeKind.Local).AddTicks(8511), 89.47m, true, 4253358062624562m, true, "Super", 4, 49.506844f, "8771 Monahan Park, New Johnside, Greece", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "312 Hahn Terrace, New Dennisfort, Eritrea", new Guid("0f432380-a89c-4564-a477-a1ed20795e01"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a0219d1f-fb26-4c56-b7b2-02d706cf51bc"), new DateTime(2023, 12, 22, 14, 32, 26, 849, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 12, 26, 14, 32, 26, 849, DateTimeKind.Local).AddTicks(8643), 76.79m, 3808033585033124m, "Courier", 1, 38.03217f, "0846 Turcotte Valley, New Antoneburgh, Afghanistan", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "177 Koepp Plaza, North Arturo, Pitcairn Islands", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "Sent", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a09a4e07-e24c-4a9a-a238-26768364a6ee"), new DateTime(2024, 2, 28, 4, 25, 55, 105, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 3, 8, 4, 25, 55, 105, DateTimeKind.Local).AddTicks(1859), 51.72m, true, 5637008680046977m, true, "Super", 4, 43.990364f, "39027 Moore Prairie, Fionaland, Armenia", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), "2858 Oren Estate, Runteburgh, Reunion", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("a12ccbf7-45bb-40aa-ae84-0a1b59e3453e"), new DateTime(2023, 10, 27, 2, 33, 4, 172, DateTimeKind.Local).AddTicks(3215), new DateTime(2023, 10, 29, 2, 33, 4, 172, DateTimeKind.Local).AddTicks(3215), 17.17m, 6336501257756132m, "Super", 4, 35.345387f, "3292 Isaias Plaza, Jenningsview, Sierra Leone", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "8415 Jennings Springs, Port Matildehaven, Mozambique", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a14024e9-a5b8-4a88-8094-c4dbad881632"), new DateTime(2023, 10, 29, 18, 49, 50, 924, DateTimeKind.Local).AddTicks(3206), new DateTime(2023, 11, 2, 18, 49, 50, 924, DateTimeKind.Local).AddTicks(3206), 41.96m, true, 7981026443266376m, "Standart", 2, 15.218331f, "6897 Maurine Motorway, Cleveland, France", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), "6840 Hyatt Throughway, New Kristown, Aruba", new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce"), "Return", "PlasticBag" },
                    { new Guid("a3e0a28e-1166-4ebf-b74d-91e8347a8be9"), new DateTime(2024, 5, 21, 18, 57, 24, 8, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 5, 23, 18, 57, 24, 8, DateTimeKind.Local).AddTicks(1060), 47.90m, true, 7989043189940406m, "Super", 4, 5.691736f, "290 Carter Harbor, North Otto, Western Sahara", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "057 Beer Place, Lake Danika, Comoros", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "OnTheWay", "PlasticBag" },
                    { new Guid("a5810b5b-1e79-4554-9223-f7b731d264da"), new DateTime(2024, 1, 21, 17, 25, 29, 155, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 1, 23, 17, 25, 29, 155, DateTimeKind.Local).AddTicks(5148), 29.23m, true, 9137786079833304m, "Standart", 5, 20.854319f, "874 Wintheiser Stravenue, Dickiberg, United States Minor Outlying Islands", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7"), "43290 Mueller Loaf, North Jay, Bhutan", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "Delivered", "PlasticBag" },
                    { new Guid("a6364f72-e111-41d3-b5f3-6e28069bfe6a"), new DateTime(2023, 7, 6, 17, 18, 11, 267, DateTimeKind.Local).AddTicks(1574), new DateTime(2023, 7, 15, 17, 18, 11, 267, DateTimeKind.Local).AddTicks(1574), 85.18m, true, 4784637192394046m, "Super", 1, 45.015728f, "40528 Ward Falls, Claudshire, Brunei Darussalam", new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb"), "15100 Kreiger Village, West Ednaborough, Sierra Leone", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("a9ef035e-350b-41b0-9856-899e91ce6fde"), new DateTime(2023, 9, 26, 6, 29, 23, 359, DateTimeKind.Local).AddTicks(5599), new DateTime(2023, 9, 28, 6, 29, 23, 359, DateTimeKind.Local).AddTicks(5599), 57.47m, true, 5669386411378010m, true, "Special", 5, 10.799676f, "798 Conn Brooks, Troystad, Antigua and Barbuda", new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37"), "950 Althea Summit, New Markusview, Antarctica (the territory South of 60 deg S)", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), "Delivered", "CardboardBox" },
                    { new Guid("aa42909f-cd94-40c4-b5e9-b6be8cdcc725"), new DateTime(2023, 9, 20, 7, 17, 44, 334, DateTimeKind.Local).AddTicks(1117), new DateTime(2023, 9, 29, 7, 17, 44, 334, DateTimeKind.Local).AddTicks(1117), 34.60m, true, 8494309695189312m, true, "ParcelMachine", 5, 29.118105f, "725 Bergstrom Estates, Leschhaven, Christmas Island", new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40"), "8578 Ima Plains, Lake Abnerchester, Heard Island and McDonald Islands", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), "Sent", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ab3b076a-5e6a-494a-a2de-ba702fd62961"), new DateTime(2023, 12, 10, 7, 42, 24, 411, DateTimeKind.Local).AddTicks(4), new DateTime(2023, 12, 12, 7, 42, 24, 411, DateTimeKind.Local).AddTicks(4), 88.11m, 8095060347946319m, true, "Special", 3, 18.543262f, "7040 Armstrong Forks, Jorgemouth, San Marino", new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1"), "26882 Kayla Tunnel, South Moriah, Turks and Caicos Islands", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ac36414e-775c-431d-a73a-4a33f21c0b24"), new DateTime(2023, 8, 24, 22, 20, 44, 491, DateTimeKind.Local).AddTicks(1184), new DateTime(2023, 9, 3, 22, 20, 44, 491, DateTimeKind.Local).AddTicks(1184), 33.65m, true, 6323078027986531m, true, "ParcelMachine", 5, 13.645928f, "3296 Brian Villages, Brandyfurt, Colombia", new Guid("702dc016-070a-4620-818f-b4e492286066"), "31288 Batz Ridges, East Asha, Cook Islands", new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b3296368-3551-4fd8-8d63-7820cbd6e402"), new DateTime(2024, 3, 7, 10, 18, 39, 498, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 3, 12, 10, 18, 39, 498, DateTimeKind.Local).AddTicks(8553), 26.63m, true, 7132354999842320m, "Courier", 3, 43.8328f, "6482 Schimmel Flats, Port Montyview, Spain", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), "80707 Nicholaus Meadows, Sedricktown, Somalia", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b755c0c1-8aae-4728-8c9b-6e32fd2c1b30"), new DateTime(2023, 9, 3, 15, 46, 45, 614, DateTimeKind.Local).AddTicks(6669), new DateTime(2023, 9, 8, 15, 46, 45, 614, DateTimeKind.Local).AddTicks(6669), 89.08m, true, 1476549106854832m, true, "Courier", 3, 20.324806f, "48483 Gislason Center, North Danialville, Saudi Arabia", new Guid("65012c66-d07a-40f6-9789-b100201359c2"), "95424 Bahringer Burgs, Beckerborough, Tunisia", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("b7678277-c7f6-4ee2-ae4c-21f645f8c6a5"), new DateTime(2023, 10, 21, 6, 53, 38, 899, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 10, 22, 6, 53, 38, 899, DateTimeKind.Local).AddTicks(7942), 56.95m, true, 8906574265866685m, "ParcelMachine", 5, 3.242003f, "351 Kiehn Pass, West Rudolph, Bangladesh", new Guid("de7d9783-5299-4552-b426-e13c1b4a4995"), "337 Powlowski Ville, Jenniferton, Virgin Islands, U.S.", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bda4d607-34aa-4dd8-b1aa-7fa316f70fc9"), new DateTime(2024, 5, 10, 9, 52, 32, 475, DateTimeKind.Local).AddTicks(1387), new DateTime(2024, 5, 17, 9, 52, 32, 475, DateTimeKind.Local).AddTicks(1387), 76.91m, true, 5817422227923469m, true, "Courier", 1, 10.1981325f, "209 Scottie Springs, Maeland, Saint Vincent and the Grenadines", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c"), "2143 Janessa Station, South Daishamouth, Bolivia", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("bee0f3e4-f443-44c0-aaa8-e90d400b7ccb"), new DateTime(2023, 12, 12, 2, 0, 54, 990, DateTimeKind.Local).AddTicks(3201), new DateTime(2023, 12, 19, 2, 0, 54, 990, DateTimeKind.Local).AddTicks(3201), 21.02m, 9160310032918852m, "Courier", 3, 30.288347f, "4580 Hilll Haven, North Carmenport, Seychelles", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "7069 Marcel Row, Dorthafurt, Singapore", new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("c5c10028-d75e-4a04-82b5-4e8119d0447e"), new DateTime(2023, 12, 1, 0, 8, 23, 991, DateTimeKind.Local).AddTicks(3569), new DateTime(2023, 12, 3, 0, 8, 23, 991, DateTimeKind.Local).AddTicks(3569), 55.40m, true, 5489183577994905m, "Courier", 2, 29.206028f, "30806 Lupe Brooks, South Deshaunbury, Seychelles", new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), "63652 Witting Springs, Harveymouth, Italy", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "Sent", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("c81e51af-12dc-4fa8-ba6f-ba6cf2848bb2"), new DateTime(2024, 2, 12, 8, 47, 31, 990, DateTimeKind.Local).AddTicks(9681), new DateTime(2024, 2, 18, 8, 47, 31, 990, DateTimeKind.Local).AddTicks(9681), 25.35m, 5732065377427510m, true, "Super", 1, 16.388805f, "785 Nola Parks, Bahringerbury, Micronesia", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), "4513 Willms Union, East Rowlandview, Kyrgyz Republic", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), "Delivered", "CardboardBox" },
                    { new Guid("cb5eec73-922c-4b17-b658-d0581e1c1da4"), new DateTime(2023, 7, 17, 16, 5, 15, 584, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 7, 20, 16, 5, 15, 584, DateTimeKind.Local).AddTicks(953), 95.16m, 5909145042955837m, true, "Courier", 3, 11.321988f, "2711 Hillard Hills, Hodkiewiczshire, Uruguay", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7"), "91449 Wisozk Burgs, Aufderharmouth, United States of America", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "Return", "PlasticBag" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ceebecdb-9ecb-42e9-8295-dc40ce812826"), new DateTime(2023, 8, 6, 13, 11, 18, 106, DateTimeKind.Local).AddTicks(9158), new DateTime(2023, 8, 13, 13, 11, 18, 106, DateTimeKind.Local).AddTicks(9158), 92.10m, 2956035643859272m, "ParcelMachine", 3, 5.464065f, "6297 Stark Streets, Larkinport, Bulgaria", new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5"), "178 Ova Vista, West Rethamouth, Qatar", new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("cf010bc9-7235-4fd1-b5f8-f5298500e3e7"), new DateTime(2024, 2, 18, 4, 16, 13, 871, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 2, 24, 4, 16, 13, 871, DateTimeKind.Local).AddTicks(2363), 13.69m, true, 8520569668374322m, "Standart", 4, 0.49380776f, "40943 Rowland Points, Baileyberg, Netherlands", new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865"), "25681 Donnelly Shoals, Port Allie, Netherlands Antilles", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("dd15a32c-0572-410c-b14a-b74466461126"), new DateTime(2024, 3, 25, 8, 12, 32, 78, DateTimeKind.Local).AddTicks(3128), new DateTime(2024, 4, 4, 8, 12, 32, 78, DateTimeKind.Local).AddTicks(3128), 86.34m, 5715228682431492m, "ParcelMachine", 5, 14.5053f, "09373 Ahmad Common, Feilfurt, Uruguay", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc"), "95073 Carlo Forge, Cordeliafort, Uruguay", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "Registered", "CardboardBox" },
                    { new Guid("e6e66fdb-341e-43e7-af5e-83392ee5793b"), new DateTime(2024, 4, 10, 9, 17, 9, 233, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 4, 12, 9, 17, 9, 233, DateTimeKind.Local).AddTicks(1369), 26.17m, 1139491989472744m, "Courier", 2, 45.988907f, "4682 Annamarie Turnpike, Monaside, Mali", new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49"), "19275 Imelda Field, North Bertrambury, Comoros", new Guid("ca402be9-4708-4877-ada7-62364da2236a"), "Registered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e790679a-caef-446f-ae52-f2d75161cecd"), new DateTime(2024, 5, 29, 10, 1, 27, 372, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 6, 1, 10, 1, 27, 372, DateTimeKind.Local).AddTicks(7154), 20.60m, true, 3810192914107722m, true, "Standart", 3, 17.56084f, "824 Brody Rest, Quitzonland, Honduras", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "975 Quigley Circles, Ebonychester, Turks and Caicos Islands", new Guid("19c67f23-dfcc-4228-91b6-db840755a673"), "Registered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e86e55e7-c2d8-409e-a2eb-0bde41840203"), new DateTime(2023, 6, 18, 12, 31, 14, 467, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 6, 24, 12, 31, 14, 467, DateTimeKind.Local).AddTicks(7927), 69.52m, true, 5703766402071877m, "Special", 5, 44.39777f, "97488 Jones Ford, Salvatorehaven, Central African Republic", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), "6435 Marc Camp, Grahammouth, Saint Barthelemy", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("e8cfb6c6-9657-4e84-a6f6-ce3647c6a0ef"), new DateTime(2024, 3, 9, 10, 33, 32, 895, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 3, 11, 10, 33, 32, 895, DateTimeKind.Local).AddTicks(3212), 52.58m, 5920749655182079m, true, "Standart", 1, 35.80672f, "757 Jettie Motorway, Lake Dolores, Hong Kong", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "6777 Tanya Lodge, North Philipchester, Germany", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ea73da12-653e-40c2-b8fe-d49906d2f576"), new DateTime(2024, 2, 7, 4, 1, 52, 96, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 2, 13, 4, 1, 52, 96, DateTimeKind.Local).AddTicks(2195), 93.54m, true, 9142746507420528m, true, "ParcelMachine", 5, 39.713795f, "50936 Billy Extension, Kubborough, Belize", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f"), "177 Harris Forge, Schmittfort, Indonesia", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), "Delivered", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("ed4bcea4-0ce8-4b85-a2a8-adb7b6d0cbc0"), new DateTime(2024, 4, 10, 23, 51, 45, 425, DateTimeKind.Local).AddTicks(9327), new DateTime(2024, 4, 13, 23, 51, 45, 425, DateTimeKind.Local).AddTicks(9327), 18.80m, 3894510563223028m, true, "Standart", 1, 14.352236f, "74367 Randal Points, Port Durward, India", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "4830 Callie Points, Tamaratown, Guinea-Bissau", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f0d77ded-dc43-4359-bfd2-395033d9fe47"), new DateTime(2023, 11, 13, 13, 40, 56, 967, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 11, 22, 13, 40, 56, 967, DateTimeKind.Local).AddTicks(1766), 69.06m, true, 8488901992720229m, "Courier", 5, 39.13765f, "70976 Rolfson Islands, Kuhlmanville, Sao Tome and Principe", new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714"), "4323 Kiehn Highway, Concepcionborough, Brazil", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f65486f9-6e3b-497b-a0d3-4e9da570d028"), new DateTime(2024, 4, 3, 22, 23, 29, 573, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 4, 6, 22, 23, 29, 573, DateTimeKind.Local).AddTicks(7446), 94.81m, 5179955306844324m, true, "Super", 4, 3.9051409f, "7367 Wanda Forks, South Richard, New Caledonia", new Guid("913aac82-79cd-4930-833a-d54464607133"), "3869 Gay Passage, South Leonardo, Panama", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef"), "Return", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("f6cb06a8-6b11-4b89-ab9c-3b88e0b0de15"), new DateTime(2024, 5, 14, 0, 39, 46, 940, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 5, 17, 0, 39, 46, 940, DateTimeKind.Local).AddTicks(557), 98.75m, 8442838827253615m, "Courier", 4, 36.124893f, "53146 Mills Loaf, Desmondtown, Ethiopia", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), "7921 Lavern Divide, Lake Gusshire, Maldives", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), "OnTheWay", "PlasticBag" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fa4f37cf-01d1-4086-b95f-46d657c17c71"), new DateTime(2024, 1, 26, 19, 54, 28, 877, DateTimeKind.Local).AddTicks(8936), new DateTime(2024, 2, 4, 19, 54, 28, 877, DateTimeKind.Local).AddTicks(8936), 81.90m, true, 4686999346515130m, true, "Courier", 1, 15.64663f, "7955 Kiera Circles, Kassulkefort, Cambodia", new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), "66287 Abbott Bridge, West Orlandoburgh, Zimbabwe", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), "OnTheWay", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "InvoiceNumber", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[,]
                {
                    { new Guid("fb24c14f-2a94-49cf-89bb-eab961c076f0"), new DateTime(2023, 9, 24, 19, 39, 11, 273, DateTimeKind.Local).AddTicks(6117), new DateTime(2023, 10, 3, 19, 39, 11, 273, DateTimeKind.Local).AddTicks(6117), 87.21m, 8081138463471220m, "Standart", 3, 15.266363f, "0227 Odell Fork, Elianetown, China", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f"), "662 Dave Drives, Bentonport, Jordan", new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911"), "Delivered", "CardboardBox" },
                    { new Guid("fcfdf5fe-5db9-41b5-bc24-220154429d59"), new DateTime(2023, 10, 1, 6, 14, 14, 62, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 10, 11, 6, 14, 14, 62, DateTimeKind.Local).AddTicks(9458), 16.00m, 1551622332745494m, "Standart", 3, 4.1009955f, "801 Green Curve, West Camerontown, South Georgia and the South Sandwich Islands", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a"), "0960 Wellington Viaduct, Einarfurt, New Caledonia", new Guid("6e90baa7-8b75-4108-acaa-210af704a12f"), "Delivered", "CardboardBox" }
                });

            migrationBuilder.InsertData(
                table: "Parcels",
                columns: new[] { "ParcelId", "DateOfDispatch", "DateOfReceipt", "DeliveryPrice", "HomeDelivery", "InvoiceNumber", "LossCoverage", "MethodDelivery", "NumberOfPackages", "ParcelWeight", "RecipientAddress", "RecipientId", "SenderAddress", "SenderId", "Status", "TypePackaging" },
                values: new object[] { new Guid("fe570dba-1a24-4778-b1ef-b1b92989b22c"), new DateTime(2024, 1, 11, 23, 55, 37, 357, DateTimeKind.Local).AddTicks(3546), new DateTime(2024, 1, 17, 23, 55, 37, 357, DateTimeKind.Local).AddTicks(3546), 87.74m, true, 5358456380994078m, true, "ParcelMachine", 4, 7.4617524f, "9956 Stoltenberg Mills, Mooreside, Angola", new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d"), "33160 Lynn Trail, Hildegardhaven, Gibraltar", new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f"), "Delivered", "CardboardBox" });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("0084d4d6-6851-4adb-875d-991c59b6cc3c"), "987", "4005514886770557", new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1"), "03/26" },
                    { new Guid("012c664e-a74a-4764-a0cf-521c83d845f2"), "467", "5917083739718976", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669"), "03/07" },
                    { new Guid("020d93a5-495f-45b5-ad9a-330303bd940e"), "799", "2484655541108530", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7"), "03/28" },
                    { new Guid("0249629f-08c7-4351-80d5-9f9dd49df992"), "960", "3930842955067296", new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245"), "10/22" },
                    { new Guid("03186696-839f-4cd1-86c5-f553508ef8e7"), "104", "8286321337217706", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6"), "08/23" },
                    { new Guid("03279b81-6d59-4d25-81f9-ea9016c1e61d"), "874", "6790838190265478", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), "08/23" },
                    { new Guid("0361f5ce-ccfe-43f9-b620-043cf3408a49"), "185", "5907791660351634", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02"), "02/17" },
                    { new Guid("037ccdbe-8790-46be-9b2d-281ea717f3b1"), "730", "5876476538898382", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2"), "02/11" },
                    { new Guid("03a26ae6-2ea0-4d4d-99a6-855d1b9f3950"), "152", "7466809982603098", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), "11/11" },
                    { new Guid("03ebfc4d-57a9-463f-91b0-ca352354127d"), "708", "1395880097278697", new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63"), "08/23" },
                    { new Guid("045e06fc-bdee-4208-99f3-4efce2679e77"), "941", "1183087221203299", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), "07/23" },
                    { new Guid("05006ef6-89ae-4a10-acf0-ea9b90bbef1e"), "992", "4924663301102741", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a"), "12/20" },
                    { new Guid("05979110-2a84-4a00-993d-d1411874949e"), "571", "2206269877246742", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3"), "09/19" },
                    { new Guid("0604c9b8-f019-4b95-8d8b-08a3b758a149"), "577", "2745430787823013", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), "01/05" },
                    { new Guid("066a52a7-8578-44e9-b076-e516a5e84a82"), "807", "2656963139442785", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91"), "12/06" },
                    { new Guid("06992649-33ae-4d54-8f20-74f0224a5c7d"), "908", "8187529812465609", new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5"), "11/06" },
                    { new Guid("06aadd26-500d-432f-aaee-a7f734dc4f38"), "220", "7441108589162550", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), "03/14" },
                    { new Guid("071ddbd1-919a-4234-b586-5cd32528669f"), "834", "5369230458280425", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), "03/04" },
                    { new Guid("073f9f5a-6c61-40de-89a3-b568328bd6ce"), "344", "7817987893357703", new Guid("51274356-5ef0-4e46-a687-716d200f49e1"), "12/09" },
                    { new Guid("0754f099-4ec1-4e76-be99-a8b16ea71325"), "950", "2815947174586859", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "06/06" },
                    { new Guid("078aa5a0-71c8-42ca-ac21-314c9d67c488"), "858", "7197588192924234", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), "10/13" },
                    { new Guid("078d81e4-51fc-4950-b297-c0457e00b0b4"), "987", "8337887694391773", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf"), "05/02" },
                    { new Guid("08bc4fc6-ebec-4bf9-a699-b3530e4dae63"), "071", "4931105520142371", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "10/21" },
                    { new Guid("08dc624f-daab-4820-ba47-40bec1b3a9cf"), "230", "6878273623742346", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de"), "01/22" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("09740f46-636b-4baf-a68e-ea72092aa1c3"), "867", "2449836063443290", new Guid("8b031351-f694-4f12-b95c-b4d9076da358"), "10/10" },
                    { new Guid("09aee8f1-13be-49d6-a1f6-e974f0e0b108"), "196", "7575355900195606", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf"), "09/28" },
                    { new Guid("09fa4c3d-7e9b-4f0c-a9f9-9103855f1737"), "888", "9687367598541558", new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), "02/21" },
                    { new Guid("0a239ec1-e36b-4dad-b7ff-78da5e6d0bd6"), "869", "1469150299481360", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39"), "10/03" },
                    { new Guid("0ac0844b-de4c-4fe3-9fcc-713c1a7ecb2b"), "432", "4209209697852677", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f"), "03/28" },
                    { new Guid("0b49a7a2-c9d7-43bb-93c1-faab3ae609e9"), "009", "8455900500921794", new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e"), "12/16" },
                    { new Guid("0b49bb86-9ae8-4692-813e-2c482abacb69"), "347", "3821466860167256", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "04/26" },
                    { new Guid("0b74a3ad-8360-4299-b77a-e36c73f17afe"), "742", "5584399107717737", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), "12/26" },
                    { new Guid("0b8e4d1b-982a-4016-a59b-84ff3c813a71"), "252", "8322154690498907", new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37"), "01/19" },
                    { new Guid("0bb541d1-f22d-4cb7-b71d-a53e4d912f74"), "361", "7115691211352319", new Guid("41296760-deca-4b2d-a760-5538da32ccb4"), "08/10" },
                    { new Guid("0becd84f-200c-48d7-ab0e-af27ea8784db"), "229", "7194805426965859", new Guid("501ca405-0708-4624-a634-6510fc3c78d1"), "10/19" },
                    { new Guid("0bfdde7a-13d2-4472-becc-b2f5ac2ebae8"), "405", "6331449837197567", new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6"), "01/25" },
                    { new Guid("0c494c08-c77f-464b-b10f-c66900579b23"), "943", "6459347800925870", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf"), "08/27" },
                    { new Guid("0cac3467-39e2-4a55-ba5f-850e1ec72f74"), "246", "4078062338541347", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "10/25" },
                    { new Guid("0d2b99ea-21c4-4809-a256-c9d9ec15b1c2"), "578", "8386455499547621", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b"), "07/01" },
                    { new Guid("0d5e1de2-8127-4854-9d80-2b30cef13588"), "800", "5790626534811177", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "10/18" },
                    { new Guid("0dafec3b-ab7e-4dde-9907-61f4c36448bf"), "918", "6778329579285015", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf"), "08/08" },
                    { new Guid("0dea7564-8f76-44e4-b8c0-3936e83a5474"), "158", "1330328907303567", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "03/04" },
                    { new Guid("0e1c57c1-d539-4ac1-991a-34a53d5c7ffd"), "345", "6890955821123732", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "06/09" },
                    { new Guid("0e3937cf-9101-4146-a910-00e0f5afca0f"), "432", "3080139064288439", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b"), "06/08" },
                    { new Guid("0edb63b1-b564-4e49-9d97-8c5dce87bc43"), "273", "1122476810581850", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), "10/04" },
                    { new Guid("0eec4d6c-0e54-4fad-9198-2058b9da33d2"), "007", "3002743087844838", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a"), "06/23" },
                    { new Guid("0fda6bb9-cecd-477b-a706-d92c97231949"), "901", "7830172245708670", new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb"), "01/26" },
                    { new Guid("0fe764d6-5ac3-4e1d-be2e-4b4b96838af5"), "027", "6071879383372330", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9"), "05/12" },
                    { new Guid("0ffd07a1-bc05-4ec8-9312-473061ea0e58"), "382", "2082088677195941", new Guid("8b031351-f694-4f12-b95c-b4d9076da358"), "06/18" },
                    { new Guid("1005bf06-4567-4253-9542-3c11a275c06e"), "919", "1857711642546862", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "10/09" },
                    { new Guid("1010acab-b807-4cdc-9df7-7c16c47d69bc"), "352", "3510639635273707", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb"), "08/26" },
                    { new Guid("1194e2ac-b491-4132-b138-275ec6889831"), "712", "5193656325748189", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), "04/07" },
                    { new Guid("1254ab9b-a880-4aac-b5fd-852c4c92d4d7"), "204", "5690640474624127", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032"), "11/28" },
                    { new Guid("128b183d-c391-45aa-8357-9a4537de93a9"), "652", "2305239353639565", new Guid("67a0fefa-c903-4326-91fc-981d72b581a8"), "05/09" },
                    { new Guid("13396812-3541-460f-97a5-0f5bbdea97f9"), "299", "1023685858112861", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c"), "06/06" },
                    { new Guid("13462fe6-f216-4e91-93fa-f3f185ef3b0a"), "031", "6976032890443988", new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49"), "08/03" },
                    { new Guid("134a3f93-1dcb-467f-a44c-49376b231723"), "873", "7255301409795627", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb"), "03/14" },
                    { new Guid("13585c4d-6c96-4885-ac5a-7809816183e7"), "159", "2556165532635031", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40"), "09/09" },
                    { new Guid("13620242-18d4-4b84-9706-a7bb39ba51f7"), "689", "7165884954960544", new Guid("21856d76-0810-4123-9f39-8fd468591282"), "03/05" },
                    { new Guid("14213ae7-0501-41b4-b065-d97b9ab39684"), "739", "2877858151179178", new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75"), "11/05" },
                    { new Guid("1476d48d-c410-4ffe-8594-e157f8330a90"), "617", "6085953152882088", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c"), "08/14" },
                    { new Guid("14fa3d92-0903-4361-8e71-7bc670538d7b"), "098", "5262595203118463", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7"), "03/01" },
                    { new Guid("158fd6dd-a031-4150-9518-b02067d85fef"), "154", "5831261832090513", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), "04/02" },
                    { new Guid("15a73682-c8d6-4e1b-a77f-51ff430bdcfb"), "543", "1696271700274904", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), "09/05" },
                    { new Guid("161d4c42-8097-4411-b7c8-256cf3feac5a"), "689", "1268756008418445", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "06/19" },
                    { new Guid("167397e6-c57e-4572-b846-d5984cdd1b3e"), "185", "1874353818370605", new Guid("776bae78-ddd1-4162-b313-91943ab9b893"), "02/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("16fb51be-b0d0-4149-bb23-7350840535c6"), "665", "2479107148335251", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032"), "09/28" },
                    { new Guid("17b43a2a-28d0-4472-a55c-8145db8eb16e"), "231", "4824640645093025", new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63"), "12/27" },
                    { new Guid("17c3c503-1f97-420f-9749-3f2af2f8eebd"), "119", "7826669802433623", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "08/18" },
                    { new Guid("18217de1-28b8-4831-a477-d940ed3c7ded"), "436", "4240265407135101", new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7"), "03/11" },
                    { new Guid("183381af-2ab4-4aa8-9c17-1d49e21e22d3"), "953", "4962186515814265", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), "05/25" },
                    { new Guid("183b771c-12a4-4433-84c0-9b7d1edd7c3d"), "050", "6608273127979795", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), "12/01" },
                    { new Guid("1880df44-1468-4720-900c-962fe5126716"), "802", "8269425025603231", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9"), "03/27" },
                    { new Guid("188d938f-53ee-4e6b-bc6e-8f617f3b0192"), "503", "4465824623793758", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c"), "10/04" },
                    { new Guid("189ad9e6-63fe-4f77-b0e0-2e76d9ed216e"), "763", "8926316354665287", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "02/06" },
                    { new Guid("1958a407-a668-4057-a82b-4aa2424fd3db"), "191", "1366711671027886", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), "05/12" },
                    { new Guid("19f3f5ee-4d05-46b6-8644-cd81f91713d4"), "398", "9347159386419634", new Guid("8959e331-7a84-433f-9378-9aad487e24b6"), "02/10" },
                    { new Guid("1a218373-80e6-4837-913a-ee8d7c42a9aa"), "647", "8501802277727618", new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714"), "01/03" },
                    { new Guid("1a81f018-e9d3-4e6e-9d2d-e7c05f53f5fd"), "134", "6457547286378753", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86"), "06/03" },
                    { new Guid("1a86b639-64fa-47fa-bb3c-f82aeb80701f"), "285", "9924529409305419", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), "05/18" },
                    { new Guid("1acbece6-3171-427e-8748-dc48657df8b3"), "178", "3913155456538738", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34"), "07/02" },
                    { new Guid("1af786f2-13fb-41bf-a4b2-cb75dd16ea91"), "409", "1685383938487240", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), "05/23" },
                    { new Guid("1b776039-1f9a-4ffd-8d81-15a50999757f"), "797", "3925105314986618", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0"), "02/05" },
                    { new Guid("1c4a14fe-d8b5-4468-9185-4e70dae6cb3e"), "271", "9917757382855663", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), "09/06" },
                    { new Guid("1c74da24-4763-4dcf-9447-c7742d7d7290"), "973", "7230372549685019", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9"), "08/10" },
                    { new Guid("1cc5607d-7ecc-4050-a7da-53389f5d541b"), "045", "7116471407595040", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), "03/21" },
                    { new Guid("1ce53677-be27-40ef-808b-d7726f1627d6"), "459", "7371131991374049", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664"), "08/07" },
                    { new Guid("1cf034bc-43ff-4433-a327-5edd2a63dfbf"), "963", "4852939084019923", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), "01/27" },
                    { new Guid("1d44b197-b68a-4689-8cd7-b6cbbf8d9ad8"), "051", "3046380958495858", new Guid("b80d479f-1611-46e2-a055-1de659d203b8"), "12/22" },
                    { new Guid("1eaf5d15-11b1-4b6f-af2c-6ff718f5ae91"), "545", "6142159400308323", new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a"), "11/02" },
                    { new Guid("1f13768a-1976-4728-842f-add4a8e6676d"), "506", "6406419870400993", new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e"), "05/04" },
                    { new Guid("1f7f127b-859b-49ae-8deb-90bebd8615bc"), "677", "4781021195618008", new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757"), "09/01" },
                    { new Guid("1fec9712-774d-461d-995b-6c81ee10e52d"), "316", "3989779701044727", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), "10/03" },
                    { new Guid("208d35e3-39b6-4e1b-93a8-14a0d9ba6c7e"), "880", "3027837725748247", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), "09/27" },
                    { new Guid("210c8216-9308-4f7c-85c7-515d41e5ac46"), "698", "6356051751450625", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), "07/16" },
                    { new Guid("21b5c3aa-0720-48e6-a427-4e93d9674693"), "471", "8159571370685931", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1"), "08/05" },
                    { new Guid("220773a6-d568-49ae-95fa-8f9450019799"), "927", "2084970793079752", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02"), "08/05" },
                    { new Guid("221bcb91-b1aa-4643-a7aa-8b6d1fca83c3"), "470", "6925175504996652", new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f"), "07/20" },
                    { new Guid("224be71c-06a0-40c2-a2fc-22abb56541d7"), "452", "7228715143122160", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38"), "02/16" },
                    { new Guid("2258c208-128a-48aa-9c67-9a3206565e37"), "759", "8147828543960013", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf"), "06/07" },
                    { new Guid("22ce15be-ce6b-4fb1-9087-dc01aa3344a5"), "416", "7558181528265365", new Guid("61fe1433-1b16-4004-8246-4e030b366c6d"), "12/16" },
                    { new Guid("2331a65f-5e01-484a-8b8c-73bf207dd141"), "619", "2558607525547734", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b"), "05/22" },
                    { new Guid("240256f8-adfc-4033-94c8-35cdeeca3444"), "137", "7991328290606036", new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803"), "10/22" },
                    { new Guid("243cf130-833a-457f-9dfa-0f29d2c76924"), "777", "6968961477228520", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), "06/05" },
                    { new Guid("24491269-342c-496b-b54f-df19be94b74c"), "375", "5404626196717157", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), "11/28" },
                    { new Guid("2523f7aa-5556-430a-befe-cca96783c404"), "949", "6755088005360667", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf"), "09/20" },
                    { new Guid("2540c7d0-4a89-4edd-ad6b-fe113fe34822"), "422", "8977623178293286", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d"), "09/22" },
                    { new Guid("258a9a9a-4b77-4f02-8cbc-adf7adde2aef"), "107", "7274752469691104", new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7"), "03/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("25e1dfe5-3d08-4413-8c34-12274f31cc14"), "571", "5319778904450749", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), "09/04" },
                    { new Guid("26342220-5934-4640-a09f-5d12036eedd3"), "101", "6468731559653585", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0"), "11/12" },
                    { new Guid("26b7e6bd-9306-42be-89d3-e67b7c99db98"), "137", "7939955157843744", new Guid("913aac82-79cd-4930-833a-d54464607133"), "07/10" },
                    { new Guid("270c5b5e-133c-43db-820d-a28b14826a3d"), "102", "8784724495233767", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08"), "02/11" },
                    { new Guid("284b9ebf-ecb6-4ebe-8ca7-d9bd0ff3bc8c"), "912", "8529814089348051", new Guid("e698e260-89e1-4c83-b493-1379542f5647"), "09/20" },
                    { new Guid("2884498c-2860-4d5d-a5fe-19b62f5c7658"), "667", "2642255975239919", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), "11/20" },
                    { new Guid("28ecf936-281a-4d45-886d-0dabde75d1e3"), "751", "7295548942726969", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), "01/06" },
                    { new Guid("29032084-6dd9-4279-85d5-e7d6bb39b1a6"), "119", "9035306490845603", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d"), "01/04" },
                    { new Guid("2911b357-e699-4808-9a6e-bba1a407d080"), "747", "9411659040461675", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), "01/16" },
                    { new Guid("2933f02d-9e94-4197-9537-6741fcb39600"), "251", "1556739134362636", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401"), "12/13" },
                    { new Guid("29655be1-0e43-486b-82bb-45b4830bc57f"), "412", "6734130923827989", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664"), "12/23" },
                    { new Guid("2977ae8a-6d22-4323-9ccb-889ca496781e"), "899", "6235335354724401", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf"), "09/12" },
                    { new Guid("298d03e4-64a9-407e-9520-aaf522749134"), "913", "5644247338567278", new Guid("74b3dcc9-46b9-432b-a105-af04273b540f"), "02/07" },
                    { new Guid("29e5fcb8-687e-49e6-933b-053be3b05fad"), "640", "4935074135797773", new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8"), "06/17" },
                    { new Guid("2a24d557-d97f-44d0-8fc8-9d06076c7ddc"), "825", "8840602405504184", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d"), "12/03" },
                    { new Guid("2a3b635b-9caa-4746-8cc7-1db4259703d9"), "769", "1842975659089674", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), "01/08" },
                    { new Guid("2a6f1c81-f6e7-436c-a9c1-dd8ad85456a1"), "180", "1253869965508653", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "07/23" },
                    { new Guid("2a94c1b0-0002-4a6b-9433-335704498274"), "897", "1566309145078171", new Guid("313a1b63-2c0c-411e-a611-28a27b318502"), "03/28" },
                    { new Guid("2b7d58ec-fb14-4408-ba97-6aad5e030a75"), "229", "3229252910754174", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), "02/26" },
                    { new Guid("2b9886e4-f514-4110-b720-7e37f6d01fa6"), "830", "1443266036818139", new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912"), "06/08" },
                    { new Guid("2bb6d916-a721-46f6-a4e1-4654920c6cd3"), "476", "8614708609840243", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "03/14" },
                    { new Guid("2be8b82e-726f-493e-889b-f09a4622d620"), "036", "2544403948256012", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), "12/18" },
                    { new Guid("2c203ea6-bfca-4975-aca1-bc07718479f5"), "368", "3031987290352979", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a"), "11/13" },
                    { new Guid("2c41252e-f471-4158-a3dc-93b118ec1f3f"), "001", "1393409167282086", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809"), "08/04" },
                    { new Guid("2c4d9600-5be2-442f-84b0-c3de86c6d703"), "037", "5993124410920238", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7"), "07/03" },
                    { new Guid("2c9ca6b9-6596-4a91-8659-c4b1783fae10"), "553", "2765381333563114", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), "09/08" },
                    { new Guid("2cc8db62-4bb4-41f5-9a0e-b71c51c2c006"), "505", "2283931103490558", new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f"), "05/09" },
                    { new Guid("2d05ac4c-a38a-4a8f-9395-cf9e4ba22c17"), "521", "2478680929583583", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f"), "01/21" },
                    { new Guid("2deee716-dae4-4635-becc-34c207fc8bde"), "118", "6226293009486403", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf"), "08/10" },
                    { new Guid("2e139956-851f-4487-8983-13d0ad911f7a"), "181", "7025087364731612", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), "08/27" },
                    { new Guid("2ea58cc7-726f-4275-a34e-454e5dce6a4a"), "425", "5531508825296957", new Guid("b6691519-38b6-436a-a19c-602dda7868aa"), "01/26" },
                    { new Guid("2edb3169-25bc-43f9-921c-9720d9a9c38f"), "861", "7040968888281622", new Guid("03f69888-97c1-4626-8453-7ac762327e44"), "07/05" },
                    { new Guid("2f27225c-b39c-4dfc-bc29-51f677ea295a"), "662", "6734998188355960", new Guid("2a7af252-1892-408c-8a62-8885f15e7f65"), "12/17" },
                    { new Guid("2ff99ec6-bd70-4821-a365-77ed0e428334"), "357", "4495211675655633", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39"), "07/12" },
                    { new Guid("300783b2-f204-4616-9cf7-df957e39a2fc"), "397", "1336607369440052", new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7"), "01/02" },
                    { new Guid("3027e213-3413-47a4-abf6-15cd8dd2ea62"), "803", "6165649877407800", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b"), "12/04" },
                    { new Guid("313189d2-144e-4f9f-80b4-9f979d0bebc0"), "829", "1898955907581184", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), "01/01" },
                    { new Guid("314a365a-c5d3-4544-9bbe-b0edf9ee1b6c"), "704", "3369166454860542", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), "05/28" },
                    { new Guid("314f3d77-2ea9-4843-ad26-a774846685f8"), "106", "9226260163672576", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d"), "08/27" },
                    { new Guid("31c4b3fe-f5e8-44bf-8217-a31fbd0f6334"), "880", "4769559911895553", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903"), "08/28" },
                    { new Guid("31c61667-ed2b-4fcb-b26f-addd9979e5ea"), "096", "1413925097712267", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), "01/28" },
                    { new Guid("31ce7426-4d7c-43ff-acd9-c775bece7a14"), "591", "9984480813537470", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "09/06" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("31d5b472-f43a-4258-bc7e-042fc66b95cb"), "739", "8156604687630192", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), "12/03" },
                    { new Guid("322050e2-38aa-4829-82c8-32917e97e339"), "114", "5217499858575813", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d"), "11/14" },
                    { new Guid("3221623b-8b2d-4f7b-93a3-9fd57609712f"), "346", "3609714630148485", new Guid("501ca405-0708-4624-a634-6510fc3c78d1"), "11/14" },
                    { new Guid("3236dbcc-006d-4616-88a6-69412c1a6a1c"), "022", "6769678811590289", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), "06/16" },
                    { new Guid("32c70172-026e-4ce9-a197-33201ef8dd1c"), "486", "2962304610036905", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "07/22" },
                    { new Guid("33246c04-afa5-42db-9ecc-af2a4e1a1168"), "978", "2340852332330962", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "08/23" },
                    { new Guid("334ac392-c165-45d8-a41d-d23fc2dfdf06"), "929", "5017178600093727", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9"), "06/06" },
                    { new Guid("3365d8d3-fe7a-4b92-8e73-76bba268b41d"), "160", "8724885436815082", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7"), "06/27" },
                    { new Guid("345eca71-4f94-4463-9225-42130c40a97a"), "469", "8199106903461043", new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684"), "10/03" },
                    { new Guid("34846ef8-b3e3-4498-b432-d7ba44b17997"), "629", "6500271854461700", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f"), "12/01" },
                    { new Guid("34c73eda-e9da-4bec-b2df-30d03f4db175"), "725", "8862659462537720", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a"), "06/13" },
                    { new Guid("34f116a2-7cd2-43af-a955-8f707784300e"), "566", "8253036706147643", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), "04/01" },
                    { new Guid("34f8acc4-3d0f-4895-a452-b87137345f73"), "999", "6447951881383288", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e"), "10/26" },
                    { new Guid("3535bb35-8b0b-4662-97b3-f81e5a91253c"), "362", "4561337809283126", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd"), "10/09" },
                    { new Guid("356988a5-5ece-421f-a3e3-27b9c422c2dd"), "403", "4646114474332005", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33"), "09/24" },
                    { new Guid("35c69e33-16ac-4230-8ec8-e2350dc38239"), "195", "8172882004602071", new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192"), "08/23" },
                    { new Guid("35f414ef-8961-4b41-8461-f9cdb9a64921"), "136", "5496904828172338", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834"), "04/22" },
                    { new Guid("36201d71-29d4-4a9e-bc87-92320ed5161f"), "902", "1280985712233024", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), "07/09" },
                    { new Guid("363d4f43-88a4-4866-92c5-4a570fafc04c"), "418", "1344333723137624", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "04/09" },
                    { new Guid("3656afba-787f-4639-a29f-b62f5d7ca099"), "135", "5846822046781952", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f"), "06/18" },
                    { new Guid("36c9bb64-75b5-4dd3-bdfc-7728ea997105"), "031", "4154791069000057", new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb"), "05/20" },
                    { new Guid("371a1228-aace-45cc-aaaf-664c736f3ef8"), "663", "2290124059022487", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86"), "11/24" },
                    { new Guid("379db1d6-1fc6-4035-bb7b-58fae415155f"), "673", "6496828852953147", new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8"), "06/24" },
                    { new Guid("37bfa18f-464e-4d84-bef2-23ee4311a086"), "089", "7385681148855482", new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7"), "10/06" },
                    { new Guid("38182e04-cbf7-480e-a5b1-e1acfc8dc151"), "230", "9977603315530678", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6"), "09/02" },
                    { new Guid("38c4fdb3-917f-4f25-a0d9-e527ee52ffaf"), "491", "1489034578056750", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856"), "01/27" },
                    { new Guid("3943e601-4e98-451a-a5b5-48ba2553e7d9"), "262", "7766540093216135", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f"), "01/10" },
                    { new Guid("394dc832-5eff-4302-821e-6ecc8bf31642"), "607", "7793731095815691", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184"), "11/01" },
                    { new Guid("399fb91a-ccb5-4d69-97f8-4aeb321b48e3"), "554", "2800290138238670", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), "07/26" },
                    { new Guid("39d280c7-4d01-4b62-a455-aa1bd5ac7bb0"), "893", "5063141488802734", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d"), "05/14" },
                    { new Guid("3a758911-09fb-4485-a2ac-54a483725053"), "478", "9814877955331937", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91"), "05/20" },
                    { new Guid("3a77ca46-c54d-4352-8a81-2feb9b9ecff6"), "143", "3050116268300168", new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), "09/12" },
                    { new Guid("3ad1a0bd-2fc5-4180-9078-828083693b29"), "539", "2756359672361169", new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), "03/27" },
                    { new Guid("3b106b28-909a-45da-ae16-3e7275f0dc0a"), "249", "3907757251812943", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02"), "12/20" },
                    { new Guid("3b2b0dd9-6256-4be3-836e-b6f59f459cb1"), "836", "3030834831936435", new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), "09/26" },
                    { new Guid("3bab5695-1ef2-4a87-81bd-de5f142091bb"), "756", "6666611564921612", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), "04/09" },
                    { new Guid("3c246384-b6f3-474c-85dc-c03941ceaaf5"), "240", "6539237052557956", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), "01/01" },
                    { new Guid("3c38e36d-f08d-48f4-ac34-3860a9f3628d"), "451", "9491921738882770", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e"), "01/05" },
                    { new Guid("3c963cca-3767-40a2-ba02-c7079a3d5f37"), "747", "2226277390523588", new Guid("ca402be9-4708-4877-ada7-62364da2236a"), "04/18" },
                    { new Guid("3cac36b2-2dbc-4028-a121-37578a2c6301"), "425", "8081752343763790", new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8"), "11/13" },
                    { new Guid("3d3c9a79-4845-441a-b888-df7d52cf5d38"), "310", "2461957004902155", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91"), "08/09" },
                    { new Guid("3dd45172-8d57-4ca9-a9bc-177c91c72241"), "818", "2324383082517002", new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), "03/24" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("3e2c8979-378c-4d9d-a97f-8d82df150214"), "541", "3077658828379378", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6"), "01/27" },
                    { new Guid("3e5be4ee-3003-4831-b311-60f50762515f"), "714", "3219822702257093", new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a"), "04/17" },
                    { new Guid("3f193cc1-ccf6-473d-8f56-d46386d093af"), "351", "1267592935626879", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), "08/07" },
                    { new Guid("3f782910-b2cf-4e1b-8faf-c5dc28e9c36b"), "441", "5232518184511447", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a"), "11/06" },
                    { new Guid("3f9a58e5-57e1-4f40-97dd-17ca1c560b72"), "750", "7400743588819495", new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab"), "09/21" },
                    { new Guid("3fb996d1-4a06-4be2-ad40-4592e93f7215"), "401", "4922292675600873", new Guid("f50dbc58-9b0d-479e-8402-e939027091e8"), "10/08" },
                    { new Guid("3fbb7a85-0257-4f48-b5d7-c1a3fd264550"), "181", "1538309645090938", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "11/22" },
                    { new Guid("3fc0c026-c5cc-463d-8955-d9e96232a846"), "565", "2797792936475796", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), "11/02" },
                    { new Guid("4000ed1f-62de-4181-ba29-6689c9c96baf"), "381", "8720273734680117", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea"), "06/04" },
                    { new Guid("401ecd31-c8ab-430e-a5f3-2a429d0211ae"), "169", "7897532514751758", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f"), "07/11" },
                    { new Guid("4020f3c6-6762-4d2b-a49c-0c22b86704d8"), "233", "4875228825691496", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), "09/18" },
                    { new Guid("4066968e-a083-42a5-90b7-5645f69ae2a0"), "381", "6021911091688755", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184"), "10/25" },
                    { new Guid("4076599e-a2b5-4cd6-9ed0-52941087e96f"), "413", "5527829475998568", new Guid("f50dbc58-9b0d-479e-8402-e939027091e8"), "09/06" },
                    { new Guid("408401f4-72a1-4f59-a6fb-d3a43551afc5"), "671", "6076327342399919", new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb"), "10/01" },
                    { new Guid("408cd376-a72b-4c06-97b9-704e69401bbe"), "855", "5751049974682287", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), "09/05" },
                    { new Guid("40937c20-dcc0-4187-bf99-8f36a9a1fd47"), "526", "4183349236880180", new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b"), "04/09" },
                    { new Guid("40d7f214-a687-4c3e-b0d6-cbcca44c9a48"), "381", "6084786547863092", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856"), "03/25" },
                    { new Guid("40de208a-150e-41bd-adfb-0af3d5e04e75"), "757", "6805732986115914", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), "05/05" },
                    { new Guid("411250b0-fe45-47ef-9bdd-ef98cf803673"), "109", "4544774381200599", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596"), "01/17" },
                    { new Guid("41244fd9-067d-4e46-9751-37f546d31694"), "282", "5134147907835894", new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb"), "09/04" },
                    { new Guid("412e485c-d7d6-4209-afba-8852242db07a"), "249", "2655403813101085", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), "05/26" },
                    { new Guid("413b6ada-ed72-4668-8447-73fb57b3859e"), "372", "4345588477901412", new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), "06/15" },
                    { new Guid("41a0c045-00fe-4cc8-904d-b853453d0695"), "628", "6514420900723951", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26"), "11/28" },
                    { new Guid("420595c6-655a-4e63-9bf3-11ece7e194d8"), "786", "5827340827117693", new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0"), "03/26" },
                    { new Guid("42283238-e782-431f-b7b8-9ce9e5b8171d"), "539", "3076652542087799", new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb"), "03/02" },
                    { new Guid("42727554-5b9b-45ee-aa4b-f7f28c616229"), "956", "6786106428481675", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b"), "02/20" },
                    { new Guid("42b34bf4-1930-45c8-b296-b30493d1aeb2"), "881", "7119048052520336", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "11/07" },
                    { new Guid("4307d879-7a81-4aac-a561-19247b47d8bd"), "684", "2507968569121791", new Guid("082d68f3-3ec8-4587-9852-34cd715f794e"), "06/10" },
                    { new Guid("43462262-c496-4103-b6cc-929de9707c18"), "595", "9913873207028175", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20"), "07/23" },
                    { new Guid("434c9237-5253-44bc-8562-18fae3bb562e"), "364", "6581173680125866", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), "12/06" },
                    { new Guid("43690d1d-19b2-4e59-b7ea-a91e038eb6c8"), "190", "8662603541415011", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664"), "10/17" },
                    { new Guid("43c0c2f7-bc91-4cdd-ba72-88f5360e812a"), "531", "3010285842706452", new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099"), "02/11" },
                    { new Guid("4410b6ab-ab8b-43f0-9d2e-d7cb1c5c8341"), "174", "7706591974530304", new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615"), "07/13" },
                    { new Guid("44244b3c-546d-4a0a-a435-92d294defeed"), "751", "1313074218703539", new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a"), "07/11" },
                    { new Guid("442f00db-cb3f-467c-b850-6d97e664fbce"), "703", "5073421087214878", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede"), "04/11" },
                    { new Guid("44306e98-3c9e-4b12-9086-90028a00a808"), "650", "1149330289645780", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), "09/25" },
                    { new Guid("44412f70-a70a-41c2-bfd6-dd4311ffdd0c"), "403", "2850843974331244", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "07/28" },
                    { new Guid("44808c7c-97d1-411f-b883-905286097ca0"), "053", "5333245616636500", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f"), "10/05" },
                    { new Guid("44ca1c70-be95-4aa8-9671-f1e8df408c41"), "215", "3312918726179107", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), "01/12" },
                    { new Guid("45515f95-62b6-4672-a6e0-5a9b1da0a536"), "361", "8335133835489261", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), "06/18" },
                    { new Guid("4681c2ea-5342-4913-b195-e054271dd8d0"), "172", "5078052878092927", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), "01/07" },
                    { new Guid("46e4f47b-b532-4fc6-a5f0-74f473e0b90b"), "301", "9055127873612361", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "04/04" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("47128f6b-2164-4d53-997d-d7e3812faaa7"), "655", "2823332126126114", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "01/10" },
                    { new Guid("472eac5b-5eb2-4754-8375-ae3af032431c"), "683", "4415469398980160", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), "10/03" },
                    { new Guid("47875d09-404c-4315-aa7e-719da4cb2f35"), "373", "1038547686468974", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6"), "06/13" },
                    { new Guid("48b9bbe0-a30b-43ad-af8d-b9253886da90"), "877", "1171351627156647", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), "12/02" },
                    { new Guid("49c7d1f9-7017-4005-9bc9-79673cbd01ea"), "271", "4838259669113408", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc"), "12/12" },
                    { new Guid("4aae84c8-3f06-4558-a839-36a2000f7507"), "341", "5063142252573499", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b"), "12/27" },
                    { new Guid("4acade2b-0190-4e19-93d2-7cca55c4deef"), "773", "4621558909857074", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd"), "03/26" },
                    { new Guid("4b734f2d-f410-41ac-a10e-6c2572c4abb4"), "088", "9859572854336661", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c"), "09/25" },
                    { new Guid("4b8a979f-aec9-424c-8692-a17aed9492f4"), "993", "8944158873379320", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d"), "03/21" },
                    { new Guid("4bcc044a-d720-4192-a77c-98c05a0d1e68"), "652", "3032862384135754", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a"), "09/14" },
                    { new Guid("4bd29610-6ee7-48c5-865d-9e20d9874739"), "758", "2908108480043691", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a"), "05/05" },
                    { new Guid("4bf06eb3-9378-431d-93ca-0f9b08652af3"), "539", "5912762628483757", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "08/27" },
                    { new Guid("4c9fc2a7-c9b7-4262-b769-0820edfb8759"), "084", "9886232735479137", new Guid("702dc016-070a-4620-818f-b4e492286066"), "11/27" },
                    { new Guid("4cde8f4c-ce7c-4ce5-91c3-8c8b72d12e26"), "509", "7161421446169094", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9"), "05/12" },
                    { new Guid("4d0b2b21-730c-48a1-b3e4-0e4346694e2c"), "927", "8586499537718877", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1"), "12/05" },
                    { new Guid("4e6212da-836c-4b3f-997d-5a827a86768d"), "601", "5862977304277014", new Guid("ad5b9802-88b7-4c47-b138-778817c4050a"), "10/22" },
                    { new Guid("4e73f0f6-d4bc-467d-910d-0207dff8d208"), "235", "2427788594936373", new Guid("afa896ab-be1f-4401-923e-90219b5466bb"), "09/21" },
                    { new Guid("4e9b07e4-ac6c-4696-9061-4988aa240e6a"), "142", "5035521026236827", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f"), "06/23" },
                    { new Guid("4eba7dc9-f335-4df5-9215-b3d90f110cd4"), "489", "9463713738969064", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "09/13" },
                    { new Guid("4ee0acba-0670-4131-89a9-ad48f34983f9"), "910", "6353434043514807", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), "11/03" },
                    { new Guid("4ee8735f-5aa6-481c-b742-c42c4405c7a2"), "023", "9371750580278218", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f"), "10/25" },
                    { new Guid("4f949231-c076-4454-b2ab-c6d138b6b790"), "810", "6498396121739089", new Guid("07ad492d-8647-409f-93a7-b4567c04166e"), "05/01" },
                    { new Guid("500398c5-55fc-45c9-ba0a-1f961f6a9072"), "820", "9007736270476264", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf"), "02/28" },
                    { new Guid("5051f64d-d06f-45ee-9adb-569d7fb092d0"), "649", "8021572809178794", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a"), "06/18" },
                    { new Guid("5057fd3a-cc25-4f14-b532-5d7ff754fc0e"), "504", "1287386430300604", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7"), "08/15" },
                    { new Guid("50c09040-43ad-4789-8d55-f7b2ec0ad79e"), "881", "2552925584151193", new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a"), "07/10" },
                    { new Guid("511f28e2-83bf-47aa-8d2e-59b9d666270a"), "652", "8175106370655455", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d"), "11/26" },
                    { new Guid("5168a55b-94e0-43cd-ba81-9ad6e947721e"), "453", "1839390150640536", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01"), "02/06" },
                    { new Guid("51821aa7-d0f3-4fc7-81ae-8aa584ceabc4"), "628", "2626667994969562", new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387"), "07/22" },
                    { new Guid("522580ed-24cb-4f18-9d6d-3df0f859ba03"), "790", "5110402199598985", new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35"), "06/09" },
                    { new Guid("523f907a-5fa5-409a-b5b2-1e42b95e3331"), "685", "9940127931836638", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), "01/04" },
                    { new Guid("5251878a-8357-4cf7-aa08-05ee06a2d2cb"), "951", "1389949140812236", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809"), "04/13" },
                    { new Guid("52ba54a4-de10-4854-a5b3-4d04b24f307c"), "423", "7553659658441142", new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b"), "01/20" },
                    { new Guid("52f8d115-1ecb-4e88-829c-e731a816ca98"), "731", "5938672035664190", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b"), "06/24" },
                    { new Guid("53538523-265d-48c0-8725-9794dd822394"), "038", "2013966492665123", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9"), "01/12" },
                    { new Guid("53664475-3fc5-43d7-a4ce-d58cb81e44d5"), "755", "4678746042979863", new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce"), "05/27" },
                    { new Guid("54207640-089a-4dd6-bad0-ce37823a3e4d"), "266", "7730054912967533", new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387"), "10/01" },
                    { new Guid("5437a1bb-ba7b-42cb-8dd7-3c77eeeb0027"), "233", "9151820235123355", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), "05/05" },
                    { new Guid("5487b624-7221-4767-8adb-35b6d3e71353"), "845", "1508626797338117", new Guid("776bae78-ddd1-4162-b313-91943ab9b893"), "07/21" },
                    { new Guid("548ce766-ef16-4795-9ee9-3562f7ffdce8"), "894", "7153288223310786", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), "04/04" },
                    { new Guid("55aa9230-2324-4c0c-948b-d0f995fb6cd0"), "264", "3686956134857006", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef"), "06/13" },
                    { new Guid("563475bf-2beb-47ed-8ec5-9d146092a03e"), "793", "2046977364600092", new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb"), "10/23" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("569e9271-f188-4bbf-a7dc-e0a8f76501b1"), "886", "3145104073594724", new Guid("69335634-41ba-4400-a54f-e27126ae5352"), "08/04" },
                    { new Guid("56a132e7-f45c-49f2-9838-684e98a0dc48"), "690", "8072044943767110", new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197"), "12/05" },
                    { new Guid("56bc2ad2-6222-4083-9c61-df51e6089677"), "670", "9713565923275753", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), "09/26" },
                    { new Guid("570f2e1e-6bf3-4ad6-a615-91fe6f2091e7"), "502", "6566787494283745", new Guid("69335634-41ba-4400-a54f-e27126ae5352"), "08/22" },
                    { new Guid("57859c36-70f8-4ded-8e31-a83370763344"), "544", "2778750251958788", new Guid("18971e31-ee25-41fd-bafa-129547aefc10"), "04/06" },
                    { new Guid("57ca7186-a93b-4869-b1c5-0a5302a1be4d"), "619", "1973936123020748", new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63"), "08/12" },
                    { new Guid("57fceb04-0fdc-400e-b745-6d93461d4866"), "878", "6708094990273094", new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb"), "02/21" },
                    { new Guid("58008da8-ca03-429b-8845-1cdff3d77201"), "590", "6156049197117936", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34"), "12/07" },
                    { new Guid("58276016-6a25-4d35-8361-81c9b2f04609"), "043", "5329416407188894", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e"), "02/17" },
                    { new Guid("5895d0e2-16cc-4df0-8ed6-510008fa89fc"), "834", "6884817273181291", new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb"), "03/18" },
                    { new Guid("58ab09b1-c1f9-4b81-9d52-020aae2c4ab5"), "510", "2327824209998102", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), "10/10" },
                    { new Guid("58cae2eb-fe84-4407-a8da-4f22d0f319d3"), "869", "8013985271010099", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "05/13" },
                    { new Guid("5927bf8e-cbf4-4e0f-af76-2507bab9d613"), "472", "7021008820452925", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40"), "09/24" },
                    { new Guid("595a83d4-d190-44e4-ba22-087d80fae540"), "320", "1487945932098972", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "01/20" },
                    { new Guid("59b5f67a-6a3f-4eb4-b23b-f580204187c5"), "785", "4667114114193689", new Guid("99e79b31-2994-4fd2-956f-0294e124da96"), "01/24" },
                    { new Guid("5a47e2f0-81e7-42fc-b756-22ed5224ad45"), "511", "1778017808117515", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "05/21" },
                    { new Guid("5a74480a-59b0-4c90-99ec-86b5207ca7ee"), "380", "8412136258001712", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106"), "05/15" },
                    { new Guid("5a82b803-25ad-4089-ad2d-d9f47ec4e9be"), "167", "5661365105005401", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), "02/17" },
                    { new Guid("5b00e053-0391-4730-a028-85f13d9c9464"), "393", "5254835283082804", new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912"), "05/09" },
                    { new Guid("5b1bba0e-0bc7-4767-bc38-a32f598d17c3"), "707", "1190442290307883", new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), "01/08" },
                    { new Guid("5b7351d1-93d7-4aa4-a690-07243b62c028"), "698", "6894919897736781", new Guid("19c67f23-dfcc-4228-91b6-db840755a673"), "11/02" },
                    { new Guid("5c05eab4-bf63-4052-9088-7d13218dd619"), "879", "5570718899357401", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9"), "02/26" },
                    { new Guid("5c1d5570-80b4-4b09-aa4f-783330841762"), "783", "3866732742709190", new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1"), "03/01" },
                    { new Guid("5cebe762-d514-4bf4-be62-edcf16fe2179"), "412", "5982784961791769", new Guid("ad5b9802-88b7-4c47-b138-778817c4050a"), "01/26" },
                    { new Guid("5ced2910-125b-42fc-bcaa-cd75de6277f9"), "500", "5561588899405305", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26"), "01/19" },
                    { new Guid("5d15534f-f8ad-4fa1-9dd0-7f2c24eb11cb"), "318", "8978231666134849", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "02/20" },
                    { new Guid("5df9114b-5768-44b6-9dc2-ae1288c5136a"), "578", "9710570385398109", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b"), "11/10" },
                    { new Guid("5e3ab4b0-4673-4e3d-8a84-df9ad36b9ca8"), "011", "1699458369890301", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), "04/23" },
                    { new Guid("5eaf8b90-3dc8-48c6-b493-2a620cb0bad5"), "374", "2429120315591719", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "07/24" },
                    { new Guid("5ef4ba15-40a5-4b12-9d87-e91ea5f7b0e1"), "264", "3936410382440882", new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553"), "02/05" },
                    { new Guid("602be2fc-9c50-429d-b639-3bcf0de8f90c"), "913", "6731421757336352", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a"), "08/07" },
                    { new Guid("603c964b-67cb-4e15-93f5-ffecd5d23050"), "866", "7748655357143445", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c"), "08/02" },
                    { new Guid("604c3de5-5040-45cf-afa9-44b808c3f293"), "861", "2771682707247305", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "03/13" },
                    { new Guid("605cea70-577f-4973-aee6-a73e492b6a56"), "578", "8874877813074414", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9"), "10/24" },
                    { new Guid("60f1a0af-e406-4e96-a94c-52d1a4ec9a8d"), "124", "5626142051199339", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40"), "01/17" },
                    { new Guid("623d5b8d-96d2-4e76-b17f-d0e6782085c8"), "963", "8420475282957525", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2"), "12/22" },
                    { new Guid("6252e5e9-515a-46b3-b7e5-69a3f1f84718"), "846", "9694183170375426", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), "09/05" },
                    { new Guid("6273f940-a1ea-42cf-8ba6-20d5d13cf953"), "982", "1331326661572036", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), "03/24" },
                    { new Guid("62c804d3-ca58-4077-b783-df3696bb4131"), "922", "9890582288938884", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef"), "02/27" },
                    { new Guid("6326277e-8359-4d9d-886c-e417f3ef9e95"), "935", "1724297362226067", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a"), "05/08" },
                    { new Guid("635baa49-606f-46b3-8e03-18c2253ea278"), "616", "4174512453313787", new Guid("049182ed-f5e3-469d-9878-36594ec23de3"), "02/21" },
                    { new Guid("63e9df2d-fded-4507-bb25-8903ebc10a4c"), "655", "5168301392194507", new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f"), "10/03" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("644ca321-6f0d-43b6-9bef-bb1387a0491d"), "844", "7314096544235905", new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007"), "11/25" },
                    { new Guid("64b30a50-d514-4b14-ab70-2838cc935564"), "533", "3700677145826379", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), "02/13" },
                    { new Guid("64c7609c-5ddf-4f66-bbb2-74d27968cd50"), "298", "5058515422399272", new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094"), "06/03" },
                    { new Guid("64dac6cf-1afe-4f03-90ef-45be0a622403"), "386", "2666168367293915", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f"), "10/10" },
                    { new Guid("6564803f-73f7-4fcf-b88c-46d645c585ac"), "081", "7929409485046918", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), "10/16" },
                    { new Guid("66d49dc4-8d94-42c2-8097-a4a591ec7035"), "711", "9234848738032735", new Guid("24292576-82c4-4a01-961e-e050d58bf4a8"), "01/20" },
                    { new Guid("66dac0e4-943a-4f1d-a5c1-19a48bec1df5"), "865", "8097303832593750", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596"), "02/12" },
                    { new Guid("6710d2ff-cba4-433a-824e-52e45a664a67"), "065", "1644748596235423", new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17"), "05/18" },
                    { new Guid("6729a7be-61d8-4f13-8ea4-7f879f53adca"), "522", "2851071382402576", new Guid("edf37002-a546-4d28-acd9-2614759e640d"), "01/05" },
                    { new Guid("6798b52b-f1a8-48b4-832c-e348d6faf1cc"), "242", "9163913562118988", new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b"), "01/26" },
                    { new Guid("67ac32cb-8655-4126-940b-47dbb1976cc7"), "960", "1995841759850374", new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1"), "03/13" },
                    { new Guid("67b07e0c-c397-4634-82b7-fd12082dce1a"), "889", "1262974427606040", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1"), "09/22" },
                    { new Guid("67bbef73-a768-4343-ba59-36a49d767925"), "825", "9237504558865487", new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714"), "03/17" },
                    { new Guid("67c75387-db15-47c9-8ec0-accb34db8aa7"), "686", "3183978095188080", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08"), "06/03" },
                    { new Guid("686dbca6-9588-4e3e-b44e-0291aa3e36f4"), "814", "7098596373255152", new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d"), "09/27" },
                    { new Guid("6891349a-a0bf-46db-b970-17076f39dd50"), "132", "6003063112910496", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea"), "02/05" },
                    { new Guid("68b15c01-d1f3-4c7c-9158-3d420feed89b"), "290", "9278288711355291", new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007"), "04/26" },
                    { new Guid("68fd4aef-b87a-493d-890a-8cda5ef5a5e7"), "413", "1075229850771852", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1"), "09/23" },
                    { new Guid("69b336c0-d5ee-40bf-8abd-6e9c5c75dae1"), "728", "9978288735848451", new Guid("07ad492d-8647-409f-93a7-b4567c04166e"), "09/18" },
                    { new Guid("69ea1dd4-c4b1-4c3d-9921-f052883de9e0"), "515", "9086842052366384", new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197"), "06/06" },
                    { new Guid("6a036bc0-ea74-42b0-809d-15a601d358ca"), "328", "6286246631867200", new Guid("93fc11aa-1d50-4309-844c-1154f207d374"), "10/26" },
                    { new Guid("6a60b83d-bd05-4575-a4b0-ff31afe0baa0"), "794", "7402722245721578", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), "04/19" },
                    { new Guid("6a8cddd0-d35b-4f21-b469-d591c34e487c"), "224", "3599974451973694", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd"), "03/15" },
                    { new Guid("6acacfe7-71aa-49fc-83e6-c4738ee594b4"), "346", "7956307382866989", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef"), "04/06" },
                    { new Guid("6b77269a-2413-4d72-834c-0574d7d77bad"), "180", "2985547466505896", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969"), "09/12" },
                    { new Guid("6b7ba7a4-20a3-4b4a-bfc1-8f3b756a3b2d"), "912", "4569093392164058", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), "12/08" },
                    { new Guid("6b9c7474-dc61-44e9-9cfd-5a9b078911f6"), "346", "1309752608936715", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032"), "07/12" },
                    { new Guid("6bbc0c96-b912-4e30-a375-c49574c752bc"), "116", "7818506768855073", new Guid("8959e331-7a84-433f-9378-9aad487e24b6"), "06/17" },
                    { new Guid("6ca7fd6c-a4ce-4ea8-819e-1d1957b7fa0c"), "130", "4917844322248815", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "05/15" },
                    { new Guid("6d4665f4-661b-4c59-ad8a-cc3ffe50ae34"), "585", "5906992611844101", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f"), "08/19" },
                    { new Guid("6dfdee5d-1642-478f-83a8-9381143f1bd1"), "583", "8822665713317778", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d"), "09/24" },
                    { new Guid("6f1a32a0-525b-4bdc-bb8d-0eb2107d5680"), "564", "2463460453094672", new Guid("0f432380-a89c-4564-a477-a1ed20795e01"), "02/04" },
                    { new Guid("6fa41c07-d798-4744-bca3-955b549a246f"), "498", "2171714414222493", new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), "04/27" },
                    { new Guid("7014e33b-3514-44da-9eae-03b4a69cda75"), "989", "1324050396869382", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "11/03" },
                    { new Guid("709be646-8acc-4972-8ef0-5045d8e20acd"), "330", "5114806702877985", new Guid("68d876f2-c855-4a3a-b244-f66443d9d833"), "04/13" },
                    { new Guid("715df082-d6b9-48c1-81e2-1e6ae10147f2"), "077", "3805934784118241", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "07/28" },
                    { new Guid("716d3522-84c7-4095-8ec3-ccd59ca3cff3"), "764", "4414766370019502", new Guid("19c67f23-dfcc-4228-91b6-db840755a673"), "06/15" },
                    { new Guid("71761db1-d69d-4c70-bc86-fa7edac32fc8"), "303", "3245996508571064", new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e"), "11/08" },
                    { new Guid("717fbfbd-e2ab-4729-8e9c-9442953e7291"), "759", "1339914442993270", new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9"), "06/26" },
                    { new Guid("71b14246-6140-4ec2-a92e-54abb032297e"), "866", "4192358439775296", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb"), "10/11" },
                    { new Guid("71cdb05b-efd6-4170-afc0-005cb622e54d"), "832", "5820167092846553", new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e"), "07/08" },
                    { new Guid("71f61340-08b0-4cf9-acfb-6f3b3f6eda7d"), "815", "4472831547761676", new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2"), "11/07" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("71ff8dbd-31e6-43a6-a1b7-3a8505e37897"), "812", "8083883790273711", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), "03/04" },
                    { new Guid("7217011c-a1b9-4bcc-aa50-1fe53a4cafc9"), "836", "1920708854294679", new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5"), "02/28" },
                    { new Guid("729367e2-9321-413d-92e4-196df30d9787"), "343", "6945201333699291", new Guid("776bae78-ddd1-4162-b313-91943ab9b893"), "06/25" },
                    { new Guid("72c41712-b0ee-44d8-bb03-f4f11e5d0cd2"), "388", "1977327073052846", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1"), "09/02" },
                    { new Guid("72d02f06-84f8-4de5-bd45-027bd1f0d10d"), "161", "2089380038496874", new Guid("edf37002-a546-4d28-acd9-2614759e640d"), "06/27" },
                    { new Guid("72fb119a-6008-4e13-85fd-292e7ce75d8d"), "058", "9980617432431695", new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d"), "11/21" },
                    { new Guid("736cdd0f-36f3-4710-a1ee-64ec056fe10f"), "715", "9910984433518410", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e"), "12/23" },
                    { new Guid("739eae7c-8720-4512-b760-c838846dec44"), "022", "6850831543824592", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "03/06" },
                    { new Guid("73f6d620-d0cc-49f1-8aca-eeaff7aff39f"), "204", "2041650956952522", new Guid("51274356-5ef0-4e46-a687-716d200f49e1"), "04/11" },
                    { new Guid("740a1dd3-32fd-494d-8968-a30e70226bd4"), "154", "2674048421312275", new Guid("03f69888-97c1-4626-8453-7ac762327e44"), "06/23" },
                    { new Guid("740d668f-bfb3-43a1-8717-aecde0e38d55"), "911", "9314745477875384", new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2"), "11/25" },
                    { new Guid("741370d7-41be-4cef-a61b-d69e588fec35"), "154", "2566486820770600", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33"), "08/09" },
                    { new Guid("749728fe-b4d3-434c-893b-104e7147cc36"), "362", "5705446773055397", new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8"), "08/21" },
                    { new Guid("74d5c32c-1e73-4867-9883-5dccc887427f"), "763", "4416258531413860", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7"), "12/03" },
                    { new Guid("7507a73d-2f36-4e01-a4ef-12b95bbf81f9"), "995", "5040521218859715", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), "01/23" },
                    { new Guid("7555e3c0-1571-485b-ad72-5dd75386096b"), "700", "9161670249596971", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede"), "08/23" },
                    { new Guid("756d247d-8476-466f-a9a9-b272dad9e0b5"), "575", "2447318938600130", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401"), "03/03" },
                    { new Guid("757e93af-5c2b-4f94-9f2d-4c64c8979ffe"), "646", "5353855473437854", new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552"), "07/25" },
                    { new Guid("75e59b9b-16a8-413c-8a08-822edbf68543"), "764", "1970443565061737", new Guid("049182ed-f5e3-469d-9878-36594ec23de3"), "06/18" },
                    { new Guid("762c8f66-6842-43b5-b915-92607978d422"), "017", "7203551021764373", new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27"), "01/06" },
                    { new Guid("765d331c-456b-4b16-908b-5cf5d1ed1f3c"), "734", "7669913683867990", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), "12/06" },
                    { new Guid("769ad6e6-c819-4d7a-8ecf-43f3dde5b91c"), "695", "4153589901941234", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078"), "11/18" },
                    { new Guid("76a3cabd-08d2-4d04-9d69-e5d154ea7770"), "568", "6053423938771985", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), "06/17" },
                    { new Guid("76f6f2bb-e59e-47de-90f1-9b419fc1700e"), "669", "7350541394474041", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39"), "07/09" },
                    { new Guid("76f86af2-04f3-4b70-8c02-c0b3b7dab1ea"), "570", "2025223194799821", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "06/22" },
                    { new Guid("774b0c4f-80ef-4e99-8d0b-884e71eab88e"), "954", "2387527405419122", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01"), "06/08" },
                    { new Guid("77d3e0ad-0daa-4261-acb1-f540950c3bae"), "226", "4637608910052719", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7"), "01/21" },
                    { new Guid("78599c9d-c79a-4095-a1e1-77b3103d7464"), "939", "4575802301608238", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "02/14" },
                    { new Guid("78a50248-e4ab-48f0-b97d-643d20cdfcd7"), "241", "7248242319751919", new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099"), "09/01" },
                    { new Guid("79300fa5-6abe-40b2-b2b5-4534220ee20b"), "236", "8100944518222988", new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d"), "01/16" },
                    { new Guid("796537b5-13b9-413b-a379-768e3504fd41"), "947", "4600166054145871", new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead"), "08/24" },
                    { new Guid("796836c7-0a76-4f41-b19b-967ac91fdd7a"), "177", "2355905400531915", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf"), "07/05" },
                    { new Guid("79cddebd-aef6-46c4-8502-7c34e615fe33"), "337", "1527984311233376", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c"), "02/13" },
                    { new Guid("7a34e85a-fcc4-4fa9-87c9-13ead13c500e"), "854", "1620304236790917", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0"), "04/09" },
                    { new Guid("7adcdce0-47d6-4919-ba12-9876f0c740ca"), "541", "7908150130757347", new Guid("2a24280c-6e79-420d-bd19-903d44c42081"), "07/22" },
                    { new Guid("7ae1b4cf-cb37-4e5e-975a-6eddac7baf5a"), "948", "6155665189606373", new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374"), "04/09" },
                    { new Guid("7af340ba-04e4-4e1d-a643-1e870d41a6ef"), "805", "9666220905406739", new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a"), "08/08" },
                    { new Guid("7b4a7be4-9c8b-4869-b781-4fa6b6e62504"), "286", "1741892063276889", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc"), "10/07" },
                    { new Guid("7b7473c1-920b-4c54-9dff-dd45111579f6"), "570", "9551195437584554", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b"), "09/16" },
                    { new Guid("7ba1b243-c984-47b6-be28-37fcbf83e4b3"), "990", "4676402441978497", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), "11/15" },
                    { new Guid("7bdca045-3221-4599-a78d-7b1a9d45bda9"), "659", "8853220000018623", new Guid("313a1b63-2c0c-411e-a611-28a27b318502"), "01/26" },
                    { new Guid("7bf1f1f1-7d44-423a-878f-7e6d1260dd5c"), "062", "7848948962440819", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "09/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("7c1185d9-6a1d-4c42-9162-059779198757"), "193", "4775271415735546", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085"), "03/01" },
                    { new Guid("7c29de37-79f9-4bee-b0a4-d684c77660dd"), "137", "6270655098579607", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee"), "04/19" },
                    { new Guid("7c751864-cd63-48ad-825c-35ff4b33b495"), "348", "8480393434183573", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f"), "12/03" },
                    { new Guid("7c9f84aa-1e3b-4e8d-9104-fcf362a795eb"), "468", "5711354744886092", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2"), "12/20" },
                    { new Guid("7caeba93-6874-4252-bdc5-3c52740c6a6b"), "083", "8045920268470620", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), "08/06" },
                    { new Guid("7cc04840-58b1-4303-bc85-163f287f2c8f"), "726", "9492412174515724", new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093"), "02/11" },
                    { new Guid("7da23f82-8d0d-43e8-bd27-154fc0257248"), "144", "1587123157771114", new Guid("53792862-da15-45a1-b0ef-d025a7608026"), "04/26" },
                    { new Guid("7ebf7316-edf8-4db9-a5cd-8a78e821a1d9"), "695", "2755050909978707", new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), "11/16" },
                    { new Guid("7f306ee6-8993-4cf1-98b0-905b1503c26e"), "966", "8575315643214038", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), "05/21" },
                    { new Guid("7f46e999-3396-45d0-8299-ff23c36098c0"), "129", "9948681988403291", new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e"), "11/08" },
                    { new Guid("80cc0eda-925d-4339-a303-11d1488ec270"), "019", "3480875394030033", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669"), "05/17" },
                    { new Guid("80da0caa-9aae-437d-bd91-9ecb739cd8c1"), "319", "3282377003736429", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb"), "05/01" },
                    { new Guid("81af2ff8-8de9-4062-9325-8b493426c002"), "835", "8050619423836859", new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37"), "09/05" },
                    { new Guid("81c56d0b-c6d1-4ae4-809a-73975c2f8529"), "818", "8506932054551801", new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), "11/11" },
                    { new Guid("81d789a5-11ba-4d93-a7aa-71d2f1c629de"), "157", "5096486392341976", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0"), "08/27" },
                    { new Guid("824b81e6-f932-4117-8530-e8c796a9702a"), "330", "4622641256715650", new Guid("61fe1433-1b16-4004-8246-4e030b366c6d"), "11/04" },
                    { new Guid("824e43e8-85e4-43dc-80b4-e6d0104ae056"), "305", "4569476020388029", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01"), "12/02" },
                    { new Guid("82617a78-44e3-4c10-983f-563022e0b15e"), "319", "9962466827846733", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08"), "04/08" },
                    { new Guid("8274743a-2293-4ae5-b3a6-9770ad8ac973"), "811", "6562803329915769", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7"), "09/17" },
                    { new Guid("828a98d2-3457-4932-bfa8-7f3c7b4ef98c"), "399", "4573000476891467", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27"), "03/13" },
                    { new Guid("82d0f0e3-d34f-4ba6-99a7-7c6876e870dd"), "847", "2776106995299707", new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a"), "03/16" },
                    { new Guid("83647a39-0a9f-49e2-9540-e7cb936ca3b9"), "176", "9959742959982822", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2"), "08/20" },
                    { new Guid("838439b0-20e0-4244-97fb-fa9270b165d0"), "255", "4076370633019591", new Guid("c184664b-be88-432d-9f74-e8476badaa13"), "12/11" },
                    { new Guid("83b40c3d-f4ae-48fe-b98a-0192de18053d"), "727", "6567429893149110", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606"), "02/14" },
                    { new Guid("83c7d9df-a614-4bc5-a321-ac451c2c4b1c"), "210", "1752443668551692", new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058"), "06/04" },
                    { new Guid("842044b9-8f0e-41f5-b8c2-3584ca500833"), "109", "6663248860658929", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "03/11" },
                    { new Guid("842a520e-854e-4d69-b865-27c715a99b51"), "346", "3251403021100192", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27"), "10/12" },
                    { new Guid("8592d9aa-8bb2-4982-8e4e-64523520ad0b"), "649", "9362942391982473", new Guid("e698e260-89e1-4c83-b493-1379542f5647"), "11/21" },
                    { new Guid("86192bdd-09f0-43e9-beb9-de6a7955afde"), "958", "2631405339412200", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051"), "05/21" },
                    { new Guid("864ede66-fad0-4704-ab78-7d4e418bf376"), "428", "4632081088364474", new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553"), "08/18" },
                    { new Guid("86e3001a-a9f5-4801-848d-a84624d34321"), "278", "7622695602674810", new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), "12/02" },
                    { new Guid("87ff5228-e56e-4731-8d7b-479055587ecf"), "443", "9287724800856089", new Guid("776bae78-ddd1-4162-b313-91943ab9b893"), "02/11" },
                    { new Guid("881634d0-db54-4ab7-8aa7-54c42f041af6"), "554", "1230837059525022", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), "05/19" },
                    { new Guid("8852b8be-77ce-4aa4-b36d-03e745c8fb19"), "588", "6840199999303217", new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce"), "12/01" },
                    { new Guid("88590c35-5942-4422-bbd3-294cd1d61be0"), "704", "7768941233204306", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "07/03" },
                    { new Guid("894fc56e-4c0c-4d67-9a1c-8deb54518f41"), "783", "3844098735479784", new Guid("65012c66-d07a-40f6-9789-b100201359c2"), "10/16" },
                    { new Guid("89624fe5-9458-4962-97f7-4723358ed57d"), "911", "2553464118767795", new Guid("afa896ab-be1f-4401-923e-90219b5466bb"), "07/22" },
                    { new Guid("898ccc99-f19f-4539-a6ea-d06fa4fffff5"), "639", "8534770844483245", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), "12/27" },
                    { new Guid("89da1f4d-d3e3-4645-85aa-891d57397186"), "544", "9529632758282230", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "04/23" },
                    { new Guid("8a724e32-0cbb-49ff-8b39-63832912c72a"), "235", "8497354397262255", new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094"), "06/06" },
                    { new Guid("8af0f99c-a448-44d1-8a2b-53825c8d441b"), "095", "1820892202456068", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea"), "07/22" },
                    { new Guid("8b1ac5ea-ee74-44d6-8b30-9b2d9ff0b8c2"), "029", "8739949716147815", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "04/05" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("8b5aa977-93a2-4c5b-b2b0-467614a81e90"), "372", "2211975973576244", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "10/28" },
                    { new Guid("8bd6d61d-351c-4896-8f71-51038209b578"), "587", "2268938438272201", new Guid("74b3dcc9-46b9-432b-a105-af04273b540f"), "01/16" },
                    { new Guid("8be801a1-4350-47f9-82c6-3e9211bda93d"), "930", "1103743847526408", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7"), "03/24" },
                    { new Guid("8c755c2e-cc14-4edc-b5ce-8727375b9ff0"), "818", "9193867881021333", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), "10/06" },
                    { new Guid("8cce7a20-34b9-4287-bd20-0144e38fb25b"), "091", "7444637907759481", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7"), "04/04" },
                    { new Guid("8d0f2160-aed0-4890-ac1e-f92ad7cd2cbe"), "114", "5541390197359735", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), "02/09" },
                    { new Guid("8d275575-6328-48d4-a361-e405f85ffa1b"), "448", "1752036937530300", new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700"), "06/01" },
                    { new Guid("8dbeac0b-0186-4784-8839-59efa5dc904c"), "816", "6495990604881779", new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a"), "09/18" },
                    { new Guid("8e806289-5a56-4cfa-88c9-e4093d21e2ac"), "286", "8949609298932735", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078"), "11/24" },
                    { new Guid("8ee5482a-a22c-4309-adfc-d97dc83b8ded"), "724", "1494835036479741", new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985"), "12/07" },
                    { new Guid("8f48b872-ac43-42c8-9cf3-98dab7720b8d"), "829", "5457977692114798", new Guid("8861729f-4a56-4d39-bc73-6365e353facd"), "02/19" },
                    { new Guid("8f546bcc-0b4b-4298-be97-c045b383adc0"), "852", "7744116460579584", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), "11/24" },
                    { new Guid("8fe7e371-bc71-4432-b584-b9eb2c0bd7f1"), "109", "8706309786128013", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969"), "03/05" },
                    { new Guid("9008fd2b-14b8-4c30-a303-065b99a020b7"), "792", "4711872762866108", new Guid("049182ed-f5e3-469d-9878-36594ec23de3"), "02/18" },
                    { new Guid("903200d9-f27d-4897-aac2-b78f1d7ea4e2"), "900", "6170369977411451", new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615"), "02/19" },
                    { new Guid("90397b92-16af-4f15-b2c6-b36538b5d7a0"), "308", "5121985499794813", new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865"), "05/28" },
                    { new Guid("904b92bc-0c9d-47eb-b9ce-cd67866c3236"), "895", "8853903791314394", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "09/10" },
                    { new Guid("907b90c5-a4d7-4f70-a9bb-c5bb6cbf15f5"), "907", "3358259426458520", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2"), "07/27" },
                    { new Guid("9099ded2-5b30-4e2a-800b-074439fc601f"), "950", "7249691112745653", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9"), "05/05" },
                    { new Guid("90ddb68b-4718-4c62-82e8-e38d417fc0f9"), "443", "2200634677302952", new Guid("ca402be9-4708-4877-ada7-62364da2236a"), "02/23" },
                    { new Guid("91bbb5fb-459c-4320-93b0-afac7e3655c1"), "608", "9914287185105710", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef"), "12/15" },
                    { new Guid("91bdaba1-d1d5-43ce-ba7b-214a83570dc0"), "730", "6749188526431168", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf"), "10/15" },
                    { new Guid("926cddfa-4e37-4cbc-b00b-93d14ddd2baa"), "538", "7270475802145332", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f"), "05/13" },
                    { new Guid("9365184c-22ce-4593-9314-640e10d05daf"), "320", "8660705866427432", new Guid("501ca405-0708-4624-a634-6510fc3c78d1"), "11/07" },
                    { new Guid("941b3c54-5f5d-4e77-8d22-f291bfe862e9"), "333", "7190936275397167", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), "12/04" },
                    { new Guid("94229943-4e92-4a8e-bdeb-c740dbf5f6f0"), "275", "8821165223543824", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40"), "01/18" },
                    { new Guid("943760f1-0c68-4b2f-a4f2-1a53d5bf28d6"), "982", "4927962376313645", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "08/03" },
                    { new Guid("9485d655-ecb3-4b1f-af70-069edb6afe21"), "105", "7140271304423684", new Guid("f4943944-5289-42df-aed1-a6281dd934db"), "07/16" },
                    { new Guid("948c69dd-1cf5-4f5f-9bf2-23ee37bf7e78"), "071", "1813324192294665", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c"), "11/09" },
                    { new Guid("95797593-0a9f-4465-9b5e-da386735147d"), "483", "6089679193013337", new Guid("edf37002-a546-4d28-acd9-2614759e640d"), "02/11" },
                    { new Guid("95a1e34b-4f8d-4593-9a22-87467cfadae1"), "587", "9431891817427385", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f"), "06/18" },
                    { new Guid("95cd235c-5cd1-4db2-9ef1-4073979f4652"), "416", "8311225706337455", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b"), "05/17" },
                    { new Guid("96133d0f-a533-465d-805a-324207c98725"), "743", "9361506322515124", new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9"), "12/27" },
                    { new Guid("964341ce-0fda-428e-a959-fb38a9b41e3f"), "475", "6365509711029916", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), "01/13" },
                    { new Guid("964b2d88-1bb9-4cb3-91df-2146e4396827"), "764", "6260572905855769", new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192"), "09/03" },
                    { new Guid("970fb08e-27b4-445d-bae5-15157bb75ee3"), "533", "9310359588246084", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903"), "02/13" },
                    { new Guid("97123bf2-c0a4-495d-b9fc-a815077cd1d5"), "954", "9365635471162195", new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a"), "06/09" },
                    { new Guid("97341141-f87c-4a9a-ad5b-29da3d2a634a"), "954", "3421337400815933", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d"), "01/28" },
                    { new Guid("97b4b4ac-bae9-4243-ad5b-328a396f28ff"), "089", "5917338101230795", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), "08/12" },
                    { new Guid("980949a9-a8a4-446b-8fc6-242dac65305a"), "137", "5353627510116511", new Guid("67a0fefa-c903-4326-91fc-981d72b581a8"), "03/15" },
                    { new Guid("989e0b52-e337-41c2-a754-625f4f4c9ec6"), "667", "3334835965855450", new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c"), "06/04" },
                    { new Guid("98fb207a-6e78-480f-aeb0-9bdb39ced566"), "468", "9402498514690134", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c"), "04/12" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("99185d24-f652-451a-9ba2-d17faee4c348"), "292", "9962685351795416", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "09/01" },
                    { new Guid("993814b4-3415-40c1-9171-75e293507127"), "762", "8235773578493946", new Guid("68d876f2-c855-4a3a-b244-f66443d9d833"), "06/16" },
                    { new Guid("995b520f-3dce-4167-aa3c-dcdd8d6d7d55"), "020", "6534788911283085", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38"), "06/17" },
                    { new Guid("99766257-f4a3-4f78-93c6-a869c28a1a6d"), "314", "4635058054715579", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a"), "11/03" },
                    { new Guid("99cc040a-a836-40f4-81db-2f8acd6305f9"), "620", "9624126090246658", new Guid("8b031351-f694-4f12-b95c-b4d9076da358"), "12/08" },
                    { new Guid("9a3ae893-4a53-4880-bc9d-f09bbdfb76bf"), "329", "3300633842089373", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "05/08" },
                    { new Guid("9aac2f52-9069-459d-82dd-9327a8f8da1d"), "685", "1475734053029355", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38"), "12/08" },
                    { new Guid("9ab0a558-6137-4a3d-bac1-963621a0c831"), "346", "5197929726005670", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), "11/17" },
                    { new Guid("9ac3278d-777c-4374-9c04-aa1879d85637"), "186", "2179662040852755", new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e"), "07/07" },
                    { new Guid("9b0643aa-9fba-49e4-885c-554ca8887e6e"), "720", "8404911583957247", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39"), "06/08" },
                    { new Guid("9b4f0ddb-cc1b-4362-a0db-08ade20d7d9f"), "108", "7062424286536274", new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5"), "11/11" },
                    { new Guid("9c67e212-1257-4acf-bcd5-c8a45798161d"), "069", "5627264963661354", new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5"), "06/16" },
                    { new Guid("9cb20ff7-f278-4ca3-b88c-8efc81d11a1a"), "917", "3655537326716037", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969"), "06/02" },
                    { new Guid("9d3f3f10-72f3-408d-b533-8f795652d932"), "386", "2502481521182526", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb"), "11/20" },
                    { new Guid("9d64878c-ca14-428b-8825-2e4f2424a5eb"), "891", "8983258198215923", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292"), "05/21" },
                    { new Guid("9dfc7265-309d-4232-bccd-2d1c87d8289d"), "144", "8641280098773676", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809"), "05/24" },
                    { new Guid("9e11c034-cb6c-4df4-a9fb-3e45c24924a0"), "634", "8590690165896127", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "07/08" },
                    { new Guid("9e1b4fa1-d4bf-4996-b986-0ae64fc564e1"), "073", "2353476101828182", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), "02/09" },
                    { new Guid("9e503c5b-fab7-4212-a032-375624ba5a17"), "303", "8213569649358821", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a"), "02/22" },
                    { new Guid("9ed3667d-2c36-4349-8601-d3018df89195"), "540", "6856583708278652", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "08/02" },
                    { new Guid("9f019afa-285b-4438-ad6a-402173d5d810"), "229", "3353467188680821", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), "12/22" },
                    { new Guid("9f05f62a-c520-491c-a755-fba81b31cff6"), "027", "5254119126945188", new Guid("913aac82-79cd-4930-833a-d54464607133"), "08/13" },
                    { new Guid("9f9ab6d0-ba9e-430e-bc27-084474457d30"), "735", "2717456710589847", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), "10/22" },
                    { new Guid("9fc58934-b712-4a53-95e7-846f51b053b3"), "192", "6048998993708816", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf"), "12/23" },
                    { new Guid("9ffb9806-a0e8-48d0-8ae0-5da7ee305e60"), "227", "6486421576105637", new Guid("24292576-82c4-4a01-961e-e050d58bf4a8"), "01/26" },
                    { new Guid("a03a6493-1a8c-457a-82ad-e046cc47b337"), "552", "9558157144566041", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6"), "06/11" },
                    { new Guid("a04a24b5-8a7c-4ecb-8a9d-1b3a2e84d2bb"), "536", "4548639524011613", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834"), "01/03" },
                    { new Guid("a08d3560-ce78-475e-b5b0-1de4e39421a3"), "168", "1549090434515977", new Guid("c184664b-be88-432d-9f74-e8476badaa13"), "07/26" },
                    { new Guid("a0ee8a86-6e89-4af7-a0b6-cc2c7cf80514"), "019", "1134200044820648", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91"), "06/13" },
                    { new Guid("a105ef19-3817-4176-a5ca-d516ac0f92b0"), "059", "9106969230349209", new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9"), "12/02" },
                    { new Guid("a157ee75-0255-49d6-a77a-5033c678bd16"), "216", "6362523842087603", new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9"), "08/11" },
                    { new Guid("a1589a42-79d0-4a0a-8c3d-cc9e8aa72e46"), "911", "8690458553977506", new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49"), "12/26" },
                    { new Guid("a15afa4e-281d-434d-a059-034b16c90083"), "292", "3013972802458565", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de"), "01/11" },
                    { new Guid("a18e6fc9-7635-409b-bf65-c905d01217f2"), "829", "7357765186519914", new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245"), "03/16" },
                    { new Guid("a1a9b361-c712-4ac4-894a-9d3b242152c6"), "571", "1066446182362723", new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803"), "11/24" },
                    { new Guid("a1b5a7fa-1d5f-441e-9a63-6d34997236ba"), "230", "6784338953794262", new Guid("ca402be9-4708-4877-ada7-62364da2236a"), "03/07" },
                    { new Guid("a1d2e4b6-af95-4181-9611-891c8cfe8eb5"), "501", "1831873558893639", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98"), "11/17" },
                    { new Guid("a2191708-d7d7-4dd3-84d9-714ee9c332d2"), "308", "1924831468202098", new Guid("f4943944-5289-42df-aed1-a6281dd934db"), "02/26" },
                    { new Guid("a228730b-6792-4cb4-a7a6-623ce91e10e7"), "188", "7163058132326296", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), "04/27" },
                    { new Guid("a262751f-236d-437d-ad0f-0303d814f7d9"), "834", "7901421466008984", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), "05/25" },
                    { new Guid("a2b7569c-3796-411f-b0df-c9eb36d69246"), "523", "6547447423003854", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), "04/05" },
                    { new Guid("a2cddbd7-6b1d-4f71-a48f-abe04388c629"), "072", "1146189711643985", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), "02/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("a31dd893-f342-4424-80ea-0631a508e0b3"), "252", "4330786798197850", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "09/13" },
                    { new Guid("a33f2a65-c1ad-48f7-a970-59c83c44fa49"), "918", "9912975777529647", new Guid("21856d76-0810-4123-9f39-8fd468591282"), "02/19" },
                    { new Guid("a36ec0b1-6ae7-41e7-af71-b785ad3f2bff"), "158", "2371949246273637", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9"), "05/03" },
                    { new Guid("a3cea5b0-2331-44b4-841c-a723317cbf7b"), "022", "5911987997185439", new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7"), "06/12" },
                    { new Guid("a409be8f-7277-4a35-bb1e-e00e476b23df"), "705", "2425233910285439", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43"), "01/02" },
                    { new Guid("a42b7c6a-72d7-4fdd-9464-4a8db622b3ea"), "667", "8857769160345368", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9"), "04/09" },
                    { new Guid("a43a5d46-98be-4e53-88dc-df69d8fc6d23"), "825", "9815837570928306", new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337"), "02/17" },
                    { new Guid("a4485b63-7843-47a9-9ec3-214a4cf860a3"), "232", "3381325720544225", new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700"), "09/04" },
                    { new Guid("a4493bf8-695b-4c6b-8cb9-c4c9b757dc1a"), "540", "8077832196461320", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), "03/23" },
                    { new Guid("a4502fbc-daf6-4c14-adcd-ab282481f13a"), "092", "3069192884231988", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809"), "10/07" },
                    { new Guid("a4b1190f-012e-40cc-822e-316dfe8fe013"), "962", "6692597359811384", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664"), "11/28" },
                    { new Guid("a4e4fe1d-30c2-41a8-9a6b-2bc28cc833ce"), "295", "3614609610057887", new Guid("702dc016-070a-4620-818f-b4e492286066"), "01/03" },
                    { new Guid("a4ee5029-9cbe-437b-8339-cb6841f0e0f1"), "450", "7910472564164399", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "05/17" },
                    { new Guid("a50d879b-8f97-476d-9629-86d192670ac8"), "194", "3003553012480736", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), "04/06" },
                    { new Guid("a55ae412-ba50-42de-9d00-7a4d0808286f"), "321", "9829769703440818", new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8"), "08/10" },
                    { new Guid("a5ebef70-179c-405a-afe9-c455a37519a0"), "847", "8281435452788761", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c"), "11/02" },
                    { new Guid("a758487b-2276-4c52-b5a8-f6c8f3918643"), "914", "6945558083227137", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e"), "08/16" },
                    { new Guid("a7895bef-af20-4b06-b38f-282d67d9016c"), "424", "1080157467735591", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b"), "07/18" },
                    { new Guid("a84ae912-302d-4b15-85d0-1f63de381915"), "638", "6379915061511966", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), "12/13" },
                    { new Guid("a8a88e9c-1346-4733-a8b0-95ad6cd70930"), "391", "8905345759729562", new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63"), "11/08" },
                    { new Guid("a8d8e409-d787-4281-b9a1-b88208a35f12"), "523", "7370609721736818", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea"), "09/21" },
                    { new Guid("a8dc2471-4383-4031-9f18-e3cc1dc265f3"), "781", "1059622992387509", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), "04/03" },
                    { new Guid("a8eb91b4-1dda-4e41-806d-c044cebf197c"), "727", "8054150750609044", new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911"), "09/15" },
                    { new Guid("a95fa5cc-40d4-477a-bdbc-d6761662cf6b"), "406", "9335551379432627", new Guid("049182ed-f5e3-469d-9878-36594ec23de3"), "08/08" },
                    { new Guid("aa2680e8-2748-40c2-9973-ff7caa3d5533"), "451", "9589182787516847", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596"), "03/17" },
                    { new Guid("aa893030-851b-4564-aa1e-51419fbe7737"), "061", "4658894073248250", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), "01/17" },
                    { new Guid("aaa08651-b744-4e1b-bf95-71ad4a06d256"), "615", "8495965919928493", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f"), "04/11" },
                    { new Guid("aaa64f91-67f8-4ad7-8ce3-7c8c2ee20f83"), "545", "3854922951580619", new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b"), "07/26" },
                    { new Guid("ab064313-fe42-4ce7-b3b8-8464043f3aca"), "310", "2803436499468871", new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d"), "01/06" },
                    { new Guid("abb64743-164c-4567-883a-2bbf00894acf"), "223", "9104135587709373", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6"), "05/04" },
                    { new Guid("acd0f573-b803-4c90-9fc1-8dd393ad1353"), "886", "2715343043641168", new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7"), "01/24" },
                    { new Guid("ad4e85d2-248e-46db-afd5-5ec46e0f7833"), "115", "9392897959162612", new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd"), "05/18" },
                    { new Guid("ad5cb5dd-67d5-43f5-9e05-f4befe050755"), "881", "7019893639069069", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9"), "04/17" },
                    { new Guid("ad6a08e6-8995-4295-9abe-824de5babb7c"), "828", "6717507218604290", new Guid("88a14b09-1988-4979-b812-aa42d93d737b"), "06/24" },
                    { new Guid("add9edfd-0c61-4366-a0cb-5e4e51063402"), "153", "1331559404033897", new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803"), "03/27" },
                    { new Guid("ae0fd0e0-812f-469b-9841-a4800175c40a"), "607", "5193183576575690", new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e"), "08/23" },
                    { new Guid("ae150d8d-8ae3-4b27-9cb7-ce15f961dc22"), "110", "7079033313007631", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "11/09" },
                    { new Guid("ae1a2597-9c66-47f5-83e1-2235f164796d"), "179", "2404077646794586", new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a"), "11/20" },
                    { new Guid("ae5bc493-f93c-4d0a-9976-e16dc0f683b5"), "687", "1862216517025844", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), "10/02" },
                    { new Guid("ae61af65-ae06-440b-9024-d73483c4af26"), "240", "1949608888891745", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c"), "01/08" },
                    { new Guid("aeb716da-c1b5-4ffb-8c9a-9d4d915bbc9a"), "142", "8782451982665415", new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d"), "06/27" },
                    { new Guid("aec5c902-6267-4c1e-b119-79f14b054cad"), "694", "8981438275060495", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), "10/10" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("af654dba-2f7a-4738-b934-830f84b10367"), "058", "6990995617959969", new Guid("41296760-deca-4b2d-a760-5538da32ccb4"), "11/02" },
                    { new Guid("afbcde1d-e0c0-4ef8-b7d0-b5ecc20ffda3"), "017", "6124871989323559", new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40"), "07/21" },
                    { new Guid("afd7e12c-d83d-472c-8170-ee133ee5f4c0"), "794", "5607472043367014", new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e"), "10/01" },
                    { new Guid("b001dee8-3796-431d-bb50-d771d6bc803f"), "243", "9753862068784435", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6"), "03/26" },
                    { new Guid("b0b27afc-7473-429e-b20b-22f06d038d5a"), "537", "2064765032644374", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), "08/16" },
                    { new Guid("b18cfc04-e8f8-46de-aec6-08f16c3d5ff6"), "029", "4949117662384160", new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552"), "01/08" },
                    { new Guid("b2542858-b1fc-414f-89f9-93ded2679e97"), "645", "1242135584069742", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3"), "12/28" },
                    { new Guid("b2588050-d94e-4042-9bcc-32440aa0f416"), "213", "1344008896121774", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), "10/24" },
                    { new Guid("b328f19b-f10d-4ea2-9aeb-b341bfce4af6"), "917", "4564618882466970", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d"), "05/23" },
                    { new Guid("b39aa998-2329-4cb8-8f73-0041b9e948b1"), "694", "9328559212751330", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f"), "08/03" },
                    { new Guid("b3cbef79-a320-413e-9c50-f8d4043d6557"), "198", "6280382330487608", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032"), "01/19" },
                    { new Guid("b5336da7-1761-4ea8-9202-b0976707a6ef"), "152", "3653578146767396", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), "02/26" },
                    { new Guid("b566557f-3025-4da9-bd92-95a55141f47f"), "170", "2478876805675312", new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328"), "08/25" },
                    { new Guid("b5991f12-86ae-4fbf-8ba8-c1c450d3f89b"), "476", "3122942959263048", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34"), "02/23" },
                    { new Guid("b66620ed-aa6a-49f7-afb1-d74747e84e26"), "062", "7742915278360525", new Guid("0f432380-a89c-4564-a477-a1ed20795e01"), "05/24" },
                    { new Guid("b671c826-5116-4a89-9450-2eb5b8eb6366"), "716", "4226173446055058", new Guid("93fc11aa-1d50-4309-844c-1154f207d374"), "10/05" },
                    { new Guid("b6cda4ea-df4c-4e2f-b090-3621620ce634"), "917", "7834850648882339", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011"), "04/17" },
                    { new Guid("b6ff28e1-dccc-49cd-9429-b6eb2fadcdf3"), "344", "8242894324645293", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08"), "03/05" },
                    { new Guid("b808b3cb-93e5-4d7c-af2b-5e68dffcfee5"), "414", "8619200751159870", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), "01/17" },
                    { new Guid("b81a6508-799b-46ff-b158-14685ebaecc0"), "101", "4647624570826972", new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9"), "05/26" },
                    { new Guid("b822169f-68fc-465b-845c-ecf8e88cd05e"), "766", "7275344978276528", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6"), "12/19" },
                    { new Guid("b884c913-c3d9-4624-b2e7-ec22d968689f"), "708", "1861305061859789", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), "05/13" },
                    { new Guid("b8bb49b2-5cbd-4dd3-96c5-fcad1a6a5028"), "749", "6053071716270852", new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), "12/24" },
                    { new Guid("b8e17855-e1db-492e-b3e3-404748f5668b"), "388", "7877649824586307", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669"), "03/11" },
                    { new Guid("b8f26cac-42e3-4cfc-af95-60071661e060"), "366", "1596415719172490", new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27"), "05/15" },
                    { new Guid("b906e39d-3c70-4154-9bd7-7e09724aac98"), "272", "7037586820580981", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33"), "02/21" },
                    { new Guid("ba781cbe-b764-4e56-a60d-b2904b463ebf"), "310", "2970629408138455", new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803"), "02/18" },
                    { new Guid("ba9bdc7e-9967-482d-a7ff-fc3bcdc07258"), "297", "5185527548723812", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7"), "10/17" },
                    { new Guid("bab68245-e5e3-434f-b209-6fc2e9c7236b"), "926", "7948109210258732", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "04/21" },
                    { new Guid("baef253a-f9d2-41a1-83a9-ca8403465127"), "395", "5872118828620641", new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093"), "06/11" },
                    { new Guid("bb040aaf-9da0-4195-b37a-7fe282b0d3d1"), "051", "4677725646853301", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf"), "12/23" },
                    { new Guid("bb6c8fd9-c6eb-403a-b671-879d310305e4"), "946", "3417943913757035", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0"), "11/27" },
                    { new Guid("bbbdb667-6476-4082-95fa-1ed55d7c7317"), "258", "3432953894406267", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "06/23" },
                    { new Guid("bc108d0f-870f-4d67-bd27-3411c76006fc"), "005", "1464358263571191", new Guid("db79945a-0e64-4c97-801f-a38a1e357d12"), "01/03" },
                    { new Guid("bc4d5bd2-d236-4e32-82e8-6c0df50082ab"), "177", "6705876548829156", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), "10/15" },
                    { new Guid("bcb45ccb-116d-40e6-bbcd-936cb6691bb2"), "961", "5607236702436838", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0"), "09/07" },
                    { new Guid("bd38825b-c2b9-48fd-9dba-569a64f5e4c1"), "040", "1528621145114734", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c"), "03/12" },
                    { new Guid("bdbf2425-8948-442e-a8c9-9714da4129b3"), "793", "1433134163421197", new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f"), "06/26" },
                    { new Guid("be31b06c-ec62-4a10-afff-b63f8383900a"), "931", "9558961665100693", new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6"), "05/01" },
                    { new Guid("be4f8333-2adc-46db-a08f-22791f153854"), "837", "2682247288393530", new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0"), "03/01" },
                    { new Guid("c017accb-4672-4370-9933-54740c01762c"), "209", "7148617371152996", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572"), "01/24" },
                    { new Guid("c0b4995c-7b7b-4772-a26d-0077178b838d"), "166", "1127683693972716", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0"), "01/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("c0d54f0d-e752-4202-b834-23aba9169168"), "916", "6518661278756797", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "12/28" },
                    { new Guid("c0d61ee2-8ab0-4801-940e-967297305272"), "581", "9546346293975389", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26"), "01/19" },
                    { new Guid("c10b7f5b-dc83-4889-a0a4-6b45042ad80f"), "738", "3165565900476717", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807"), "06/10" },
                    { new Guid("c118ad18-5a2d-4844-ac68-a135ebf568ce"), "921", "3068484651330475", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "10/07" },
                    { new Guid("c13accfd-312f-4192-b02f-9b1901803732"), "306", "2570961541304163", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef"), "07/02" },
                    { new Guid("c175b9dd-09d8-46a0-a31c-b4d0f258a25c"), "605", "9430423914595133", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1"), "09/20" },
                    { new Guid("c191db1e-245a-4777-a1cd-0a6330307ec2"), "344", "2021793192699422", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "04/24" },
                    { new Guid("c1923d71-d90d-485f-947a-dd3bcd05389d"), "617", "4635231230154282", new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865"), "12/21" },
                    { new Guid("c1bceada-00d0-48c2-8778-02aaa088413c"), "851", "6013418472904990", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a"), "11/08" },
                    { new Guid("c22821cd-e22b-4ec3-b09a-49668eda3a15"), "742", "1797323569498851", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), "07/14" },
                    { new Guid("c2de9714-00fc-401e-9e37-0ea3164165e9"), "710", "1854860465607258", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf"), "06/19" },
                    { new Guid("c2f05932-0759-4e20-a386-94f1318911f3"), "871", "4426230228284209", new Guid("6e90baa7-8b75-4108-acaa-210af704a12f"), "04/04" },
                    { new Guid("c43e4e85-8c14-4b06-9425-84bc244a6102"), "964", "3173245693255891", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c"), "10/01" },
                    { new Guid("c4456c8a-6604-4d1e-8fdf-6c62c3ab40af"), "843", "5941782872600163", new Guid("2a7af252-1892-408c-8a62-8885f15e7f65"), "10/05" },
                    { new Guid("c54889f5-536a-467f-b812-e707a0576ef0"), "592", "1243810391577513", new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684"), "01/20" },
                    { new Guid("c560a04d-2b98-4ba4-b6e4-1ce7e2499291"), "797", "3494607320129897", new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b"), "06/21" },
                    { new Guid("c5731ec5-088a-45e5-9d18-a13fee8eb854"), "916", "6043725607825027", new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058"), "03/28" },
                    { new Guid("c5d51cac-9c46-4b69-abbd-1345a69d32a5"), "949", "2083866932439299", new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35"), "09/24" },
                    { new Guid("c6207a11-734c-4102-83b3-ddaf90d09a15"), "957", "9125473313923878", new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9"), "11/02" },
                    { new Guid("c66fc0b3-fcc5-4d49-8442-be9ca3092538"), "128", "5218096561606518", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33"), "01/24" },
                    { new Guid("c67643f0-0204-4baf-831e-2d526bcefaa7"), "494", "9272402674847047", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38"), "03/17" },
                    { new Guid("c6913632-ae85-460b-9aff-941f769f4142"), "644", "5352117564834803", new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab"), "07/26" },
                    { new Guid("c6b8735d-1f01-4d77-b962-bbdf8f2eeaa9"), "606", "8153276300421763", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4"), "09/08" },
                    { new Guid("c740bebe-0617-45a4-a559-33708b1c0db0"), "432", "7737826976209685", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6"), "09/02" },
                    { new Guid("c78716fb-028c-40dd-92a8-bf5fef034da3"), "253", "5870166603242444", new Guid("a0c72d91-dc13-4995-848c-613286a462f4"), "07/05" },
                    { new Guid("c7f72ff9-0140-4527-8bc2-1dba0b805e63"), "049", "5439199936265971", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3"), "11/02" },
                    { new Guid("c8027f15-22ed-4e24-8076-c51372ec6f05"), "824", "4699920867215726", new Guid("b6691519-38b6-436a-a19c-602dda7868aa"), "07/05" },
                    { new Guid("c82792cc-2064-431d-90ef-9c54a2f751a7"), "222", "6335669753852731", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), "01/02" },
                    { new Guid("c8cc99f1-74f9-4c4e-b991-53360bd9d2c5"), "646", "5336397745427953", new Guid("c184664b-be88-432d-9f74-e8476badaa13"), "03/27" },
                    { new Guid("c910d3f7-6334-4e8f-a062-6ed081f481e6"), "568", "5477382680745776", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20"), "05/21" },
                    { new Guid("c96743d1-3f9f-49d9-8b5c-5880a57911f0"), "813", "1878636574090689", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c"), "07/20" },
                    { new Guid("c96f2767-3dba-4d86-bb1a-fd40b8517fc4"), "705", "9528000466731372", new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb"), "12/16" },
                    { new Guid("c972d10c-abac-4996-b7b2-24d5afbf3c68"), "867", "2580220315883364", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596"), "03/28" },
                    { new Guid("c9a90cff-28b4-4909-bb68-384b1bc13e8f"), "606", "8205966706600497", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813"), "08/04" },
                    { new Guid("c9de1cb9-0152-4f97-b76f-0329fdf2dc6c"), "462", "9042096646208719", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6"), "02/13" },
                    { new Guid("ca73444e-c816-48b6-b53e-6b741c1c3caf"), "107", "3451353680946279", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078"), "01/16" },
                    { new Guid("ca7676df-270a-4b36-992e-f431a93824c4"), "541", "8850130822541774", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a"), "09/20" },
                    { new Guid("ca8eb80b-a1b1-470a-b565-db2c6dfdc2ee"), "949", "1868827400043981", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb"), "01/25" },
                    { new Guid("caeb153b-2352-486c-b289-776e9a8df795"), "718", "2584866934898251", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7"), "10/21" },
                    { new Guid("cb766e6c-f26a-499c-a721-0d9322ef85e9"), "502", "9528523307990215", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56"), "10/09" },
                    { new Guid("cb9954c0-b972-404f-8acc-380f0c44333f"), "192", "3841097837033622", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a"), "07/19" },
                    { new Guid("cc0510d3-51dc-492c-b7ea-25bc9b17ec64"), "288", "6961966586509706", new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf"), "12/25" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("cc122000-04f4-4388-81a3-cb16c19b0f7d"), "749", "8188829355309112", new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985"), "06/12" },
                    { new Guid("ccb2994e-c7b1-4b4a-b1c5-1a35d796b17c"), "766", "6576930497472203", new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3"), "02/07" },
                    { new Guid("cce773dd-1d2c-4c04-bd9b-7621310ef6db"), "907", "3064128946245527", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f"), "11/10" },
                    { new Guid("cd9cb0b5-9562-4962-b0fd-968329ef8979"), "434", "3913357507789486", new Guid("de7d9783-5299-4552-b426-e13c1b4a4995"), "06/09" },
                    { new Guid("cda0540b-89fa-40b3-a518-2b0b70052018"), "059", "9766169906822309", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f"), "12/19" },
                    { new Guid("cdb8fffd-7d0c-4879-b5c6-b3c26bf18dd1"), "891", "2302856147053033", new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f"), "05/24" },
                    { new Guid("cdc4e3ff-3d1e-4d59-ac02-480c01109840"), "328", "1857900058767838", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01"), "07/22" },
                    { new Guid("ce15d267-7d68-4491-ad26-e3c2a97c1ee8"), "263", "7033045797583203", new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d"), "11/15" },
                    { new Guid("ce54da6b-b87b-454d-ab72-af40748229a9"), "440", "9784412783994968", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "10/20" },
                    { new Guid("ce6891d3-bc3a-4317-904a-59a607635fdb"), "583", "4755148736303093", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), "01/15" },
                    { new Guid("ced6684b-9b49-4f04-add4-8bcfb2965180"), "737", "5321149332257500", new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead"), "03/03" },
                    { new Guid("cf04ffe0-f7b9-4959-bf95-093a6540100f"), "309", "7183059077417519", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef"), "01/05" },
                    { new Guid("cf4de86e-9e69-4878-bdca-72ca54e8f00f"), "525", "8513238553169277", new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7"), "09/07" },
                    { new Guid("cf6eaf48-cca7-41ba-9dd1-1d295d4e0592"), "098", "9817898336325028", new Guid("082d68f3-3ec8-4587-9852-34cd715f794e"), "12/08" },
                    { new Guid("cf901816-d483-4560-8a34-dc69b5968436"), "897", "6542368329739026", new Guid("6e90baa7-8b75-4108-acaa-210af704a12f"), "01/06" },
                    { new Guid("cfdc9fde-b848-4e65-9405-073d6449fa83"), "181", "6037819071262513", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56"), "01/24" },
                    { new Guid("cffb630a-43e5-4fe8-ac1f-0c938c76e219"), "567", "3056039246372633", new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6"), "09/24" },
                    { new Guid("d00ec180-d315-4f94-985b-62db1f885bed"), "283", "8108682860475083", new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c"), "09/08" },
                    { new Guid("d08f6461-ed6a-4467-b41d-53f6663543ff"), "144", "3642543699525134", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c"), "07/24" },
                    { new Guid("d0c2206a-ae61-47e7-bdc2-1c2814faa81d"), "179", "9231483330371552", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b"), "12/20" },
                    { new Guid("d0c4b87f-5a5e-40b1-b755-231ef6b5fba9"), "496", "7392646744873961", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401"), "12/12" },
                    { new Guid("d0e6f0f5-0103-47ef-b55e-aead114173d8"), "996", "1207744908470247", new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1"), "12/06" },
                    { new Guid("d200efa8-6867-4385-803f-1ba7a0fc16c0"), "479", "8078599532719899", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "08/04" },
                    { new Guid("d32cfbac-a9a9-41ff-add5-1449e09a0ecb"), "526", "9184261136696842", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6"), "05/27" },
                    { new Guid("d3f44e2b-e0b8-4550-b80d-316ad66e8e92"), "698", "6583215861177809", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360"), "03/09" },
                    { new Guid("d40d8041-8474-4072-ab91-3822c8df31c2"), "322", "1443208207841358", new Guid("a0c72d91-dc13-4995-848c-613286a462f4"), "12/24" },
                    { new Guid("d42c1bf3-248e-42c0-861a-3c156d647500"), "870", "3434617217834728", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20"), "11/06" },
                    { new Guid("d4701f53-a2e4-427f-9c74-6e34e767b248"), "774", "8376848825919967", new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7"), "11/16" },
                    { new Guid("d48dde1e-eaf1-490c-a4c0-7be2f68ded0f"), "558", "9900912191444569", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856"), "08/07" },
                    { new Guid("d4e15ca1-ed50-4e73-9757-298b9574b184"), "041", "3311931127500967", new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a"), "01/06" },
                    { new Guid("d65749cb-e22a-4e4c-ad4d-37b485147a46"), "353", "9570695638029477", new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079"), "06/11" },
                    { new Guid("d65be929-d5b7-4444-bc7a-63bca85f18c2"), "681", "4769218617495983", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f"), "05/18" },
                    { new Guid("d695b402-2bc7-4d66-8314-802af6f9dced"), "993", "4812182279576401", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b"), "10/13" },
                    { new Guid("d6e0c0b8-023c-4759-a263-1b82bf985d26"), "582", "5539126677494485", new Guid("702dc016-070a-4620-818f-b4e492286066"), "08/08" },
                    { new Guid("d6ed5a87-cbd8-434f-a867-81ff0012defd"), "740", "6811827679838829", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8"), "07/28" },
                    { new Guid("d77bc153-0086-48b2-8722-046eb6637be3"), "578", "9475790511680953", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), "02/18" },
                    { new Guid("d77ece53-6bc5-4936-9bdc-cf2ae171560e"), "612", "1085566768224803", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a"), "02/01" },
                    { new Guid("d7905200-f676-45e9-91c3-0ede42d02c32"), "120", "6637198659949648", new Guid("93fc11aa-1d50-4309-844c-1154f207d374"), "01/08" },
                    { new Guid("d7b38202-de06-402c-a293-b0e96901da1d"), "079", "2059644898231227", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856"), "11/11" },
                    { new Guid("d7f85437-bfb8-4409-ad72-5ff80a31e705"), "066", "7179579264612426", new Guid("f4943944-5289-42df-aed1-a6281dd934db"), "08/08" },
                    { new Guid("d89e256d-0cc3-4e9a-aa9a-2fffe2a5ce6b"), "207", "9131647437624803", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa"), "10/04" },
                    { new Guid("d8c99f42-3fd4-49dc-891d-112e5ea6e876"), "818", "8007449875548633", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f"), "06/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("d8faa14c-b49a-4e91-b4aa-734f8e3a16e9"), "478", "3187027454986496", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12"), "05/16" },
                    { new Guid("d9211260-87a4-40fb-a6bb-5761ac0def79"), "654", "5618944408755806", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86"), "11/04" },
                    { new Guid("d94ab4ba-3f3a-4f7b-8774-8f70eca8205d"), "765", "9210156454474943", new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374"), "10/24" },
                    { new Guid("d9b7c059-9b19-40e1-802a-bb6731da5e56"), "612", "2213687802745171", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12"), "02/14" },
                    { new Guid("d9ce8bf9-1776-4676-9d1c-8166607dcb78"), "766", "5864130198866784", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0"), "09/24" },
                    { new Guid("da556717-d082-4c6c-9591-719b62424f7f"), "454", "2620113933164159", new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e"), "03/21" },
                    { new Guid("da692ac4-52e5-4d41-acc6-2c08e6e6e296"), "566", "2790663465620529", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd"), "07/08" },
                    { new Guid("da6b0c6c-f954-4b39-bac7-a59ce371b048"), "437", "3072565625898276", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), "09/01" },
                    { new Guid("da72506e-a716-4637-a728-d9499127fea1"), "961", "9853223245972107", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20"), "06/07" },
                    { new Guid("da8b7c02-c29b-49df-9a13-5afd3492e327"), "168", "6242178503166840", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "02/23" },
                    { new Guid("db0d6ec2-4ad8-4310-81dd-e613771b488e"), "421", "3536495020275825", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), "01/04" },
                    { new Guid("db1198f5-e72d-432d-845f-03d13b0bdb22"), "391", "5400860606607595", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "08/25" },
                    { new Guid("db35f85e-b4bc-4919-b6ed-7600b3ef0e43"), "506", "4306845034934352", new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75"), "04/25" },
                    { new Guid("db7494bf-bb7a-4ec6-9c64-29225d7b7936"), "636", "9838891098943716", new Guid("8b031351-f694-4f12-b95c-b4d9076da358"), "04/09" },
                    { new Guid("db7b9635-cd3b-4ec1-b365-680bac8148d7"), "728", "2573256842899756", new Guid("0a6753e1-2434-4328-852e-3458edfcd329"), "01/07" },
                    { new Guid("dbc66ba3-caaa-4197-93e3-da5ef93ebb2c"), "429", "6985198579638596", new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6"), "12/26" },
                    { new Guid("dbf661e7-5e63-49e9-8fc0-4eb59ab2e6f4"), "495", "7916066202670295", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "08/05" },
                    { new Guid("dcaf465d-73cb-4551-91a9-4872962f5d39"), "874", "5181270202426385", new Guid("ce376eab-8569-4f9a-8425-51e1310948af"), "04/13" },
                    { new Guid("dcf7551d-fa3f-485c-80f6-18477564ea33"), "116", "1246738008017262", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), "01/15" },
                    { new Guid("dd3251ea-fdbe-4568-b5e6-1467c1b69196"), "708", "2742142211083084", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8"), "05/26" },
                    { new Guid("dd78351e-1d09-4f82-b2d8-cb329823bc36"), "672", "9983897737437340", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e"), "08/22" },
                    { new Guid("dd804c91-1ff5-4dc5-a31d-cb4b71437581"), "083", "7531114747620604", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), "04/10" },
                    { new Guid("dddded25-89cf-4998-8598-02f34f14e355"), "999", "4684124929824790", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), "05/14" },
                    { new Guid("de1556fb-6138-4628-bfd4-e56676dae9f0"), "076", "5272092850077365", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "10/24" },
                    { new Guid("de39ec1c-ff45-420c-829c-21eed4d2c3f4"), "048", "7217500952958625", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), "07/21" },
                    { new Guid("ded64e74-c7e9-482a-9893-74ae16680ad5"), "199", "3985130424905203", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b"), "09/09" },
                    { new Guid("df206526-ec03-4c80-8e41-4170e69599e4"), "002", "1135102069297465", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), "05/28" },
                    { new Guid("dfb5ffcc-00b8-40e9-8244-0b0b886c3755"), "315", "5440699384027761", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1"), "06/04" },
                    { new Guid("dfbb143d-52ac-46f0-8c9c-69fe28910ef9"), "571", "5602214923435031", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969"), "09/01" },
                    { new Guid("e16dec2e-6c5e-4ec3-b9f0-0c925f002c43"), "207", "6233496456779002", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86"), "08/02" },
                    { new Guid("e19d9f82-b89e-49e8-b0af-f6d5b58c6d51"), "060", "2179896546693909", new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337"), "06/28" },
                    { new Guid("e1d6b809-6298-42ee-a506-4e32bdd99508"), "394", "8666096648506234", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f"), "09/21" },
                    { new Guid("e246983b-0adf-4d40-8f81-e36b1f14e059"), "880", "6258455138986453", new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f"), "07/02" },
                    { new Guid("e2710676-d37b-44e6-9fd9-479bc7c33996"), "737", "4435407711410664", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f"), "01/17" },
                    { new Guid("e27b4c9a-41fb-49e5-a227-e726c1715b8e"), "612", "7783045476534184", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e"), "08/06" },
                    { new Guid("e35f5962-095e-4fd5-905e-62aff86f8945"), "774", "2810747588859984", new Guid("99e79b31-2994-4fd2-956f-0294e124da96"), "01/02" },
                    { new Guid("e4121357-ff16-41e8-b4fb-aa531f88a5c6"), "297", "2173093812444768", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d"), "05/14" },
                    { new Guid("e419cfe0-5376-4729-910b-9d159a6f5cfd"), "358", "8291977547020532", new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332"), "05/20" },
                    { new Guid("e48c8dd2-71f8-4a73-a953-a143cae0de2a"), "243", "3897782327855984", new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328"), "06/26" },
                    { new Guid("e5190f2d-6296-4285-a5fa-6f286fc5a0fa"), "413", "4296365962951821", new Guid("c184664b-be88-432d-9f74-e8476badaa13"), "05/09" },
                    { new Guid("e5614a5c-374a-4aed-918d-38594d10bd72"), "090", "8671050634803211", new Guid("18971e31-ee25-41fd-bafa-129547aefc10"), "01/22" },
                    { new Guid("e591e711-5afe-4c6b-96d2-64fd446a9918"), "941", "7203425647242968", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25"), "06/21" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("e5bf8164-8433-4aeb-861d-be7b0dc5da95"), "852", "1392386817726396", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "01/08" },
                    { new Guid("e5da5c22-f93f-4bd5-a0b1-4fb38a0e8e02"), "792", "6853846509953755", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab"), "11/06" },
                    { new Guid("e62fef29-1a67-4e0e-8453-3cd36dd1bad2"), "786", "2275892539388219", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f"), "12/22" },
                    { new Guid("e643c855-fa0e-4942-a716-211f62c4d3e5"), "016", "2673498080113209", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6"), "06/22" },
                    { new Guid("e6724c94-8b8d-410c-b57f-49524e02d0f1"), "961", "4867573619688779", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9"), "10/07" },
                    { new Guid("e686907c-dd90-41a5-b684-7f77e9f60855"), "220", "7172138293196353", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad"), "12/12" },
                    { new Guid("e6ae665c-a884-4382-85ba-c990c5d58d12"), "078", "1777139431883038", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7"), "10/15" },
                    { new Guid("e7a17ac6-f1b2-4a40-a4d8-42573da6d252"), "945", "2189153815908443", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7"), "12/04" },
                    { new Guid("e833bce8-1763-42a4-a012-049b04d453a2"), "794", "3434989936967352", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981"), "01/13" },
                    { new Guid("e86857f1-6b58-4acb-9e79-ed1b024e41f0"), "696", "4948934374129167", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "07/06" },
                    { new Guid("e8a3ba79-6c1d-4aae-98bb-36d8b14035bd"), "706", "3763058137277228", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "06/06" },
                    { new Guid("e8b0dcd2-ac85-4ae8-9ba9-3498935ee443"), "386", "5799791224436385", new Guid("db79945a-0e64-4c97-801f-a38a1e357d12"), "09/09" },
                    { new Guid("e8ff27dd-2ba7-439c-a35f-d4ad60301837"), "695", "4872811440074514", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f"), "02/08" },
                    { new Guid("e9123db0-7e50-46b1-a11e-d3bc7325acf6"), "956", "8978668915746482", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de"), "06/07" },
                    { new Guid("e99359fa-cdc6-462f-b631-8de0185b17d6"), "478", "5399607201532186", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903"), "06/06" },
                    { new Guid("e99e3ca6-8ccd-4a9e-9def-3f3436c5d5a8"), "184", "5546205236329937", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c"), "02/01" },
                    { new Guid("e9a2329f-7e01-40cf-9592-5e2cd26b23dc"), "914", "4615714100851690", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f"), "11/11" },
                    { new Guid("e9aeceab-2f18-4a87-ae6b-94efb1a5ebb7"), "805", "6416034874064373", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078"), "09/02" },
                    { new Guid("ea87d947-77da-449a-bfcd-ce37721f086c"), "948", "2689658148700299", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903"), "07/17" },
                    { new Guid("eabc56e9-9e46-4f2d-a3eb-c276e7ca784c"), "738", "8861774376606313", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592"), "06/25" },
                    { new Guid("eb0c9fd3-3b3d-4b44-8364-719bdbc222aa"), "716", "9872857302299926", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b"), "05/02" },
                    { new Guid("eb27d546-bc23-44af-84cb-9969ebb448ae"), "394", "3078821676033225", new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b"), "02/26" },
                    { new Guid("eb878dee-5dd5-45bd-8965-6c33ad509daf"), "266", "9935220854948855", new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911"), "07/20" },
                    { new Guid("eb95cbf9-2c3d-452e-bc33-75d4b6b47b9b"), "549", "2988266548853936", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0"), "04/04" },
                    { new Guid("ec0344fa-8275-493d-81e9-c4c57d892b18"), "051", "4336083909469539", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), "05/20" },
                    { new Guid("ec3b1a4d-9f5f-4845-844c-9d7c6b4c9cbf"), "774", "6744674034651028", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab"), "03/07" },
                    { new Guid("ec57df81-7cd5-4767-ad79-ca7f562fa6a5"), "343", "5248746547439765", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760"), "07/28" },
                    { new Guid("ec588246-7989-49be-a74e-48ed44de621f"), "163", "1622233906349616", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26"), "06/04" },
                    { new Guid("ecfc2459-99ce-4216-aecb-c0f1c8344982"), "995", "2485660379380643", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa"), "02/21" },
                    { new Guid("ecfeb6f3-dac6-4eca-b863-79f10bb0e8f6"), "718", "3352511888173002", new Guid("93fc11aa-1d50-4309-844c-1154f207d374"), "01/11" },
                    { new Guid("ed299662-d781-4750-85ed-6a68f31219a7"), "231", "6844390468257964", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17"), "10/14" },
                    { new Guid("ed2b4c7b-5762-4189-8b02-ed0af8e68318"), "923", "9014440217057064", new Guid("edf37002-a546-4d28-acd9-2614759e640d"), "10/26" },
                    { new Guid("ed4711c9-62ed-4ee9-8ef0-4e41eb73429c"), "332", "7979384916127739", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca"), "08/13" },
                    { new Guid("ed683ee8-316c-4939-a51d-21d2ef1fdfa6"), "441", "5207131353378072", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a"), "11/20" },
                    { new Guid("ed8bc5c7-570c-4b5c-875c-570a6ee85200"), "966", "1201806858306582", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52"), "08/02" },
                    { new Guid("ed8e3d2d-e283-4c72-b5d8-e3c27367bc15"), "208", "5243701405788596", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa"), "03/03" },
                    { new Guid("edbda712-cd04-4a4d-b6d6-4a800d830cbc"), "117", "9334514071779274", new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d"), "10/24" },
                    { new Guid("edc590db-f1b9-4d26-8731-b0d2a733ecbf"), "469", "4887210693126095", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097"), "11/08" },
                    { new Guid("ee33818d-1e1f-4817-b1f0-05e4470363f4"), "441", "9378446446768459", new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332"), "11/01" },
                    { new Guid("ee3830cd-5b8f-48aa-89cd-a3f63f3b4090"), "858", "7608184724364085", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56"), "07/26" },
                    { new Guid("ee83f3ac-9958-4714-8f3c-34c4ea8f60f1"), "500", "7132828954816937", new Guid("ca402be9-4708-4877-ada7-62364da2236a"), "03/03" },
                    { new Guid("ee92591a-653a-42bc-b236-504e7f72c404"), "232", "4536490863042487", new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a"), "11/26" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("eee50382-eadc-4c8a-b955-6b1edceb51ec"), "084", "9305185359927531", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed"), "08/18" },
                    { new Guid("efa38490-d398-4136-a376-52f450286236"), "928", "6179833112720038", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a"), "05/27" },
                    { new Guid("efee3a09-910c-44f6-bfc0-0a91274c5012"), "222", "8588200011969163", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3"), "07/28" },
                    { new Guid("f018fb3f-da1d-4e22-a40b-db7d4e230c18"), "167", "5633660311585178", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f"), "07/23" },
                    { new Guid("f0202d54-2516-49f0-81d5-22b00e76247e"), "852", "7448978799036098", new Guid("f4943944-5289-42df-aed1-a6281dd934db"), "04/24" },
                    { new Guid("f0792448-5b8a-494c-b6c7-3e76d69563f3"), "005", "2429619608931072", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), "04/01" },
                    { new Guid("f161e3a3-f38c-46a0-8206-ae7c62dc64fd"), "067", "5878467952886324", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401"), "04/05" },
                    { new Guid("f17eec52-5cd1-4b93-9aab-ef0d60410484"), "928", "6768801171363679", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb"), "07/02" },
                    { new Guid("f1c84d86-1399-4471-8563-3ebbdbeef267"), "018", "6932635579974168", new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079"), "09/28" },
                    { new Guid("f221e43f-027d-404a-898f-f1e591aa06e8"), "044", "9273521221931259", new Guid("b80d479f-1611-46e2-a055-1de659d203b8"), "08/07" },
                    { new Guid("f24bd041-f72b-40ae-932f-774716003928"), "428", "1538641953871340", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8"), "10/09" },
                    { new Guid("f2664e5b-c501-43b0-8ab4-e79e1d7ea60f"), "144", "4925430104994355", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c"), "06/13" },
                    { new Guid("f277a450-0158-4392-ab6c-5f503d8e3084"), "282", "1536416513944684", new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3"), "12/12" },
                    { new Guid("f2a4287a-5d52-417e-876f-1193cbb9c412"), "411", "7445772958792543", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02"), "04/24" },
                    { new Guid("f3a66ad0-c152-406b-a58e-fb14db9ff05b"), "977", "4104958105565657", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702"), "04/24" },
                    { new Guid("f3e6a4b5-067a-4488-8043-526cdfc87798"), "371", "2826653015491120", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5"), "03/01" },
                    { new Guid("f4019e30-80a2-431d-a12d-352038e0a625"), "977", "1639304020245236", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a"), "09/24" },
                    { new Guid("f4ad3d6b-7a5b-4e32-a3a0-b74422e1d234"), "462", "9545376246641935", new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e"), "09/26" },
                    { new Guid("f52c8c1d-db56-45d0-90b8-a6609ef86e83"), "540", "6410208198252737", new Guid("de7d9783-5299-4552-b426-e13c1b4a4995"), "05/02" },
                    { new Guid("f5867aa8-901a-4798-a087-5dfb9b34ff37"), "930", "3090807599175837", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2"), "09/06" },
                    { new Guid("f5872461-280e-4538-839a-b31f542cb144"), "832", "1854361779143720", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de"), "10/08" },
                    { new Guid("f5db0065-d992-41f5-bf65-efbdbcbbcaa0"), "942", "6170392847794452", new Guid("69335634-41ba-4400-a54f-e27126ae5352"), "09/09" },
                    { new Guid("f5f776eb-e61a-4350-98c3-d7221b48eeac"), "901", "7182663370111938", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3"), "10/22" },
                    { new Guid("f5f993b7-1204-4a72-9e61-b106276efd62"), "851", "8873241952274683", new Guid("69335634-41ba-4400-a54f-e27126ae5352"), "02/22" },
                    { new Guid("f5fbe916-6197-4ab4-87d3-fc941c9423e2"), "136", "7387741840902199", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d"), "06/09" },
                    { new Guid("f601af8d-8268-4bbe-90b0-bb2043fc7e9a"), "244", "1460256338405101", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17"), "10/25" },
                    { new Guid("f61cad90-e0d1-4a84-8f2f-b5f87d7053e8"), "989", "2638511084233399", new Guid("501ca405-0708-4624-a634-6510fc3c78d1"), "05/26" },
                    { new Guid("f62708d9-3a96-4155-8c88-75daa040362b"), "283", "2524475992576326", new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf"), "07/10" },
                    { new Guid("f651887b-61a5-4a68-87e6-f5ecd86db6cc"), "522", "9770521903468679", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56"), "11/18" },
                    { new Guid("f65de967-1c24-471c-a462-65e9be49a437"), "651", "3563264769994601", new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a"), "08/24" },
                    { new Guid("f673ec4d-6b27-4b8f-a6ec-adda11886d33"), "770", "2140861419430852", new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d"), "12/27" },
                    { new Guid("f72afb71-99b5-4e6b-b72a-63084dc3b664"), "774", "1230847309732232", new Guid("53792862-da15-45a1-b0ef-d025a7608026"), "05/28" },
                    { new Guid("f749c5b9-5444-4fd0-afb7-901f12f0764b"), "747", "2799265930440926", new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757"), "07/03" },
                    { new Guid("f7656087-a325-453d-9bc7-8ec876697520"), "555", "7782034633680930", new Guid("d8bacea3-d276-4baf-9e42-486b55067620"), "05/27" },
                    { new Guid("f7d74273-5e92-4bb7-8a6c-c987d37fac35"), "845", "4095076971735726", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d"), "10/16" },
                    { new Guid("f8d8e17b-f758-4be1-9d20-76f244eb5018"), "102", "2522306354368833", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb"), "10/03" },
                    { new Guid("f93f2360-2139-4acd-b1b9-7379b43f3040"), "188", "2341238656040625", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf"), "02/26" },
                    { new Guid("f958acdf-4c92-4f82-9cad-9ae5aee32c3a"), "828", "4247417096136929", new Guid("65012c66-d07a-40f6-9789-b100201359c2"), "02/08" },
                    { new Guid("f9798f98-de4a-44e3-a2cf-74141cd88408"), "682", "2211211554535262", new Guid("702dc016-070a-4620-818f-b4e492286066"), "10/28" },
                    { new Guid("f9baf0b3-a940-4fd0-8a54-373ba0068ad9"), "174", "9324767917846712", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184"), "06/04" },
                    { new Guid("fa3798b8-400d-4b0e-bc16-c560aa200bac"), "562", "6481914174837958", new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb"), "04/03" },
                    { new Guid("faba10e1-9ff0-42a1-9e47-1eba424d68af"), "079", "1072566259291056", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7"), "03/15" }
                });

            migrationBuilder.InsertData(
                table: "PaymentCards",
                columns: new[] { "CardId", "CVV", "CardNumber", "UserId", "Validity" },
                values: new object[,]
                {
                    { new Guid("facd6964-66cb-4af6-89ed-363d33073551"), "028", "8914765849350489", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669"), "05/09" },
                    { new Guid("fb75da67-6d1c-4a0e-8919-b27118d21822"), "866", "1170658381612510", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b"), "10/07" },
                    { new Guid("fbfef065-44f9-4933-9df9-4a7bc7828d81"), "205", "7104860907130323", new Guid("2a24280c-6e79-420d-bd19-903d44c42081"), "01/11" },
                    { new Guid("fc3e8be5-74ad-460a-8af2-9ecb7a912603"), "975", "2818800136570661", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184"), "12/13" },
                    { new Guid("fcc1aea5-d3b3-43c0-ab3d-3184057d9d52"), "378", "5066456670673099", new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17"), "07/24" },
                    { new Guid("fcd40391-71fc-4219-bf16-90e38987e14e"), "568", "4490221852559632", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a"), "04/17" },
                    { new Guid("fd090962-0f90-4d52-bd41-c75cbe12dab8"), "172", "2477006087431119", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e"), "10/11" },
                    { new Guid("fd1d11d3-01bd-45fe-9426-7c8f3ef409d7"), "675", "1213728260336489", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6"), "05/13" },
                    { new Guid("fd287590-0d96-4528-a5d4-768843c668d3"), "723", "8152916712927242", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f"), "06/12" },
                    { new Guid("fd5cad3b-bac7-45e4-9c8d-256cc7e17922"), "606", "9537157165245279", new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd"), "07/13" },
                    { new Guid("fdaa71f9-bb3f-4a10-96db-4248f291859c"), "130", "4156034703901979", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba"), "10/24" },
                    { new Guid("fe0de16b-633d-4b47-9551-23e3c9451005"), "737", "7460223506588851", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb"), "06/20" },
                    { new Guid("fe6486a8-e5d8-4f29-b887-8a5fd3897c55"), "364", "3277057132580168", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf"), "02/14" },
                    { new Guid("fea96a4a-ae70-4e6d-9cbb-bbe71f254f70"), "472", "8719771843169217", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d"), "12/23" },
                    { new Guid("fed65952-2b77-41ef-9866-c45c1db75e02"), "456", "8686409414240275", new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40"), "07/02" },
                    { new Guid("ff690eaa-9f89-4a70-9d00-760dc366ec30"), "596", "3136956066108161", new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8"), "12/05" },
                    { new Guid("ffb0daa7-6975-413f-be83-2d308a6c62d2"), "029", "8282596952638211", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34"), "09/19" },
                    { new Guid("ffc0cd54-b2ea-4699-ad85-9caf34df9a8b"), "994", "6984327409908827", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d"), "01/21" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0039471f-1d96-48a5-a9ad-3b2250563441"), "+580 74 (289) 96-88", new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757") },
                    { new Guid("00398992-ede9-467f-af0e-2289923ee320"), "+933 54 (300) 93-62", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("006e2d83-1314-4bfb-b996-e0bb508635fc"), "+543 26 (966) 98-23", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("0088e286-f56c-4d45-8be2-48285ee866e3"), "+323 38 (244) 50-51", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("00891656-dc60-44dd-9cb4-68fd80c3eb1c"), "+937 03 (758) 51-75", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("00d22544-f432-4dec-8c45-d67cea76af63"), "+333 50 (445) 94-74", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("010e81eb-dd53-4a86-ac5b-fbeb70fffd25"), "+985 50 (636) 71-25", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("0159c884-fb78-4b92-8223-8141ef87e59a"), "+975 48 (365) 93-20", new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17") },
                    { new Guid("0198b0a9-a094-426e-b5e4-1fa1c1d1798e"), "+949 71 (311) 61-17", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("01bbdbbe-2b29-42f7-ab5a-f9ee9a9b702e"), "+333 21 (219) 39-62", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("027b2f47-19f6-46de-8aac-9b898b9f75eb"), "+380 91 (935) 40-32", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("03301514-12ac-48ab-addc-b9f4b22ad798"), "+457 55 (176) 37-71", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("03777311-94c2-45c5-9093-e6e6468832ec"), "+954 40 (047) 75-39", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee") },
                    { new Guid("0385d3e5-619d-40d8-a2c2-cc7f5e57af47"), "+128 07 (812) 31-41", new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("03bb58b6-f771-4ce6-aecc-515087ae1fd0"), "+709 29 (172) 95-18", new Guid("e698e260-89e1-4c83-b493-1379542f5647") },
                    { new Guid("0401be06-8164-4089-b53e-8d13133df70e"), "+101 24 (897) 36-16", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("0451d320-1cb3-4b0f-b3cc-5022b9821cee"), "+271 93 (680) 15-18", new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("0480080c-ad3a-4552-a7b8-028aa8546ae6"), "+928 68 (337) 94-85", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("0502b29f-9f96-4e2c-871f-5d45271ca199"), "+593 14 (913) 00-53", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("05c6e760-1b5e-4321-901a-a94bc5e62144"), "+397 61 (297) 73-59", new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d") },
                    { new Guid("05dbd91e-f380-48db-acaa-c4c046eeb675"), "+662 87 (530) 84-58", new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("05e0591f-1291-420d-bead-d0986de7de35"), "+175 36 (850) 88-26", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("06297d7d-a765-414d-9dc4-c7a55437a519"), "+524 04 (402) 57-54", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("0637aa65-c96e-4a3e-91b1-d07b39520ee0"), "+310 99 (449) 86-48", new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0638aafa-22ee-4fc1-8e3f-c0c63fc59a2c"), "+383 95 (326) 32-11", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("066e21d5-b8ca-474a-a7cf-3c28be720a6f"), "+788 12 (893) 83-83", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("072c35b6-8866-4363-8b73-6b9aa69624b6"), "+455 84 (785) 41-22", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("074c3212-fc6f-44c4-bb79-150ac1d459be"), "+746 46 (231) 74-38", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("075972ca-7cc3-4ab6-aaeb-0f1f8fb9958b"), "+787 72 (804) 21-97", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("07be8d21-03bb-462d-b33f-5cd37149bfc0"), "+485 54 (382) 82-78", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("080b11f1-2047-4bc8-a560-c448ff91b594"), "+320 01 (449) 37-56", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("08115a41-cda7-47f5-b746-41d6ce83a38a"), "+90 40 (595) 47-02", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("084d41a0-ca8a-4bc5-b7c1-0216e418178b"), "+928 76 (657) 54-71", new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094") },
                    { new Guid("08d3efaf-5aff-4c38-9034-d8f9a548e69b"), "+217 82 (344) 33-20", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("08db9937-0828-4a29-9b2d-8ac6b98db638"), "+89 03 (252) 04-79", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("08de3006-a3a5-4dd2-9949-bbeb25b37d6f"), "+929 34 (694) 60-44", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("08e10488-401b-4699-b3dc-5d5cb583a94b"), "+170 73 (304) 03-39", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("08e6fd55-df78-446e-a556-8556b757eb85"), "+727 55 (362) 68-30", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("094b9723-b40f-4bdc-9657-c1623cdab9be"), "+419 69 (366) 43-70", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("094e1de3-d395-4e76-bfdd-f40504e94793"), "+124 66 (013) 60-22", new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("0a316208-c072-4253-b445-9a95a0bde896"), "+336 58 (381) 90-07", new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("0a5803a7-920c-45ec-b169-947459675006"), "+329 93 (525) 40-05", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("0a66f7be-06d0-41b3-843e-eaebb1be9ccd"), "+553 92 (671) 54-06", new Guid("61fe1433-1b16-4004-8246-4e030b366c6d") },
                    { new Guid("0b4dac62-e1c0-40d9-afd1-453ee80f3d64"), "+344 55 (912) 90-72", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("0b50ece1-ec10-4f8e-a023-5148a3d255b6"), "+906 05 (203) 89-52", new Guid("bc263f92-f627-4eaf-a134-fb4f07b5f2ee") },
                    { new Guid("0b5b5e30-d3d9-46e1-abc8-d0336ad74965"), "+382 02 (211) 91-26", new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985") },
                    { new Guid("0b98f185-0142-46e0-a87c-1447cea6103e"), "+988 18 (513) 86-41", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("0c2a7efd-6748-4d12-bb38-d997058baae5"), "+986 36 (095) 64-41", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("0c61a66e-32cd-471e-b53b-55ab7e40044d"), "+724 66 (473) 24-88", new Guid("afa896ab-be1f-4401-923e-90219b5466bb") },
                    { new Guid("0c63f39b-fc52-4ef6-a97c-b1ad9d1e0cbf"), "+472 17 (158) 24-61", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("0c7f3693-1f27-413c-abac-6f4bb173185b"), "+295 97 (251) 27-35", new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d") },
                    { new Guid("0cb16ff2-7367-4ff2-8083-bbdf0dff57a5"), "+740 63 (568) 27-38", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("0cca158d-781e-4822-83f5-7e7cbc095993"), "+787 03 (379) 93-54", new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("0d248b74-50ca-48bc-aef4-86b1e4f5e939"), "+49 71 (347) 94-00", new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6") },
                    { new Guid("0d33469f-393a-4ee0-9426-027615428233"), "+376 64 (421) 99-72", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("0d754207-d09e-4521-979d-706ec08120b0"), "+610 21 (970) 62-08", new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700") },
                    { new Guid("0db7e098-6d1f-4930-8994-3503b3fa13cf"), "+942 64 (019) 09-32", new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8") },
                    { new Guid("0dc1c1ea-4972-41cf-8f26-91fc65383b28"), "+9 02 (055) 27-35", new Guid("8959e331-7a84-433f-9378-9aad487e24b6") },
                    { new Guid("0ddbae1e-e52e-4084-ac2f-8827c400615f"), "+188 86 (271) 34-85", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("0e3dd368-f67f-4b3d-8c16-9ab4732a6425"), "+163 66 (033) 88-07", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("0e6c272d-6517-4383-8782-575875791124"), "+867 13 (043) 35-18", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("0e78840e-90b3-4f2d-ab58-35cfa7b7d912"), "+750 39 (659) 04-50", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("0e926291-90b9-44c6-9c1d-e88ed3453cbb"), "+426 46 (006) 65-50", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("0e9e7b00-e7f4-46bf-ad42-d70466176bbb"), "+718 33 (765) 57-61", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a") },
                    { new Guid("0eca2c73-615f-4887-9b99-a1b4e19f77e8"), "+540 91 (037) 61-23", new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9") },
                    { new Guid("0f0183a3-8aeb-4c90-b433-460e7942e46f"), "+687 98 (148) 38-58", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f2d02f4-a866-4373-93be-549fe6f5c6c2"), "+958 58 (548) 35-34", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("0fc9910f-cbb6-4f70-ac78-e67006b38e57"), "+12 65 (307) 32-03", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("10abe6c9-97f6-4ba2-b646-284663e8ebdd"), "+636 71 (967) 58-53", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("110d2031-f0ee-4d2a-95b1-26d58355e65c"), "+255 81 (534) 29-10", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("113993e8-1242-4005-a38f-a2bc49d600a0"), "+916 56 (577) 92-47", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("1165b301-459c-461a-a6a8-7890ede84ff6"), "+651 91 (676) 77-61", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("1170222c-7036-4332-88e4-1e1d50e3eb63"), "+817 45 (973) 95-55", new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("11b94afc-91a6-4f6f-be05-458b734a04d8"), "+890 79 (393) 67-97", new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552") },
                    { new Guid("11bf8c7b-0107-4713-af2e-adc97d32459b"), "+580 33 (016) 44-00", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("1204b784-73c9-461c-8715-33cc6857cb0f"), "+389 16 (132) 26-91", new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058") },
                    { new Guid("122282bb-dca5-4f59-a497-4ba3141c95d5"), "+523 61 (661) 82-61", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("124c6472-a7b9-41fd-bd47-475537a6b268"), "+187 69 (793) 65-05", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("1251b08d-00d0-488e-bc20-f747a9ddd26b"), "+131 71 (928) 59-07", new Guid("41296760-deca-4b2d-a760-5538da32ccb4") },
                    { new Guid("1254c76b-0b9a-47e3-b38d-b4be94da5c7b"), "+133 42 (205) 83-95", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("12bc36ca-7ca4-4336-902e-a50db706d563"), "+269 53 (357) 26-78", new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9") },
                    { new Guid("13b092e4-e911-4567-8b5f-24b9a4e70a17"), "+722 08 (423) 74-13", new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7") },
                    { new Guid("13cf3801-84f2-41db-941c-cb0fd1623b5b"), "+971 66 (518) 61-56", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("13f04540-6338-4eec-8fe6-ec1f9361a309"), "+77 98 (818) 37-22", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("1411823d-b440-4954-9973-51bf3c8f0f03"), "+616 96 (297) 41-63", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a") },
                    { new Guid("1426ba22-d6fb-4159-9122-5994239c273b"), "+222 74 (156) 05-14", new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("14ae949c-f07c-4fcf-9b88-5d0fa444e506"), "+83 96 (168) 79-93", new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7") },
                    { new Guid("14d77a36-53f4-4746-8bac-4081660b2044"), "+795 84 (267) 19-38", new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079") },
                    { new Guid("150d4143-8617-47da-a032-fb585599eb20"), "+101 48 (552) 10-69", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("153377be-cc21-4834-8f57-8d23eaf9aa66"), "+654 62 (271) 26-83", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("15a41503-0e85-4b07-8e6a-e61b39521c4b"), "+645 57 (129) 34-48", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("15d5f62f-a54c-4f81-a199-129b3e9003d0"), "+988 74 (835) 86-04", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("15e7a1af-c133-4459-b996-842c9c03a291"), "+299 85 (818) 87-41", new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f") },
                    { new Guid("16161eae-e448-4165-a33b-c3ca304fb509"), "+690 78 (161) 52-79", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("1699de60-0867-497e-83ab-81c2222d7046"), "+806 71 (549) 47-32", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("1716e42e-49ca-42dd-b5a6-8a4522855d00"), "+337 92 (859) 38-10", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("173faa67-57ce-493a-8020-1ee7fc6ba0bc"), "+67 15 (711) 19-58", new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("1753016f-6e8b-4a9f-b99f-7851956c07cc"), "+378 12 (566) 25-01", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("17f0a7a6-72df-4b5d-9741-b53e181dcb67"), "+787 37 (701) 33-21", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("18d373ef-c9e4-46f2-b090-948707fd2399"), "+797 71 (258) 92-01", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("1984883c-0c51-41e0-ad24-b9719bf4a264"), "+691 29 (644) 79-90", new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("19b9b14c-d898-46fc-9c59-495fa7fc8271"), "+883 95 (089) 69-34", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("19bbd185-8d28-4734-ae71-bd90f82d9811"), "+426 23 (958) 95-52", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("19ce4823-4718-450d-962f-5add7a8f3311"), "+15 03 (226) 87-09", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("19d93e2f-8daf-4737-8d06-5cab2297da4a"), "+294 59 (651) 13-40", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("1a3e7f90-e8da-48c2-b090-fbc3c6d25fa0"), "+23 74 (418) 45-56", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("1ab71e67-94e0-47a8-9703-c0dbe140cd3f"), "+260 53 (608) 88-65", new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099") },
                    { new Guid("1b37bf49-e705-4d91-96a0-7bdb4769dc97"), "+879 34 (171) 11-67", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("1b3c309c-2785-44eb-92ba-2468f08e0fd5"), "+344 90 (696) 98-52", new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("1b45e37c-603a-4012-b737-a6de6ef826f5"), "+726 12 (497) 98-63", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("1bfb2ad4-41e0-4046-b4bf-6231bf37a6d3"), "+391 59 (925) 86-88", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("1c5ae376-6e20-4d89-bac7-1163bff518b9"), "+75 40 (272) 76-29", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("1c67e512-e376-4432-adf9-e042bf224f59"), "+65 52 (774) 75-35", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("1d0a71bb-ca55-43cc-90cd-48caca4d6b0f"), "+571 10 (870) 40-39", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("1d5dede4-da99-4324-a447-ef30d498a678"), "+317 72 (913) 18-31", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("1d878b83-ea8a-428a-9723-943f4795f2a1"), "+143 84 (687) 09-19", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("1d9498f6-d983-440b-a880-84dda4fd5612"), "+981 16 (717) 20-09", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("1db66746-1024-477f-a437-77fc8fabdab4"), "+49 33 (168) 47-52", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("1dee75df-f1ea-4359-a2c5-f6aee3c27dee"), "+935 15 (344) 42-58", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("1e1170fb-64e9-4d47-ab04-e4db6d795462"), "+254 32 (898) 53-33", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("1e299af7-fe8a-4309-999d-028b9f6d8a8a"), "+33 94 (125) 60-25", new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a") },
                    { new Guid("1e65d0ef-a3fe-462a-9975-44723e23cb79"), "+974 77 (578) 29-92", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("1ea612fa-33e2-4aca-b7b1-65a46af61e5f"), "+628 64 (097) 34-12", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("1f0c6b96-e285-4479-af97-da21d78b88dd"), "+869 20 (252) 99-06", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("1f233127-264e-4bca-913a-4b3c894240f1"), "+113 67 (549) 91-56", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("1f2f9fdf-12b7-4b7b-8d60-b1066969f740"), "+532 18 (630) 82-64", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("1f616aae-3894-41a6-92d2-62d75cba0dee"), "+205 31 (088) 52-94", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("1ffb658b-1e25-4a11-9ecb-93bee304fe6f"), "+204 77 (592) 32-90", new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197") },
                    { new Guid("206440d3-0657-479a-bf49-580804173f63"), "+309 54 (778) 14-56", new Guid("913aac82-79cd-4930-833a-d54464607133") },
                    { new Guid("206c83db-1dda-4f59-be0a-f3023507c0e1"), "+300 93 (522) 23-76", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("20bf9e18-12db-44b5-9603-f78daf5da2d5"), "+399 57 (655) 81-46", new Guid("18971e31-ee25-41fd-bafa-129547aefc10") },
                    { new Guid("20f5a235-6707-445e-bc96-7910a6be0cdf"), "+586 34 (094) 24-09", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("20f8c6d2-3734-49a6-83bc-d0df3eea5060"), "+59 41 (773) 17-12", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("215f1951-fccb-4d76-b6b0-d50562afb7c0"), "+133 90 (105) 91-42", new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("216047df-847d-4d04-ba36-707b00ab719e"), "+91 05 (749) 80-90", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("219d2397-6b31-4970-ac8f-6734c3e63d59"), "+907 70 (738) 07-50", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("2203bce7-d7fb-427e-a46f-514e47760bac"), "+378 69 (080) 91-30", new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684") },
                    { new Guid("22a1c2aa-ae03-4525-a81b-fa39438f2951"), "+995 34 (915) 74-50", new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("22ff42c2-30a7-4d16-a7a1-87a20b109483"), "+769 48 (335) 43-30", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("23417161-50ba-4acf-8416-aabbf166a6c1"), "+838 09 (074) 50-87", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("2348be2d-10f0-4ffc-a85b-8bab85b0e6bd"), "+826 24 (061) 13-10", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("23bdced2-ec56-4175-8613-bdfa9cd18c40"), "+510 80 (775) 77-78", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("23e78d96-c217-4ea7-9799-011171e488a1"), "+882 67 (861) 68-35", new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("242b015d-c80c-4960-b93d-ba3068428c55"), "+14 34 (521) 79-66", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("24e36a3b-f5f3-4b2f-bbdb-d3012ab39df2"), "+219 60 (039) 01-39", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("24fc237f-e2e3-42cc-9f04-b5877f2e3732"), "+101 70 (349) 70-58", new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead") },
                    { new Guid("252d1004-7767-4cb6-a458-ac4602d515ea"), "+683 04 (897) 56-07", new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63") },
                    { new Guid("259bab97-56d5-4cae-9f7a-17162f862243"), "+569 02 (623) 91-28", new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332") },
                    { new Guid("25ca40ca-ea1a-4edb-bf8e-0b500560c038"), "+746 73 (357) 33-39", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("25d758da-9e6f-481f-b443-11e56ddbd88a"), "+241 44 (209) 21-43", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("25dc222f-81fd-47c7-860c-1353dd171004"), "+914 49 (439) 63-21", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("25ef5a62-5586-481a-81e4-4731d5fb0b11"), "+679 05 (477) 60-58", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("26749a49-0093-437d-98c9-998bd24a6449"), "+640 76 (021) 01-45", new Guid("51274356-5ef0-4e46-a687-716d200f49e1") },
                    { new Guid("27438304-6687-45c4-9ca1-3a3a1c81f3fd"), "+539 95 (517) 51-56", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("274ab87c-93cf-44de-8ea5-d35d99d7ec44"), "+53 87 (691) 62-86", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("27f26e22-6403-4104-a929-7b88161e38ce"), "+195 13 (167) 05-40", new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("28d60c7f-5f39-4978-bf06-914164769177"), "+830 00 (701) 58-87", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("28fa4396-c496-424e-b8f7-8dc287a1bc41"), "+134 12 (341) 81-72", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("293f7369-5643-44a7-b10e-df866c0e2110"), "+872 06 (842) 93-92", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("2a55254f-00d6-4f36-b28a-7ef2c05fbfcc"), "+933 24 (829) 48-31", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("2a7bff40-6aff-4a8c-b073-a4bd1d3fd592"), "+821 48 (718) 77-24", new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("2acdcdf2-d555-4f2d-b188-6e54c4297fcd"), "+350 06 (516) 65-53", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("2b7a8d09-f3cf-41c0-b95d-97cb6f1e9e28"), "+445 99 (375) 52-45", new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803") },
                    { new Guid("2be82dd6-8163-43f9-8edf-75ab8813f265"), "+656 76 (921) 78-80", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("2c02964d-ee6e-4b32-ba41-ff75f6b8eb5a"), "+988 94 (580) 21-17", new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27") },
                    { new Guid("2c359dec-db90-4a15-ac56-8aad1a9d77fe"), "+883 48 (202) 89-94", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("2c53e5af-201e-4adf-af76-4e62a30676fb"), "+674 69 (642) 12-14", new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387") },
                    { new Guid("2c895765-01eb-4962-8339-fdce92e78c3e"), "+853 73 (699) 25-78", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("2c8b7849-bad1-4e4c-aa31-b62d6c035aa4"), "+805 49 (672) 94-91", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("2ce118a2-b848-46d9-9a94-fa04a1bb915c"), "+74 26 (126) 05-61", new Guid("99e79b31-2994-4fd2-956f-0294e124da96") },
                    { new Guid("2d6df256-b76e-4ad6-a568-72716369a0d8"), "+748 04 (185) 84-10", new Guid("4372d9dd-5bf1-46fe-9b50-2eb82f6aa099") },
                    { new Guid("2d8647c9-76a6-4c40-86b0-d50aaf7b2b0d"), "+643 89 (290) 07-52", new Guid("8959e331-7a84-433f-9378-9aad487e24b6") },
                    { new Guid("2e1b63de-59ba-4b09-8e34-375090919dc8"), "+534 51 (498) 02-82", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("2e34c591-a8c2-42e7-82f3-91d770252e2f"), "+464 31 (637) 82-16", new Guid("b80d479f-1611-46e2-a055-1de659d203b8") },
                    { new Guid("2ecbb8b2-2f3e-4246-94e9-a43bfcb2db0e"), "+486 26 (213) 01-02", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("2edb2827-b624-4ff6-91e5-9fb38052198e"), "+384 56 (945) 91-69", new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093") },
                    { new Guid("2f19268d-09fb-4999-aa63-2e2d383aff18"), "+497 28 (000) 07-43", new Guid("74b3dcc9-46b9-432b-a105-af04273b540f") },
                    { new Guid("2f4cadb2-f73d-4f1e-8b74-1695a84b93c4"), "+355 36 (333) 80-40", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("2f9d4765-2a19-4bf7-9462-274e4787ce4f"), "+367 57 (355) 39-11", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("2fe6e9db-e1e2-43dd-9b85-c2fd36cd71a5"), "+973 80 (388) 42-78", new Guid("f7036a20-e5bd-4ece-992d-40b6f3fcd094") },
                    { new Guid("2fee13e4-674c-42af-9865-7cd03b5ce380"), "+327 78 (258) 67-33", new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("2ff99bae-2fbb-4bca-a9fe-9b5faf8fdbf6"), "+821 71 (695) 72-78", new Guid("046e4f0f-5987-4041-bae2-3ee39d74b985") },
                    { new Guid("2ffc01e7-8a66-4fa2-a0ad-2ff7944bcb5c"), "+720 08 (243) 56-34", new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1") },
                    { new Guid("304431f3-9499-4f02-9ce2-85eaef93b45b"), "+191 82 (433) 39-92", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("3048a4b5-2f3e-455d-9123-5dcba89f7cec"), "+135 04 (054) 91-33", new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("30a34583-dd71-493e-acd6-eff977cad738"), "+247 97 (705) 44-48", new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8") },
                    { new Guid("30b4d12d-17ac-4423-92f4-4075aaf10308"), "+594 64 (757) 86-67", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("30c36c81-9380-47de-8a58-7c9f4473ad2b"), "+521 59 (131) 75-35", new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40") },
                    { new Guid("3232e971-61c7-41f0-9e3b-a665a1768eaa"), "+292 82 (785) 08-88", new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d") },
                    { new Guid("324291ef-8f45-462b-b005-6222fbb25be3"), "+959 55 (955) 99-70", new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("327a33af-2b47-409e-8ab6-b66156cdefe8"), "+78 11 (405) 62-03", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("327a4524-895c-4dfc-ba85-9c95ef57fbd0"), "+236 46 (139) 35-19", new Guid("9f77c289-2c06-47ce-88e7-fb808391bd63") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("330646fa-3d51-412b-b55d-81ec936fc3fe"), "+79 55 (317) 51-44", new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf") },
                    { new Guid("331e3180-066f-45b7-aaac-2655fab75f64"), "+767 50 (931) 48-07", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b") },
                    { new Guid("335caf96-f49a-4223-900d-4d56497890c5"), "+821 08 (195) 64-54", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("3378144d-47fe-4464-ba9d-e00ad7f2835a"), "+349 35 (807) 68-07", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("33941e75-a097-4db3-8a39-94c793a85254"), "+649 71 (536) 49-56", new Guid("db79945a-0e64-4c97-801f-a38a1e357d12") },
                    { new Guid("339eee76-456a-4300-81fd-e860f7deecac"), "+488 61 (498) 03-03", new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("3427112a-ae3c-45b1-8e1d-47a86885d891"), "+955 60 (134) 83-80", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("348f8359-bdce-40d9-b9fa-9c35f8b2ec1f"), "+797 85 (845) 57-98", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef") },
                    { new Guid("34f69ffa-a415-444e-8204-c0911ad8a302"), "+924 72 (793) 06-57", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("3537aca7-9528-4a50-a08b-1d510cd41f08"), "+792 72 (121) 43-13", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("356c76e6-46a7-4c7b-861f-5b68c9ad3926"), "+365 87 (917) 49-54", new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374") },
                    { new Guid("359ccc87-f757-4be5-8d83-747576b2bf3b"), "+679 95 (547) 75-45", new Guid("67a0fefa-c903-4326-91fc-981d72b581a8") },
                    { new Guid("362fd090-fdee-4826-be38-84e4a1ba3c58"), "+500 01 (117) 86-90", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("36348fc4-392f-4c6e-9c7e-5ac18db3816c"), "+65 32 (950) 08-78", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("36658496-c5bf-468f-9b51-0b926329d3e5"), "+298 01 (853) 38-89", new Guid("976fe531-4ff5-4f12-8239-6646d1cdafd6") },
                    { new Guid("3676ac84-7b87-48d6-b659-6828da9b777a"), "+68 89 (804) 22-52", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("36ef33f5-900f-4276-8849-f05257e9a0a6"), "+341 64 (127) 75-27", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("372666c5-690d-45d1-a4ea-1a30862c275b"), "+328 33 (176) 13-08", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("372937c2-84dc-447b-9a1c-8583428e0772"), "+733 16 (879) 18-66", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("373ec1eb-d6ea-47fd-91cf-7b51d6faff00"), "+788 49 (691) 98-24", new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("378337b7-5258-47e0-8746-3f724e58fd72"), "+302 72 (392) 16-91", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("37a5d14b-5fa7-48b1-9e0e-65df0b94c601"), "+410 65 (912) 20-38", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("37cebc9a-5ac6-4d6a-9294-f48f07487283"), "+345 51 (638) 01-30", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("37d464e5-9f4e-4fb0-813e-8c60a5f117f5"), "+155 41 (350) 36-24", new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("37ff11c4-391c-4e59-a9f4-e52bd69ab23e"), "+409 13 (000) 07-65", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("38767487-1c6b-4632-ac7c-4d6f0a047f67"), "+172 77 (596) 66-58", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("38eca1ce-0df9-4f99-a2de-b789d2fef104"), "+807 65 (903) 77-31", new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b") },
                    { new Guid("38f28025-0f6a-4ef2-921d-5a1e7620e82e"), "+698 43 (547) 72-82", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("398f11c6-a6ac-486d-9182-ad39ef3af079"), "+115 11 (782) 11-69", new Guid("313a1b63-2c0c-411e-a611-28a27b318502") },
                    { new Guid("39cd7943-b468-4104-82d8-744f8fd9957d"), "+244 62 (906) 56-58", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("3b4bd325-cc3e-414a-a3d3-e70669e2b882"), "+530 03 (599) 47-50", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("3c4a192b-e3ef-488e-9e4a-f55019064395"), "+225 92 (824) 16-73", new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("3c813f43-ce83-4aec-a349-8c4c57428e8a"), "+621 69 (620) 28-31", new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab") },
                    { new Guid("3cd8fc04-adf2-447c-bb4f-a88cdb88333d"), "+824 72 (313) 03-16", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("3ce6b99b-524c-4415-8d82-0fca3aa96b5e"), "+498 41 (002) 26-77", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("3d2b2ae0-0257-4c05-b94b-365c5a32f935"), "+106 66 (122) 68-86", new Guid("a830f35d-bd00-4405-a2ff-9c159d51c552") },
                    { new Guid("3d6b10d7-c38b-43f6-abf1-b65750ae6e00"), "+272 44 (541) 62-83", new Guid("5f205a4d-7179-45b2-b4d7-960d6085c12b") },
                    { new Guid("3ddfaab3-92e7-4443-b062-2679931674d4"), "+364 05 (838) 01-08", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("3deb03f7-8b5a-41e4-b139-324991036d72"), "+928 85 (537) 76-27", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("3e0637e5-f81c-44ae-9046-3813675d31a2"), "+848 74 (509) 74-90", new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("3e2b92cf-ded7-418d-bb13-1d4517b81226"), "+787 22 (013) 81-92", new Guid("67a0fefa-c903-4326-91fc-981d72b581a8") },
                    { new Guid("3e604bb0-3be2-465b-8adb-07b962f41636"), "+917 26 (624) 27-09", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("3ec7022a-eee8-4f6f-af3b-7d903b7390b1"), "+647 51 (382) 23-92", new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("3f1f0b37-71d9-40d1-84f6-f2bbb44430a7"), "+454 48 (090) 03-57", new Guid("8675a226-f36f-438d-8b47-8ae515b842eb") },
                    { new Guid("3f400cd7-a24e-44ed-9c43-33ff6ae4f03b"), "+122 86 (101) 52-69", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("3fa819b6-b2c7-4368-8c33-5266d5298d0e"), "+156 70 (490) 96-36", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("4008de3c-0947-4e5c-aadb-e3b9eb3c72d9"), "+594 25 (880) 35-74", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("40128b7b-123b-470e-9821-29a18cfe9778"), "+816 94 (522) 17-64", new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75") },
                    { new Guid("40687c68-9b9a-4f7a-ae56-8bf940ce9529"), "+647 02 (926) 88-65", new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("40f1c6d3-1585-414d-a24e-c50501f9d969"), "+14 51 (011) 57-43", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("410053ac-8dfe-47b1-8339-f86ffcb6768c"), "+998 20 (281) 72-65", new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37") },
                    { new Guid("420dfcd9-d44f-4127-8045-9ae7af330a91"), "+913 27 (155) 18-95", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("424060de-a571-4095-990d-99d9cbbe13ee"), "+597 21 (404) 19-32", new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615") },
                    { new Guid("42a2acaf-d43a-46f0-91dc-d3acca7ec1c1"), "+600 87 (700) 06-02", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("434950f4-f289-4501-bd30-fd2ac0830f86"), "+483 27 (387) 93-55", new Guid("fbd1a796-3ed4-49cb-9941-db38111b8093") },
                    { new Guid("437c4857-d37c-4ba3-811a-85be9bb20872"), "+77 55 (806) 37-03", new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35") },
                    { new Guid("43999703-aedb-4f59-89a6-fee5c258dfe4"), "+145 78 (892) 91-17", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("43f8cd41-1adc-453b-9287-5bb0adf1de04"), "+304 98 (745) 43-90", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("44aba3c0-f151-428d-997c-79f53abfde4e"), "+547 10 (066) 40-46", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("44dbb699-6b0e-4bd9-ad22-503740f9d7fb"), "+933 96 (015) 59-94", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("45057c53-c680-4876-8042-8f56490b4347"), "+879 27 (498) 74-56", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("450d8bde-fb5b-4168-83c9-8d2e8e7a7003"), "+959 79 (677) 64-73", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("4562e540-67e2-439e-bf7b-3d8542746092"), "+488 35 (906) 08-36", new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("457ff23b-efca-4f4c-baa5-088358f106c6"), "+442 04 (064) 90-71", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("45a6511f-a370-47b9-ab62-9d36c20549ae"), "+960 26 (763) 03-02", new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7") },
                    { new Guid("45f60656-f6b4-4e2a-a716-065ef334548d"), "+697 35 (057) 11-78", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("4663b72e-76da-4ff9-8fd6-1d5958c80f3b"), "+94 09 (867) 75-65", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("46b03c12-a67a-4a49-8559-f73ace22b13c"), "+838 38 (316) 48-73", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("4731b25d-e1a4-499a-a476-162177708e3c"), "+912 15 (173) 82-30", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("47e10fce-7439-4168-8399-62438c45a7ca"), "+130 60 (385) 01-36", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("481f4604-a6e8-4dc6-8489-2f32d89b08ff"), "+708 64 (379) 86-63", new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb") },
                    { new Guid("48a11a79-9373-49fe-8bd4-33d8bcb753e8"), "+623 73 (327) 65-65", new Guid("bda99bb2-2085-44d0-bb75-3580176e5ead") },
                    { new Guid("48ad0b97-9161-4c1b-8abd-c27094ea5d03"), "+299 27 (314) 53-90", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("48b64825-7293-426d-b93e-46cc20369d83"), "+103 63 (733) 39-04", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("48bbacf1-3958-414c-8a74-a7a94c762f4d"), "+984 98 (475) 16-64", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("48cef907-dcc7-4b26-9d54-e3d4f233d94b"), "+69 70 (472) 26-64", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("4960218a-c13e-42e1-93fa-d368817d5f9a"), "+552 33 (249) 36-26", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("49e7ac63-d688-4302-ac97-c90c181d5820"), "+185 47 (233) 25-36", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("49f9189e-dbf4-4f74-9bdc-334c330b2201"), "+683 10 (645) 73-56", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("4a2fef30-000a-4942-ae9d-5f1783fd67cb"), "+679 30 (401) 45-05", new Guid("65012c66-d07a-40f6-9789-b100201359c2") },
                    { new Guid("4ad8fd3c-f4a7-464b-8eb9-abaefc674466"), "+535 56 (744) 93-22", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("4b0cd340-3415-4d9e-bb0d-ed9d53cbca66"), "+614 94 (861) 96-73", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c") },
                    { new Guid("4b40ae37-00c5-415e-a98d-5e6d6e417502"), "+106 95 (468) 56-03", new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("4bb0baa9-5647-4b8a-8a2b-71504e7b04de"), "+73 86 (686) 41-00", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("4bf8b65f-ae88-4423-a70d-126001ebb3b8"), "+272 60 (699) 53-92", new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("4c0b59c5-1f26-4005-a10f-e7fe03866c91"), "+339 62 (709) 34-62", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("4c1429cd-a520-4534-9572-7e7157dde37d"), "+512 44 (390) 20-15", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("4c7f271a-9b2a-4139-bd66-d43b37a2bd12"), "+148 46 (878) 09-65", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("4ca8f7bf-275e-4843-b19c-d3e696220dd3"), "+295 59 (265) 04-17", new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("4cb40e3a-42d3-4aeb-a881-1612a307e8a1"), "+340 46 (467) 78-51", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("4cc2cc0a-0181-4835-8358-7543b20fa8b2"), "+439 93 (246) 78-32", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e") },
                    { new Guid("4cca08c5-ec41-4778-97b1-6bbba9d65ffc"), "+544 70 (838) 70-19", new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("4cd1c940-ad81-4162-a12f-1d7562279641"), "+28 31 (813) 76-96", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("4d122b58-8ab5-45da-876c-1099334a1b06"), "+557 37 (618) 50-55", new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("4d38fd44-65fe-4304-a70e-fc7e7e24a2ba"), "+704 03 (984) 85-87", new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("4d948bce-e0ab-4bdd-bd2c-7559ea567fb0"), "+634 13 (683) 35-16", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("4dd2c96b-e7b9-4028-b346-e1b30712da16"), "+860 43 (080) 66-69", new Guid("3448fd6a-839f-4e6e-ae97-7df9689f904f") },
                    { new Guid("4df9d31b-0ead-4535-b7ec-c8f344400ab8"), "+665 50 (771) 57-99", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("4e25f28b-d468-4aff-bab8-ee7ab36bf4f7"), "+729 88 (924) 93-69", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("4f8d0312-d789-4227-b998-3a7b108563b1"), "+419 29 (999) 56-69", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("4fa28e32-3cc4-4719-847d-cd029c2fe553"), "+399 14 (719) 21-93", new Guid("a0c72d91-dc13-4995-848c-613286a462f4") },
                    { new Guid("500f9338-2675-47f0-86ae-cb0e5717433a"), "+457 41 (596) 78-67", new Guid("b2e8a1dc-851d-4b39-adbb-89b28991c8f7") },
                    { new Guid("50118ee5-e101-4482-9380-f032bb0f262c"), "+646 89 (385) 38-70", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("504f61d3-5dab-45f9-b33b-cefc1ec3b564"), "+814 48 (138) 66-78", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("50dfc5e7-99e3-4642-a32e-514a0fe98493"), "+882 66 (940) 56-37", new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5") },
                    { new Guid("51a33543-8ea4-443c-9eea-3e8fd25a36e2"), "+385 65 (983) 19-21", new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803") },
                    { new Guid("51bb3b4d-a1d2-45d7-a774-296bd4893120"), "+14 71 (973) 39-14", new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1") },
                    { new Guid("51dea207-ef31-415c-bdec-d3adb5755e6d"), "+996 15 (936) 83-87", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("5219ebe3-aae3-4d18-8efb-3768a6faf626"), "+322 96 (850) 31-53", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("5249da4a-f879-4920-87ca-ea03bf231c8a"), "+456 30 (855) 73-57", new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("52e92e61-b42c-436b-be23-68bfdf5591f8"), "+244 61 (040) 06-23", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("531c0d91-b401-4ca6-8213-809dea29a87d"), "+218 19 (352) 81-24", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("537d461c-2284-4e55-90d7-98e76daf7a45"), "+92 38 (032) 66-88", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("53a9ceab-47e9-4647-a8f7-f33529cd918a"), "+93 87 (878) 78-51", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("53b9027e-4ec3-4155-a41a-a7f90e8abb4a"), "+748 47 (287) 23-86", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("54e0ecbe-53ba-46e0-8592-9204b847ff11"), "+97 29 (870) 51-81", new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("54eaa348-8398-47f6-b555-c4e936c1227b"), "+992 75 (807) 06-47", new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("553115f4-39a3-4572-99b2-62c913d7f97d"), "+472 60 (943) 22-58", new Guid("74b3dcc9-46b9-432b-a105-af04273b540f") },
                    { new Guid("55964e41-87ba-49a7-83d4-58aab15e5e46"), "+965 18 (389) 38-43", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c") },
                    { new Guid("55aefe94-36ba-4207-9b69-3d1fd76a7d91"), "+393 43 (072) 09-94", new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("55e3ddc5-f6b4-46e5-81ea-feddee80e82d"), "+62 19 (627) 75-57", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("561f1c64-e212-4a4e-bb2c-c3d7d181b99b"), "+807 36 (437) 10-85", new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c") },
                    { new Guid("563a513e-f3b8-4074-85e6-9e280db1dea6"), "+674 79 (753) 15-03", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("56c80074-594a-4ef9-97f4-567f75de1543"), "+576 32 (803) 68-46", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("57154878-7e33-4ec1-9bbe-23bc10657a0c"), "+601 09 (649) 03-31", new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("5727f448-8267-4a47-931c-61cde451f713"), "+795 35 (840) 12-49", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("577cdb09-8d43-467e-b298-319c2a0a080a"), "+906 18 (030) 65-72", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("57e66e27-3f8b-48af-9918-f4fd5ba7090a"), "+514 79 (293) 73-22", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("580aa976-bde8-4bc3-87a5-bd66d2c88997"), "+782 71 (978) 84-10", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("58bbd369-6cdc-486a-9c12-24a80ee52ac3"), "+211 03 (897) 72-66", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("595daf91-3c9e-46fc-89dc-15b7854f0ed2"), "+629 73 (227) 85-04", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("596b0b5b-77eb-41e6-813f-07714f2fb859"), "+315 96 (184) 29-95", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("5a87b153-5b41-42a4-af26-21eef7aac5df"), "+803 57 (523) 05-16", new Guid("65b75971-a1a6-4aa6-ab9e-549cc658a27a") },
                    { new Guid("5a8b6ee5-d39e-4031-a132-657470ce501d"), "+25 83 (444) 02-65", new Guid("f50dbc58-9b0d-479e-8402-e939027091e8") },
                    { new Guid("5a97709b-4741-42b0-914a-5685ffd8969c"), "+318 25 (208) 06-56", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("5b3c12e6-f7f0-4d93-a652-816e322feb67"), "+213 80 (817) 12-43", new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("5b6b2f92-7e5b-492d-b76c-a960fc43dda4"), "+357 66 (645) 46-93", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("5bb3a5b7-d94a-4f4d-a907-7d73584a7440"), "+303 87 (390) 20-65", new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("5c1b7549-dbd3-4a90-bcc0-2d64dc409b62"), "+90 32 (335) 48-29", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("5c81b615-fef3-445b-86fa-4fe149850408"), "+893 81 (921) 57-29", new Guid("3fcb56ea-7a94-49ea-bdbe-8c7062d267e8") },
                    { new Guid("5cf86db4-ea02-4dda-b277-800a0af6b3b1"), "+589 63 (114) 61-89", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("5d26df1c-70da-44fe-94ca-c739008c81e0"), "+713 55 (261) 77-94", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba") },
                    { new Guid("5dc7d355-9975-41ce-bc6d-ec2caf32c7ba"), "+520 15 (743) 32-80", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("5e3d4a04-cd51-4f33-aa4c-9ea3c03ead52"), "+295 21 (505) 38-56", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("5e6bf12d-38c4-4614-8643-34bb322eb756"), "+163 51 (091) 91-90", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("5ea77271-0fb1-4d3c-ba6d-324072f4314d"), "+200 23 (090) 18-65", new Guid("18971e31-ee25-41fd-bafa-129547aefc10") },
                    { new Guid("5ee29072-771f-48fa-9465-d52433787df9"), "+348 25 (112) 35-07", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("5f00ce1c-74ab-4aa3-a851-bb834f4817ca"), "+539 96 (711) 94-85", new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328") },
                    { new Guid("5f0f7739-172e-4dbf-8760-3eb3b3803dc1"), "+233 67 (641) 41-87", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("5f3d4f2d-0ad3-4c3c-b5ed-0d53953eef70"), "+321 27 (397) 42-31", new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("5f4e522d-c6d1-4c85-82a5-96f2fac3a6c8"), "+178 02 (023) 85-49", new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245") },
                    { new Guid("5f6a29c7-1d72-4954-932c-490e8ab6a5c6"), "+888 67 (877) 70-67", new Guid("5eee55b9-5646-493f-9596-98a24b7f6c5c") },
                    { new Guid("5f8799a5-42d6-4d86-a27d-c6b5bc6c74c9"), "+89 39 (865) 77-92", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("5fb0bad5-db85-4d3d-a8b9-a6debd9e4468"), "+667 15 (234) 34-19", new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("612753da-844c-48bb-84bd-6e2452d8e7b9"), "+786 32 (610) 59-18", new Guid("d76ea3cc-fe3e-401d-b716-c63239f30079") },
                    { new Guid("6132fb39-4b03-4da8-9030-75937e182009"), "+305 84 (634) 21-16", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("614e0a83-1ef7-4435-bd31-5efd02117b73"), "+540 38 (625) 66-04", new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("615fe161-ed56-4f16-b4f9-4cb666f812df"), "+226 72 (139) 64-78", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("61e2437f-75fc-4d7d-bf61-0556f378adad"), "+644 48 (643) 77-70", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("61f1412c-bdfe-450b-a397-a7bce6b99ad4"), "+925 05 (965) 75-06", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("62ac528d-614c-4847-9eba-50db625d88e1"), "+437 18 (179) 99-11", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("62af4715-1fb3-407b-b151-018b24272eec"), "+257 01 (065) 84-13", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("62c6866e-b742-4354-9849-7ffc444b7341"), "+640 22 (452) 64-63", new Guid("2a7af252-1892-408c-8a62-8885f15e7f65") },
                    { new Guid("632a1084-54ce-4eff-8599-1191caf157e2"), "+903 61 (965) 56-06", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("6365c5f5-2c12-40f9-9c10-319a3ed30079"), "+14 88 (176) 47-76", new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e") },
                    { new Guid("63e61417-bc42-4245-9b32-e364cf284c21"), "+510 14 (330) 42-74", new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("65629e4a-fb93-42b2-bbd3-e1710b1a434f"), "+455 57 (333) 13-10", new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911") },
                    { new Guid("656dcd48-a4bc-408c-84ba-60990f99fec4"), "+284 63 (918) 10-20", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("65945eb0-9ac4-4276-bd0a-4bf630dc990c"), "+735 18 (107) 50-63", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("65a60939-1f7b-48c8-85d1-7d909fce1af9"), "+603 33 (829) 56-84", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("65a9cee0-630c-4eb7-8375-9d15854d5193"), "+96 91 (698) 82-78", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("65d0238f-4c69-46e6-ae39-25b8d5b3b2af"), "+391 34 (203) 94-97", new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("664116a6-8776-4c44-8201-72cf56a8d19d"), "+708 71 (952) 00-63", new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb") },
                    { new Guid("666c359d-fb95-4830-9a4c-895639b67247"), "+219 92 (939) 03-31", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("6693a920-66e8-4c68-9af7-5e34a9f4cce4"), "+325 14 (835) 22-45", new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("677fab11-5558-47e0-b62c-8d2b9821ead9"), "+627 32 (224) 01-63", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("67e9b20c-c28f-4e85-8d59-9e6d4663cd1e"), "+48 42 (526) 71-00", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("68224d7d-de0b-4554-a38f-4d76cd01bdf7"), "+313 45 (144) 04-28", new Guid("6794323c-bd24-47dc-9e1d-da57b3fbc856") },
                    { new Guid("68302db6-c389-432b-a372-958a12f43017"), "+628 82 (517) 94-09", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("693dd081-a238-43b0-a0ab-05b4273c7fb8"), "+191 93 (653) 27-68", new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192") },
                    { new Guid("69f72d22-dfcd-4b34-969d-0401f6480745"), "+44 73 (006) 01-03", new Guid("b5faf381-4d06-441c-accb-ef3e2efeee6e") },
                    { new Guid("6a268e5d-4739-4cdc-aa48-a443b3055a89"), "+843 00 (682) 96-46", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("6a28ff66-01f4-4139-b73b-72d1ef4ccdca"), "+749 71 (356) 21-82", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("6a524e12-a617-48a7-915f-7e0c68f02d61"), "+213 94 (012) 57-31", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("6a6d5961-3c3f-44c5-8ba8-a4816d70ea02"), "+536 62 (502) 64-47", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("6a81b412-50c8-47ab-a532-1a2e2654d5b1"), "+771 64 (450) 94-63", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("6b01422d-1fa4-4d80-a1c1-32a34542321b"), "+1 51 (152) 05-93", new Guid("7cc750bd-ad3e-45be-92e6-0cfa33ab4f0a") },
                    { new Guid("6bb18808-1999-42b8-886d-90e1b9e0d686"), "+934 36 (132) 68-82", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("6be9dd06-0db6-47fc-9b84-0d10b97d6fac"), "+559 88 (260) 57-79", new Guid("ceed1ac1-4066-4f64-b57f-8ea666cf2911") },
                    { new Guid("6ca1faa7-097d-458b-8ccc-2c5e91171954"), "+864 90 (304) 15-32", new Guid("57fde852-8e91-4713-955a-cd98c7327f5a") },
                    { new Guid("6ca5ec59-8d1e-48fb-b5fd-e997bcbd05cb"), "+579 15 (144) 34-98", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("6ca7f5e2-917e-4e6e-898c-826ea1af7dc8"), "+394 96 (404) 50-69", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("6d3fbe4c-9344-47c6-b2fd-ca74e5f1e103"), "+510 50 (269) 41-83", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("6d96636a-5a47-46dd-914d-b27a79ef0cf7"), "+380 02 (866) 26-21", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("6e012139-9214-44af-931d-c3d1273d81c3"), "+245 37 (399) 24-30", new Guid("13d3c362-fe79-46c0-ac33-48cb2695dad0") },
                    { new Guid("6e1889ac-1527-41d0-8f5c-38366a3c5563"), "+78 95 (694) 36-09", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("6e6f01b6-55ea-47b7-b07d-5b3cd1468386"), "+686 21 (441) 22-60", new Guid("a15d600b-03be-495a-bbd0-2e082c6c6b75") },
                    { new Guid("6e9621e5-3568-4637-8bbe-2615251dc837"), "+803 19 (301) 15-52", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("6f04f04f-3cc2-4b38-82d8-ad5d12b31a0f"), "+437 53 (734) 38-16", new Guid("c306f417-6568-4dd2-b7ca-397bae4345ad") },
                    { new Guid("6f0f9b0f-d760-498a-93c8-a48298430ddc"), "+853 63 (885) 70-82", new Guid("049182ed-f5e3-469d-9878-36594ec23de3") },
                    { new Guid("6fc375ca-4305-41c2-aa1b-de7db4f8954f"), "+426 42 (087) 81-81", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f") },
                    { new Guid("703065f0-144d-476c-aa17-22842804337b"), "+479 67 (144) 39-89", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("7051fa5e-3dc6-40d6-96dc-c643aee1e4b3"), "+847 17 (461) 81-11", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("7084805a-7669-4a25-bd0a-c63f7ba44c1c"), "+605 96 (560) 24-52", new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f") },
                    { new Guid("70d6e813-af55-442f-a9e2-bf0ead920f34"), "+300 25 (776) 12-00", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("70ed8f5f-7ff3-4ce1-9dc0-b605c4ea9256"), "+226 89 (165) 02-67", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("717ae3b7-73a0-4ef6-90e8-5fc5757ee189"), "+721 28 (432) 14-11", new Guid("db79945a-0e64-4c97-801f-a38a1e357d12") },
                    { new Guid("7188ac28-e69a-4520-8ba9-ad82633f6627"), "+226 54 (653) 62-41", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("719932ba-e2c9-45c3-a0ae-067099529c5f"), "+415 58 (159) 89-24", new Guid("93fc11aa-1d50-4309-844c-1154f207d374") },
                    { new Guid("71b3df0b-24c4-4f31-a10d-aacb0bca29da"), "+832 45 (240) 16-91", new Guid("ce376eab-8569-4f9a-8425-51e1310948af") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("71c88e44-5d03-4bca-82d9-a6bbfa3c2e38"), "+776 70 (984) 21-54", new Guid("61fe1433-1b16-4004-8246-4e030b366c6d") },
                    { new Guid("71e1e88d-d6a7-469e-beee-27bf1cd22ca9"), "+601 23 (809) 64-67", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("7283822f-e0b7-49aa-b68d-4b8abdcaa293"), "+746 16 (078) 35-45", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("739fc8cd-239b-435b-8b2f-564dd77bd76a"), "+408 16 (310) 05-51", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("73a5029e-3d43-4d36-a712-12efb268716d"), "+541 93 (052) 42-23", new Guid("ef94ab52-1bb3-4a24-9d04-5c74d67979ab") },
                    { new Guid("73f9084c-c5ec-42f3-9753-48a19eace183"), "+457 89 (597) 94-43", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("742d15e7-93e6-4bb7-90ea-46b039a069ec"), "+657 05 (341) 33-94", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("743015f2-c419-4760-aff4-d1a534b4bb48"), "+79 14 (706) 64-90", new Guid("53792862-da15-45a1-b0ef-d025a7608026") },
                    { new Guid("754a3f50-4131-44bc-83d2-fec2d49382ce"), "+155 63 (545) 91-10", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("755beedd-2177-4375-bb42-5653a0161c9c"), "+736 85 (514) 76-11", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("76e648fc-d878-489d-acdc-ae54e999a943"), "+873 18 (500) 73-30", new Guid("6c64e50a-5622-42b2-90ce-1e1ba371790e") },
                    { new Guid("76fa218b-3787-42e1-b179-71898decae2f"), "+348 77 (783) 03-97", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("77e44ac5-a850-4e05-aebb-f5c183bc7867"), "+78 01 (609) 30-70", new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3") },
                    { new Guid("781106a2-8b36-48bd-974b-7a9fe9511c83"), "+981 36 (414) 93-62", new Guid("b6691519-38b6-436a-a19c-602dda7868aa") },
                    { new Guid("7850847c-e8d9-40d1-a605-bd63e34c0098"), "+656 61 (157) 91-79", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("7857f2a2-6280-464e-b32c-29a34abc9dca"), "+813 66 (278) 71-37", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("78d09a69-bf4c-45cb-a9b5-afbd0502b154"), "+663 65 (801) 73-09", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("7919e8ca-f1ac-4d67-82aa-24349179d43c"), "+989 41 (364) 00-80", new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("7982ace5-5522-41dd-a21f-89f2622dc18e"), "+846 86 (699) 34-88", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("799b3fb2-44a2-4a3f-a482-d8717a2c64f1"), "+797 55 (546) 54-59", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("79bf937c-1fc1-4630-9677-22df2e49979d"), "+929 26 (752) 05-62", new Guid("e9666f7a-5783-4cde-8beb-07503d2d10bf") },
                    { new Guid("79ce5807-aa18-4cc6-a464-ad7507b4d7de"), "+823 21 (685) 48-03", new Guid("79085775-95d9-4cbc-a209-cdc6cd4780b9") },
                    { new Guid("79ce9f71-2d4d-4d5e-9abb-5d17a0055c4e"), "+879 51 (787) 87-39", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("79d771b6-c630-4c8a-8909-4b5f4009cbb0"), "+476 34 (209) 59-79", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("79eaa39e-5a40-42f8-becd-43195db7c969"), "+471 94 (907) 28-43", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("7a19484f-bf75-4132-9b9d-90b2756c6b3a"), "+890 01 (340) 17-84", new Guid("1a3e18a5-4878-4d96-8b5d-61742d5242bf") },
                    { new Guid("7aba9192-a63e-43af-b688-8e2443ec9dba"), "+16 72 (098) 62-98", new Guid("0f432380-a89c-4564-a477-a1ed20795e01") },
                    { new Guid("7b40cf35-9184-45cd-bf01-b8e4247f70ff"), "+413 27 (930) 07-22", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2") },
                    { new Guid("7bd11ad8-084b-4811-ab8f-935d714dc1da"), "+263 94 (395) 63-48", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("7c8acedc-5df2-43e4-a7c0-47f705cdc570"), "+535 70 (363) 53-85", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("7d0b7f15-3fb5-42e8-8863-b22b0bf5823b"), "+103 34 (507) 91-57", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("7d772608-fa98-40d2-b1a4-a10871200ed2"), "+667 80 (037) 36-42", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("7deda63f-42ed-45d7-b8da-11cc76885379"), "+473 24 (976) 39-66", new Guid("f50dbc58-9b0d-479e-8402-e939027091e8") },
                    { new Guid("7e12711d-b5cc-4f8d-95e3-66167d429532"), "+180 70 (534) 49-81", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760") },
                    { new Guid("7e4f7df0-72c2-4269-89a5-ec972694bc46"), "+574 57 (152) 74-22", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("7eb2724a-4973-4780-88df-d818c7d969aa"), "+252 85 (300) 85-05", new Guid("5af25f66-c987-4954-94a8-ddcedc1bea52") },
                    { new Guid("7efb2208-415c-4f63-badf-c0c0c763b726"), "+417 50 (132) 83-97", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("7f100e29-0e00-4961-a13d-45e91b6dea29"), "+759 90 (341) 95-53", new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("7f3a1736-4b45-4d71-a0e0-cb97d9dac0c7"), "+943 12 (441) 80-79", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("7fcac5f3-e501-4ed9-b322-8de890f0a767"), "+789 55 (241) 66-83", new Guid("b80d479f-1611-46e2-a055-1de659d203b8") },
                    { new Guid("7fd3fa24-679a-43d8-8f58-152afdacaf48"), "+339 93 (284) 14-40", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("7ffe19c2-c4d1-4666-8c53-eb2aa4ec74ef"), "+309 11 (457) 77-63", new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("809064d0-feba-4558-91ab-92ef5efdb783"), "+496 99 (355) 63-70", new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("81053ecf-16ac-4e9e-970e-dd439fafe844"), "+561 87 (346) 73-46", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("81c19ca9-e593-4dee-bb5c-28b30b034b46"), "+519 79 (897) 18-26", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("81f810da-9197-4f9c-80b7-df082c604f8e"), "+330 31 (317) 22-17", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("827f851e-1994-4a4a-a625-747d06a585e0"), "+838 65 (697) 55-05", new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a") },
                    { new Guid("82e35717-1d6f-49c1-8b73-d87ce2a62693"), "+108 01 (458) 99-42", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("830c06a0-a78f-44bf-9671-af6c334987b4"), "+432 51 (474) 64-69", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("837fe482-b46c-4b4a-b208-77c3ea6ee37b"), "+268 83 (915) 59-51", new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("83fa44b0-d63b-401d-aad2-6d608561f3d0"), "+728 94 (150) 14-12", new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714") },
                    { new Guid("855a7e78-7a52-4cb9-9470-7c4ce65c350e"), "+590 79 (947) 15-04", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("858eaeac-be6c-492c-8e25-4b5fb9ff0062"), "+836 07 (450) 78-67", new Guid("4aab10af-ca8d-4303-aa2e-aea5ead66daa") },
                    { new Guid("861f64ea-6cb3-4a09-a611-af555e47dec9"), "+218 39 (231) 63-49", new Guid("ad5b9802-88b7-4c47-b138-778817c4050a") },
                    { new Guid("8638b472-438f-4c07-834a-c4af1530d2c3"), "+953 00 (606) 93-19", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("87326678-32a3-4559-8fae-7cd67787f993"), "+349 38 (709) 42-55", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c") },
                    { new Guid("87350a58-5d15-4faf-86ad-39c459242a4a"), "+509 29 (123) 55-80", new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("87991519-9584-46b5-95a0-dd3c417c287a"), "+209 29 (513) 12-65", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("890aeb9a-b4ee-43ed-96aa-a9865225c48c"), "+131 43 (285) 55-64", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("89477bbc-a929-4597-b489-41649e613545"), "+328 26 (109) 46-37", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("894b1993-11cf-48c5-aa20-8390d3bad063"), "+80 89 (713) 88-78", new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8") },
                    { new Guid("89ca1b75-06f6-4aec-9040-ede10337e4de"), "+490 70 (422) 14-28", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("89d7412d-1339-4a4e-b792-696a7ba30a10"), "+38 90 (387) 86-23", new Guid("d86052f3-3dc6-404c-abd6-5fd51d4db0f5") },
                    { new Guid("8a646475-35e3-40da-8e30-3a3f316d75f2"), "+361 90 (145) 22-77", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("8a7218ab-2c01-428b-b42b-06bc24e08cc8"), "+490 92 (952) 35-16", new Guid("53792862-da15-45a1-b0ef-d025a7608026") },
                    { new Guid("8a9f1f7a-3b65-4833-81d8-bc164219174d"), "+348 86 (439) 37-98", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("8ab6e96a-82ba-45c8-ae96-67d39eb1573f"), "+973 30 (690) 99-59", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("8ac6f9b0-88b4-47d6-8381-9fd3e3705d8f"), "+236 96 (134) 93-90", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("8af305a9-bcd7-442b-9142-56fd4801642a"), "+476 91 (855) 09-95", new Guid("8732d9ca-5bfc-4b54-b7fe-8fdeb43ddae7") },
                    { new Guid("8afd8e5a-08b9-4ca7-b7f4-4d77df5c596f"), "+966 50 (032) 48-99", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("8b288ded-664e-41de-a39d-ba986a9e6ee1"), "+410 36 (291) 36-01", new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("8b4e6ebc-ba77-481c-bb75-593f9d305e04"), "+265 72 (228) 59-39", new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce") },
                    { new Guid("8b594cf4-fde1-440e-ae70-7285476c55ae"), "+317 20 (091) 71-70", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("8c9e8c53-30bf-452f-9d61-4635f011d6dd"), "+736 47 (252) 21-75", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("8cc6a54e-dace-4964-ac61-93f5c3aeea49"), "+552 01 (321) 50-43", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("8ceb4bec-7705-43cf-b796-e9b8b3010d86"), "+634 07 (555) 24-75", new Guid("f9be8b7b-f8fc-4f1a-a135-f835e9a58328") },
                    { new Guid("8d0ad2d2-e450-4076-9224-528ec1b37d3b"), "+629 13 (601) 49-54", new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("8dc245e4-40a5-472c-8d59-c47fcd5589e3"), "+466 62 (503) 14-80", new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f") },
                    { new Guid("8dd16e69-f46b-4e41-8b3b-4e9599c346c1"), "+855 71 (085) 55-83", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("8e2958b1-18ee-42d8-ab81-81a6fac3e432"), "+189 45 (315) 46-91", new Guid("2a479078-62e2-46d5-ba22-3baa9097c4bb") },
                    { new Guid("8e435344-1c54-4bc5-88bf-ce5bf3feed84"), "+246 11 (818) 50-02", new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("8e4cf8d7-ba7c-4005-ac8a-78071634250e"), "+212 42 (745) 67-74", new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("8e4e519c-1fad-44be-9f6d-9695e1612a2c"), "+135 62 (301) 83-71", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("8ece7f1f-0653-4f2c-89c6-f8137d233761"), "+253 10 (771) 43-92", new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("8f1488be-3b86-4e7d-a0a4-219679d86534"), "+350 66 (496) 13-87", new Guid("8c8cac38-5df2-4fee-9382-613f7e00f596") },
                    { new Guid("8f80e8df-b17e-4642-8cb2-b11d3c0c4381"), "+138 65 (622) 66-21", new Guid("24292576-82c4-4a01-961e-e050d58bf4a8") },
                    { new Guid("8fb05bc3-967d-425a-b738-5e089d7f3666"), "+64 68 (654) 09-16", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("8fbf4f2b-1ae1-47b5-8baa-46649baa80d0"), "+987 59 (120) 32-13", new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("900e2fa8-ecfe-4ee2-b4c4-823fa2b3a084"), "+617 38 (844) 86-91", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("9014de85-f018-4dc0-81f8-9d06739fb2e8"), "+617 28 (316) 34-05", new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a") },
                    { new Guid("902579cb-a535-4dda-a777-d0a7305d37fa"), "+108 19 (450) 17-26", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("90810923-7554-45ac-a372-a3acca9c9ece"), "+859 63 (972) 81-10", new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd") },
                    { new Guid("915971ef-c6f9-4eba-85ea-75f641783b8f"), "+177 69 (241) 60-81", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("917a2033-d736-4c74-a1d0-ee350b6ee6cb"), "+104 11 (516) 06-24", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("91c97d4c-1c14-46f3-8fc0-8d092c8870ff"), "+747 49 (546) 29-07", new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63") },
                    { new Guid("921cdebc-2862-4dd8-825e-d37202634329"), "+350 92 (875) 50-57", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("92755152-899e-4bb7-bd01-6680f3773d90"), "+57 84 (156) 40-75", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0") },
                    { new Guid("93a959fe-d31b-40ef-a355-1ed3f2c7f8a8"), "+847 04 (522) 54-90", new Guid("6c848161-d49e-4d9f-90e6-b96909ccfe25") },
                    { new Guid("93b95d14-3ec4-4492-ad78-a0bd8a2d495a"), "+639 37 (312) 84-22", new Guid("313a1b63-2c0c-411e-a611-28a27b318502") },
                    { new Guid("9490c6f3-e68a-4bc9-b929-71592bf005be"), "+796 43 (462) 97-45", new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("94c70d42-cbfc-4f2f-a96d-f96c62230c26"), "+96 67 (847) 34-95", new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("94cc8482-dbc0-4c70-a9ec-dcd1d2a1bd81"), "+159 46 (328) 87-63", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("9501d45a-1290-4717-aeae-38ccbfbef2d7"), "+937 88 (001) 01-07", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("9517dd32-c859-45d3-95c7-fdb0d191c1f1"), "+978 79 (458) 39-58", new Guid("b4632e52-6f10-482a-a513-7b90b527a6d8") },
                    { new Guid("956fd317-99e0-4069-b73e-de832221129f"), "+915 86 (838) 76-33", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("960763ed-4cfc-40f9-acaa-af432939781d"), "+777 34 (884) 65-02", new Guid("91df0e41-5325-4c59-a8fe-70430d5e2615") },
                    { new Guid("96103e76-f27b-4e0f-b085-43425e2ad110"), "+647 89 (156) 08-09", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("96768835-cb03-4391-849f-6a65b304c806"), "+287 17 (304) 29-50", new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("967bac0c-ae2c-438a-85d8-d3468f2b0ef4"), "+846 54 (174) 91-27", new Guid("913aac82-79cd-4930-833a-d54464607133") },
                    { new Guid("971c50ea-07f7-4796-83ad-c4cf17cc601b"), "+377 57 (637) 25-69", new Guid("23ef0dda-cb68-47d7-8612-f5cf483c710a") },
                    { new Guid("9774c1da-92b3-462c-9d47-8c146bd18b25"), "+7 35 (557) 14-40", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("97c66ac9-751f-4a3d-afde-35393fd12cab"), "+161 52 (630) 85-62", new Guid("51274356-5ef0-4e46-a687-716d200f49e1") },
                    { new Guid("980234e8-c3b3-43e0-99d3-f12390f35fb4"), "+786 20 (987) 93-61", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("98449852-ed48-409b-b823-8af027891949"), "+546 84 (572) 91-76", new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("990f0970-a849-4658-bd96-09044627e2ff"), "+656 03 (101) 86-08", new Guid("6a9e26e3-d154-4c35-823d-eb06a37ad3d2") },
                    { new Guid("99192e93-03f1-41e1-9497-891cdf2c5474"), "+69 57 (018) 69-96", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("9920c8ac-6a71-4014-be93-32fce6802efd"), "+410 23 (024) 79-79", new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e") },
                    { new Guid("99441366-c606-40a8-840f-77b59dd5984b"), "+869 96 (769) 07-33", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("996c69ff-4e1f-4844-afbd-56f6b4531c03"), "+432 79 (892) 18-10", new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("99c00d39-d028-434b-9db5-31ec71c36e36"), "+500 49 (660) 05-35", new Guid("16c33e99-71e3-4c6e-84e5-3e3baea6a245") },
                    { new Guid("99f5d267-d06e-49b9-a393-e5b9495796c2"), "+479 26 (915) 52-39", new Guid("fe114181-f2e6-4432-86af-f7d827b491ef") },
                    { new Guid("9a372bae-3351-4b43-baf8-b0e6f267d756"), "+140 59 (472) 35-34", new Guid("e3a1d866-9dec-4c2c-83b9-74cca17f7360") },
                    { new Guid("9a5196c5-31f5-44f9-8ca7-9dbbbb844220"), "+778 64 (885) 71-41", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("9b17bbbe-c4f9-4f65-8b18-8ac2f56d6284"), "+916 27 (025) 17-19", new Guid("2a7af252-1892-408c-8a62-8885f15e7f65") },
                    { new Guid("9b1e6f2f-eba9-43b4-9c43-91e68ee72aab"), "+664 92 (263) 56-07", new Guid("848ffaea-320e-4ca0-8bc7-c6abc34b6a91") },
                    { new Guid("9bac847c-e823-4626-b16a-a853b214823d"), "+365 14 (990) 32-29", new Guid("b6691519-38b6-436a-a19c-602dda7868aa") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("9bc54c4c-55a0-4e23-909e-37dea6b323bd"), "+405 92 (506) 86-31", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("9bda3afc-2323-4666-ac49-5b2ea2642a5c"), "+254 43 (129) 02-03", new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("9bddb45f-8851-487d-aca8-093077f6097b"), "+20 83 (623) 85-06", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("9c29334e-c037-43b5-bb0b-aa7b819a7ce4"), "+810 61 (768) 71-54", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("9c8242bf-1292-4c50-9f81-53fed3bf8841"), "+182 78 (662) 41-04", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("9cb7aa1a-940a-4e5f-aef3-b86ddbea6ee1"), "+758 26 (410) 18-32", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("9d1bc0a6-d0c0-4762-824f-488ff699d0e2"), "+254 38 (272) 81-43", new Guid("501f3d9f-3cd5-4222-85e5-a9fcd293b0e3") },
                    { new Guid("9dbc2bb0-bc57-4ed5-90f3-f18278d19c51"), "+349 98 (936) 39-36", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("9de0d56d-350d-4aec-a44d-25b8e34c4de4"), "+652 24 (537) 67-07", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("9e244612-c224-4b1f-804b-f177538a89fe"), "+111 78 (557) 48-41", new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2") },
                    { new Guid("9e5bbc6f-3a04-4d75-acf8-b39ccfe5b9e7"), "+704 51 (758) 68-05", new Guid("de7d9783-5299-4552-b426-e13c1b4a4995") },
                    { new Guid("9e9b0c16-f176-4fb7-96fe-62ac2d71aada"), "+964 08 (720) 94-74", new Guid("91ba792d-3cc9-4ff4-aed7-56d84317165f") },
                    { new Guid("9eef698f-e1ff-43e8-8b83-ecb4656e6bec"), "+393 42 (086) 70-72", new Guid("de984da9-04b5-4417-b831-fdf348dbff4e") },
                    { new Guid("9ef4b890-9e80-4460-8f18-a30dfc3c90bd"), "+733 63 (457) 21-54", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("9f21e388-d930-4625-9def-45a2a8f205d1"), "+492 96 (876) 43-57", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("9fcd02c0-4b25-4a1e-a68c-f2321f1e52f9"), "+612 44 (268) 48-04", new Guid("851ad53c-d1f2-4578-ab73-e3994d91ea6c") },
                    { new Guid("9fd06e2c-2da2-4c62-b7b1-98107503833e"), "+100 09 (213) 42-62", new Guid("03b6286b-a222-4006-aeae-7e0bf3a93803") },
                    { new Guid("9fe2a5cc-dced-4e5b-ab67-c4caff64676b"), "+255 07 (314) 94-07", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("a01b9f35-8555-4860-9eec-3fcb0a910a43"), "+943 81 (238) 04-04", new Guid("02ed36b8-c264-4631-8a6c-eded4ccd6ecd") },
                    { new Guid("a0526967-dc9d-4685-b1d6-b8326ff2618f"), "+238 14 (348) 93-95", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("a06fdfe9-ae87-4281-a9d8-baada4d106d4"), "+735 95 (833) 23-76", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("a0831926-69af-4a4b-a517-ae29d5176a8b"), "+588 84 (713) 36-03", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("a084e916-bd15-483d-b9f7-d8c77587f98b"), "+86 46 (556) 95-54", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("a0ab0a29-7518-45de-af37-11143b17a67f"), "+903 68 (665) 94-81", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("a12d93cb-3ebb-4d37-b3c9-6ae9bb87bc89"), "+935 85 (654) 53-18", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("a136309d-4836-4f55-9159-15524fdc1916"), "+8 67 (701) 29-83", new Guid("a7832611-a778-4dda-b7ac-107f3e36ae7d") },
                    { new Guid("a1471f1b-545e-41e1-aa1b-d524bef592c8"), "+425 54 (555) 34-59", new Guid("5c7d5a0c-ea33-4a6c-b1b1-53f9dc0de9c8") },
                    { new Guid("a1bc5ef5-edda-477a-a32e-b79311483e12"), "+183 63 (814) 85-24", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("a231758d-c053-4111-9901-de17952cbbb3"), "+414 81 (921) 35-57", new Guid("18c2ccbe-5dc2-4a83-ad24-5502080abba9") },
                    { new Guid("a29bcce9-0a80-410f-bbba-8f7d5ceac183"), "+611 31 (660) 39-03", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("a29cf071-a3df-48ee-9b5f-e17aa3008b2c"), "+150 52 (909) 02-26", new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("a2d11ff9-576e-4f58-93ce-1dd4c04eb30d"), "+675 12 (210) 94-76", new Guid("85215cf2-0531-42a0-9d1d-e777ab2c2e12") },
                    { new Guid("a30799b3-5127-4d8f-9dc9-55d1b1435487"), "+397 16 (495) 78-85", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("a4294225-6a91-4acf-ba49-fcf9a3c7f088"), "+242 86 (553) 83-90", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("a61be282-566e-4628-bd01-4242a53c83b1"), "+104 52 (505) 11-91", new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0") },
                    { new Guid("a620cafa-1407-4ca8-b437-8e19e37633ef"), "+695 71 (717) 47-60", new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("a6242ad0-bf6f-45ba-9236-657ca1f67bc2"), "+765 30 (655) 42-57", new Guid("b4d63d75-5dd6-4e49-8bbf-c2aaed4a59f1") },
                    { new Guid("a6323e90-6581-4ae0-8278-f86c12d09f52"), "+122 02 (373) 17-14", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("a71f48c7-bc71-4a1e-8adf-ee0cb25479d5"), "+129 65 (373) 81-46", new Guid("b754aa13-8ff8-4ee5-acb1-745727afa2ce") },
                    { new Guid("a78bfd9d-3cc1-4e19-b9c0-0838caafa8d2"), "+886 52 (012) 32-51", new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("a7ac4937-ef34-4b82-856d-cd6eb22ce786"), "+723 55 (614) 03-55", new Guid("20279754-e2e9-418a-9e21-6f4a1d452e08") },
                    { new Guid("a879ce14-4aa4-4379-b593-5c3d09b6d423"), "+157 35 (253) 24-35", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("a8dd8afc-e14b-47b9-b23b-4a27778dd683"), "+223 39 (295) 80-20", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("a8f9e0ea-2ed2-48de-80b5-4f3a5a41257e"), "+408 10 (155) 23-42", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("a947ccd4-053a-4780-8dd2-f8d325b2216d"), "+41 26 (326) 17-93", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("a9ab255d-f488-401f-be68-f78a36a1bc5e"), "+319 95 (872) 62-27", new Guid("93066ddc-077c-4f62-a318-dcdd1a8e4b9a") },
                    { new Guid("aa08e2d1-3cd2-4ecc-93fd-cf2e222fcfeb"), "+489 25 (894) 45-69", new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("aa8e445f-486d-4486-b7be-d8ab2e6ad530"), "+588 51 (340) 14-93", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("aaa26d7d-bb43-4771-b3b3-e60437acad03"), "+952 83 (932) 17-53", new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("ab8ff635-4905-4732-a1d7-4fb23cab9995"), "+385 95 (362) 77-51", new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("ac195502-9ff7-4ad5-bd52-997f2324e350"), "+710 63 (688) 90-72", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("ac6715f2-ec28-4d99-97e9-826bf50b6afe"), "+950 29 (883) 20-51", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("aca5235e-5fb6-460a-8331-7b7b31e66f65"), "+476 07 (751) 49-89", new Guid("0c8e83a6-5428-4513-a361-f1d637e56c27") },
                    { new Guid("acae1e02-2c14-48db-b67d-ff6679d0c51a"), "+498 95 (176) 18-17", new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("ad2f2707-bf97-4c7f-bf3e-8a72782510bd"), "+395 14 (261) 63-01", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("ad8afb09-d155-44fd-af91-ea6185824f06"), "+372 63 (520) 46-16", new Guid("574a2dd5-792c-46cd-ad95-60fa443b148f") },
                    { new Guid("ad92f7c3-d394-4be4-80ad-0f1544d674d4"), "+903 04 (107) 71-92", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("ade57be4-1f33-4aa7-8faf-b2357db1c2ac"), "+713 73 (919) 98-67", new Guid("6e90baa7-8b75-4108-acaa-210af704a12f") },
                    { new Guid("adfd8946-942e-4210-ba38-fe13bc3cfdc3"), "+334 80 (593) 08-21", new Guid("f302ec88-6a4d-4a0c-a04e-ea2636059197") },
                    { new Guid("adfdb35b-e83a-4717-9361-b0c59a6a2090"), "+202 93 (834) 53-63", new Guid("c2ccabd6-cec6-4ba2-852b-9ba44b92fe7a") },
                    { new Guid("ae1fa1ce-0661-44f3-b5dd-1a0e54b34959"), "+368 06 (739) 80-33", new Guid("f7641b45-1552-415a-98bc-cdc82ac7bd0d") },
                    { new Guid("afb1ec03-caf2-44aa-affc-f0096e98e9d5"), "+836 85 (796) 04-57", new Guid("1b7614f5-4e30-4d6d-85ba-99232e5d1e20") },
                    { new Guid("b03ee785-e0df-421d-b7fa-1f1a91a01224"), "+406 02 (850) 44-70", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("b05dfb46-b5a4-4d0b-bc54-95f6b316396d"), "+426 14 (481) 23-13", new Guid("000acc6f-8ddb-4ab9-b1a5-ac7e44eec7d3") },
                    { new Guid("b0ae09f5-18ba-4bc0-a45f-108cd37fc53e"), "+278 67 (537) 41-91", new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("b108c7b9-27ca-4b75-973d-8eca944ba942"), "+547 07 (379) 21-80", new Guid("50f09bdd-f603-4289-bcd2-b438e9ec2a34") },
                    { new Guid("b17e3547-f82f-4330-a8da-36bc848429d0"), "+635 56 (970) 34-13", new Guid("6e90baa7-8b75-4108-acaa-210af704a12f") },
                    { new Guid("b1ae0e40-22ce-4436-8d75-c4f14abc61df"), "+71 01 (142) 46-98", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("b2157adf-970b-4abd-ac78-2027542cffee"), "+948 34 (953) 79-11", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("b25a7ab1-4e46-40f9-942d-113286aa03a7"), "+738 62 (457) 85-59", new Guid("de7d9783-5299-4552-b426-e13c1b4a4995") },
                    { new Guid("b2a8f6f1-cdb5-4061-b37b-420e7f2fcb68"), "+854 53 (126) 91-78", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("b31e85ee-5a98-446a-8ae5-7a7ea1d334a8"), "+396 46 (831) 33-50", new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("b3a92193-762f-499b-85b6-8b410efafebf"), "+353 02 (703) 95-52", new Guid("44c91a2d-d9ac-4b9f-990a-ebd598362f35") },
                    { new Guid("b3e4d925-b5e4-43d2-9749-484cd719938c"), "+313 52 (261) 19-99", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("b3efce39-d9f7-45af-9540-f81a252027a3"), "+562 47 (760) 49-85", new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("b3fd9227-528c-4d82-882e-72e900f76723"), "+697 99 (621) 47-33", new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a") },
                    { new Guid("b40b48d6-2a2d-4b90-ae53-2a6707e900f7"), "+745 52 (151) 05-40", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("b483d464-341e-4aae-8bfc-016c8cc821fd"), "+774 12 (682) 47-23", new Guid("fd936210-c641-434b-a51a-ab5f7d76430c") },
                    { new Guid("b4b06c3c-aceb-426c-9697-2a4e8b8138d2"), "+546 06 (666) 32-55", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("b4b93fc6-0831-46f2-bd77-05a68acf95c6"), "+737 74 (094) 81-69", new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("b4df5eec-7eb2-42a2-b76a-c546d9323ac5"), "+780 45 (097) 44-91", new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("b5e8f0b0-8749-4af9-807b-1f31973e2ccf"), "+12 71 (673) 71-94", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("b666765b-d63f-4d36-8a03-3e6a124accbd"), "+887 22 (337) 32-50", new Guid("4e73665b-695d-46e1-9611-8d0c159a0d02") },
                    { new Guid("b68a7953-bfba-4c9c-8e94-aa0d7fe3e7e8"), "+687 94 (684) 38-01", new Guid("ad5b9802-88b7-4c47-b138-778817c4050a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("b695f71d-237b-4590-846e-70c5f2e82f30"), "+330 68 (874) 02-28", new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("b6973ca2-36c3-4186-9c37-ff61cb697eba"), "+259 56 (004) 17-03", new Guid("769bd03f-6e4c-4506-8fb0-ebc1501d2b49") },
                    { new Guid("b6a91576-7863-4430-a2d6-aa5c1aeccde1"), "+799 85 (624) 76-37", new Guid("7a284bc2-2a63-484e-814e-da48b1cdb7cf") },
                    { new Guid("b6cd04ec-50c0-4b8e-968d-be4ff3622f98"), "+959 53 (275) 02-29", new Guid("36987fc8-8f2d-4b7b-897c-16bda7b27d39") },
                    { new Guid("b7a8c6f5-0c55-45da-8d4d-d8a71d1058d8"), "+414 19 (620) 55-01", new Guid("afa896ab-be1f-4401-923e-90219b5466bb") },
                    { new Guid("b88cfff9-e33c-4328-b2d0-df99de4ad865"), "+578 35 (910) 00-29", new Guid("d701c2ac-9cfa-4654-8e9a-4dedb3b5dae2") },
                    { new Guid("b8baf38f-d9e4-4547-8829-0ee33499f795"), "+248 51 (098) 52-81", new Guid("8b031351-f694-4f12-b95c-b4d9076da358") },
                    { new Guid("b8d2568a-a121-4c75-af69-c9c028a31bca"), "+149 86 (628) 31-29", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") },
                    { new Guid("b8d5f2c1-a36b-42b4-95b3-196f973c7fa4"), "+791 09 (001) 28-12", new Guid("e698e260-89e1-4c83-b493-1379542f5647") },
                    { new Guid("b909b666-edb2-4b2f-9b2d-b35a277c71a3"), "+361 26 (168) 09-50", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("b917a01c-5aa5-46df-a7f9-077bf1bb3832"), "+434 05 (758) 54-92", new Guid("aba457e1-7202-4273-8093-5dd9eb69d9fd") },
                    { new Guid("b950ca70-4672-4f32-b75f-523fbaa0e654"), "+329 07 (737) 06-37", new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb") },
                    { new Guid("b9720a05-c08e-458c-a67b-339187835d18"), "+137 51 (522) 19-48", new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("b9c02829-5136-46f9-8c5c-34815cdf7549"), "+329 67 (554) 65-09", new Guid("abd3fd60-8a43-4e6c-8b02-fe7662fea803") },
                    { new Guid("b9ff6f1f-a8cf-4a25-b535-8a79fa9dbd7d"), "+969 95 (750) 46-63", new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("ba7bed53-f288-46e5-89c5-cf330edfbdfb"), "+915 21 (433) 72-89", new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("bb9c4e3f-f0d7-43fb-ba27-47ec247c45fb"), "+370 06 (044) 95-57", new Guid("b1dec352-d80a-4c63-9df9-1230fb3df80e") },
                    { new Guid("bbca2142-0c83-4fb6-8ae7-cb9dd72c220e"), "+288 03 (707) 35-03", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("bbe23357-867a-4893-9ad1-06c4f8333c2b"), "+59 77 (307) 07-50", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("bc13601e-e209-4479-81b4-ed6ac5c93710"), "+866 32 (731) 39-63", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("bc90afb5-3644-41f9-8556-874ac96ea9a7"), "+508 26 (710) 08-52", new Guid("21856d76-0810-4123-9f39-8fd468591282") },
                    { new Guid("bc90c62c-1e07-4851-819b-7da291404505"), "+246 55 (957) 77-40", new Guid("b9fce42d-e196-4cf1-8209-6601d95f5d63") },
                    { new Guid("bccfa78c-0a61-4077-99d0-84e1b3545f51"), "+734 37 (621) 73-51", new Guid("21856d76-0810-4123-9f39-8fd468591282") },
                    { new Guid("bcf7a264-8588-421a-b838-8bba2e7aabe5"), "+255 11 (448) 71-22", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("bd6ca25d-7bb4-4e02-9d3d-c2be08213da3"), "+822 36 (401) 78-32", new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("bda26321-e1b2-4d18-8db8-3c15e76b1ce1"), "+211 40 (886) 73-23", new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d") },
                    { new Guid("be91aaa9-f696-4213-b1a1-103d377dc1e6"), "+586 44 (340) 90-43", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7") },
                    { new Guid("beb3a81d-3cb5-48d0-a3f7-819c4c34fc16"), "+524 54 (572) 82-65", new Guid("4a3bcdfb-d350-4c1b-b43c-56960771a1f0") },
                    { new Guid("bec48534-4550-48cb-bba7-aa0fc2f32e08"), "+321 01 (116) 29-69", new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("bee2b7ea-b1de-4638-bb15-08f44519075c"), "+315 35 (988) 81-51", new Guid("9a57b367-770f-4f86-8d83-869ef37800a0") },
                    { new Guid("bf127442-e21d-4bbb-8128-ebaf1333787b"), "+246 10 (042) 86-69", new Guid("24292576-82c4-4a01-961e-e050d58bf4a8") },
                    { new Guid("bf65796c-9f99-4bf8-bf17-07756237917a"), "+449 95 (798) 01-62", new Guid("c097551f-c54c-4e3a-ab60-0bbac6713a3b") },
                    { new Guid("bf7fe700-a002-4d7e-9b0c-d94ebe15c979"), "+576 31 (382) 60-99", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("c058cbad-0464-4836-babc-61cb4ce3b30b"), "+973 35 (371) 83-17", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("c0919537-69a2-4423-9965-e078a743c50d"), "+640 20 (860) 20-53", new Guid("41296760-deca-4b2d-a760-5538da32ccb4") },
                    { new Guid("c11c2dbb-9c27-4cd7-b232-4d3608f01f31"), "+38 52 (989) 11-37", new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("c1628652-3b41-489f-9107-ace2d7eebba4"), "+991 64 (910) 13-90", new Guid("b17b7b7f-692f-44ef-a75f-3164b368c8b7") },
                    { new Guid("c28ab93c-f6f3-4476-8e71-2ac0d8322c6d"), "+178 82 (216) 77-83", new Guid("47f337c9-0ebb-4f50-975a-51d41703f6ef") },
                    { new Guid("c29d6881-7026-4414-b7ae-557d252c8cd1"), "+301 93 (439) 52-29", new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("c3204009-1c32-499f-8960-74ae807795d6"), "+124 63 (522) 11-48", new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("c36bf377-d6fe-4fe3-823a-59c20004a2ba"), "+480 29 (081) 20-84", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("c3799e08-ed78-456a-99c5-4b2a12bf210a"), "+514 66 (511) 56-06", new Guid("f1b7f620-972f-4653-bc4c-322439d87a2a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("c3e65ef2-1e87-4495-99ab-ea3662e5f952"), "+993 72 (903) 73-66", new Guid("6ff0a6f3-e1e0-43a4-9d33-d847e3d404eb") },
                    { new Guid("c457930e-cabb-4256-beea-a661aaa3f435"), "+625 39 (356) 86-87", new Guid("0436e6fa-9df2-42d5-9b47-e5ca6aead714") },
                    { new Guid("c461d2ca-a98d-4fed-834a-0a92e62c5290"), "+933 24 (474) 51-96", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("c4f1d992-83b4-4377-a618-6da4ea1bdeb9"), "+484 70 (499) 97-94", new Guid("3725b28a-7101-4f09-b805-78a6947f6afb") },
                    { new Guid("c52ab070-0d99-4f4e-b721-64c1442269a9"), "+819 80 (467) 05-27", new Guid("c201a1cf-1a98-41fe-874e-ae7cd488f374") },
                    { new Guid("c5452eec-f360-48fe-aef9-90a4c15dc0aa"), "+687 74 (890) 53-92", new Guid("d0ef190d-e4bd-4b4b-810e-3cddff32a032") },
                    { new Guid("c65449ff-9c44-419e-a7b8-346744022e9f"), "+388 67 (171) 91-65", new Guid("a94b60b5-14d0-46fc-940c-71fb04166b0c") },
                    { new Guid("c65bc734-d27c-4473-b789-a0675bd40e06"), "+978 09 (559) 21-05", new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("c67893ee-bdb9-442e-bd64-b0a04d383e25"), "+367 51 (878) 49-58", new Guid("3076777f-a8c4-43ff-9471-5e2ea76528d9") },
                    { new Guid("c6973beb-d51f-444a-bf2e-def79047955c"), "+24 75 (754) 61-21", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("c6c5fe23-b57d-4570-a5cb-888cd0de65ce"), "+469 16 (786) 10-47", new Guid("b8c2f2ce-8879-4a3c-b625-4595a5fcdea2") },
                    { new Guid("c6d09a59-b258-4b27-b696-e64681e7229e"), "+76 19 (973) 86-10", new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553") },
                    { new Guid("c73acc13-93f9-47bd-845c-78985fa7dfb7"), "+255 76 (170) 05-44", new Guid("0f432380-a89c-4564-a477-a1ed20795e01") },
                    { new Guid("c7582f74-e5ee-4873-81e6-b59ef59baeb8"), "+122 23 (965) 68-25", new Guid("8bded758-8dcd-4429-89ba-bf7f67f0e2a1") },
                    { new Guid("c775bbf2-d278-46ac-87e2-2a0cf0bb36b9"), "+742 81 (185) 11-03", new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e") },
                    { new Guid("c7935ea8-4a05-4c09-8261-6395e5493e22"), "+492 60 (194) 57-32", new Guid("68d876f2-c855-4a3a-b244-f66443d9d833") },
                    { new Guid("c7e806d4-7341-491d-9226-d373dccb8121"), "+642 60 (047) 06-00", new Guid("2bfd36e1-3ece-4f28-8738-120df2357a6a") },
                    { new Guid("c8299b96-830c-4955-a6e9-34ecdf27fa88"), "+184 51 (717) 90-61", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") },
                    { new Guid("c8cf9211-4037-4e02-8de1-90651d44d5d6"), "+668 02 (767) 33-33", new Guid("430f2196-ef80-4bfd-839c-4209dbefb91f") },
                    { new Guid("c9a8bed0-8424-41fa-a6b1-015de8a9e3f0"), "+3 37 (845) 87-28", new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("ca2fe3bf-d88a-446a-8e8a-30eced2ed9fb"), "+195 73 (287) 09-04", new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("ca34a5d1-4939-4248-8ed8-2a9912da6378"), "+317 84 (940) 73-40", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("ca85927b-d38d-4900-81c4-fc48a2b57dfb"), "+233 84 (557) 42-88", new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("ca99693d-6add-47ee-ab80-f38dfae8cc31"), "+258 63 (632) 97-73", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("caa077d8-34ae-4657-8b76-b30a1251e7c1"), "+973 33 (689) 12-15", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("cab132e0-23a0-407c-9852-f5664bc456d6"), "+760 60 (292) 74-35", new Guid("69335634-41ba-4400-a54f-e27126ae5352") },
                    { new Guid("cac4360a-33ad-4de8-b382-a10fab69a540"), "+82 24 (759) 82-79", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc") },
                    { new Guid("cbd2228f-61ba-41f4-8a60-c41cb2c6ae30"), "+830 05 (247) 44-08", new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("cc9fc483-5e78-4d97-8232-04fddfa2b043"), "+13 84 (898) 61-22", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("cd425e5a-bcf1-4875-9498-a9f8b93bb82a"), "+764 13 (714) 07-39", new Guid("fcde8913-ebbc-4784-b3f5-0b53a28cb3a7") },
                    { new Guid("cd5eacd8-6a81-4418-a845-44a5ed2bfde9"), "+797 78 (810) 49-36", new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("cd624487-92c4-4306-9e31-9a22340a3bbd"), "+232 41 (664) 72-36", new Guid("b01daabb-f1ee-4a71-bbab-836e5f22c4b6") },
                    { new Guid("cd81a14a-a9c6-400c-bcd3-173808a6fec2"), "+295 42 (519) 84-46", new Guid("622d31d3-1c85-4dcd-bea3-9edac43a552c") },
                    { new Guid("cddbf32e-361a-499a-a37f-43a96e1065c2"), "+311 96 (431) 13-15", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("ce182947-1c1a-45cf-972e-71c0dd89c6f2"), "+881 27 (595) 71-58", new Guid("e7cffe03-f347-44bb-ab11-3e56a3216757") },
                    { new Guid("ce3e79e8-566d-4346-83ce-02c139029636"), "+185 73 (012) 26-56", new Guid("48d15bb8-1ef9-40dd-a80d-c0a16c2cc3a7") },
                    { new Guid("ce7f6188-09b8-4a6f-84f7-d70e5816d316"), "+604 28 (801) 61-43", new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e") },
                    { new Guid("cf947bf5-87df-4731-824a-79ca36504541"), "+161 82 (527) 39-13", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("cfe6625a-14ea-4341-8379-40a079c459f2"), "+232 78 (066) 05-72", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e") },
                    { new Guid("cff354b7-c5c9-435c-af25-2e71a4621e97"), "+387 52 (900) 08-55", new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337") },
                    { new Guid("d0029030-61c9-4b9a-9a2c-8577b7911b90"), "+859 18 (489) 49-01", new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007") },
                    { new Guid("d07f1e13-ade6-447a-a268-a23984f8458b"), "+747 35 (748) 39-81", new Guid("483d1201-94c9-4a29-bfa1-f81cd740609d") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("d0b0928b-b453-40ee-8630-e781aeb7942a"), "+814 33 (891) 90-24", new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("d0b5aedd-3070-4752-9d68-2d76a0c025e5"), "+912 91 (187) 30-47", new Guid("256cb8e0-cb58-4721-8227-b48dea35c90f") },
                    { new Guid("d0d1499f-c88e-4d46-abfd-5d781f45d91f"), "+742 65 (692) 51-90", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("d218b26b-8f1c-444c-ae54-2d61342221aa"), "+177 85 (626) 12-84", new Guid("9696ff0a-e6f0-4c79-b3e4-dfaed9347606") },
                    { new Guid("d24f2104-5cf6-4548-a787-5c60c2318bf9"), "+831 17 (124) 06-73", new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("d2a74276-91f0-4e9b-bbb5-c9baaa755812"), "+712 40 (981) 66-05", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("d2b7bc48-9bc1-4b1b-86a5-5fdbc2a41e84"), "+55 87 (033) 60-63", new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("d3043198-bc1b-4b31-9d96-f422eb5d68b7"), "+845 72 (847) 46-09", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("d33ab772-3244-4017-a961-fb9ca5aaa977"), "+154 53 (397) 18-91", new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("d435f591-74fa-43d2-b4c5-b0cc7349a4dd"), "+751 89 (420) 20-68", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("d48c3f24-5302-4555-86d3-dcc3bc12a024"), "+550 05 (040) 88-31", new Guid("1fd1eb55-18dc-41d6-9ba9-60c71ee6b337") },
                    { new Guid("d52e26f6-f938-4f0d-979e-ceb638f69734"), "+864 58 (970) 20-51", new Guid("96ab9dc3-3777-48a2-b064-296ce67d2c40") },
                    { new Guid("d550c894-0bad-429d-8a7b-b775fca848c5"), "+231 47 (646) 96-44", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("d557e79f-0d84-4a81-8092-1778ff33a021"), "+555 65 (617) 16-65", new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("d650342b-dbf8-4b54-accd-5a2ff566c980"), "+757 20 (129) 47-94", new Guid("ac23039a-7baf-4e4f-9662-515e3a2dcc40") },
                    { new Guid("d664a672-6a05-4d24-beab-9387bea4edd5"), "+907 50 (860) 99-52", new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("d68ca37a-c84c-409b-bc68-694c03eb8b20"), "+498 88 (991) 32-95", new Guid("501ca405-0708-4624-a634-6510fc3c78d1") },
                    { new Guid("d6fa2410-b419-4fd8-828d-7873e64b0a30"), "+154 62 (127) 21-50", new Guid("68d876f2-c855-4a3a-b244-f66443d9d833") },
                    { new Guid("d72ae80d-51bb-423b-a286-05a287135567"), "+277 45 (825) 40-01", new Guid("d6ac088b-6473-4b42-8afd-98bb558c0ff1") },
                    { new Guid("d7602a03-da8e-4f4c-8940-c213c7f4f7d5"), "+233 59 (009) 60-43", new Guid("3b491dec-f720-4470-a9b7-bb01d9107981") },
                    { new Guid("d7c472a5-4338-442f-951b-7ef0ec6eef1e"), "+443 68 (218) 79-78", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("d88d36b4-ba57-48a0-869a-001b836440ce"), "+467 98 (599) 73-07", new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb") },
                    { new Guid("d8eb572e-ce2b-473d-bacb-86effb02b1ac"), "+650 54 (079) 85-75", new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("d91eabc6-ee0b-467c-b523-b0f627bb6daa"), "+581 06 (208) 56-19", new Guid("75eb7539-3cd0-416e-a333-c1f68180dc26") },
                    { new Guid("d92b9a9d-64c1-433d-a81e-83579934a4d0"), "+830 93 (078) 08-53", new Guid("a86d8db6-cfaf-43f3-8c70-d371a62f66a1") },
                    { new Guid("d9c0e6c8-10e1-4714-a69e-425439084201"), "+940 53 (719) 75-83", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("da067ce6-294c-41b0-8123-689abb7f34a8"), "+416 23 (625) 28-04", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("da16c8a7-81a5-4cc0-ac12-680c32bff8af"), "+242 51 (434) 16-08", new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("da5e2e4f-214c-492c-925b-e18bba7fed5f"), "+201 22 (641) 03-58", new Guid("10bf0663-fbe5-4792-b499-9bcd00f98684") },
                    { new Guid("daa0693b-a597-4048-9e2a-d404e3a2389f"), "+216 48 (715) 78-53", new Guid("21f1bca7-f20f-4b2c-a256-a232a899e292") },
                    { new Guid("db043e26-8a96-4d35-b3ec-64beb31e19e6"), "+512 81 (143) 62-23", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("db048c11-218c-414f-b3ec-7c897587029c"), "+936 96 (336) 99-38", new Guid("7aaf1085-bf55-495f-aa2c-bbe54304855e") },
                    { new Guid("db62d971-28b4-49f4-afc5-9ed3cfebb925"), "+678 34 (023) 39-81", new Guid("0ef7f654-2436-49ad-b6d9-1715bb668b43") },
                    { new Guid("dbc4d4cb-c867-40c3-9893-6f515c0426d2"), "+849 43 (339) 37-91", new Guid("98878c3a-bd95-497e-88e6-a0f4ecbcd2ab") },
                    { new Guid("dc8d9e96-957e-46a2-967e-d7bdd216862e"), "+879 15 (641) 81-66", new Guid("bd070f0b-006c-46e3-bf1b-dedca04f9aab") },
                    { new Guid("dc97b4dc-931c-490f-8a73-5cfa6cca7289"), "+264 12 (653) 09-28", new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("dcb7c3ef-a575-4b85-b969-60f216801841"), "+343 51 (920) 74-34", new Guid("07f1e6a8-9ca4-43fb-b088-4aef6cccabdb") },
                    { new Guid("dcb9e8ca-0369-42eb-8398-5bcdf2e5cd2b"), "+564 32 (417) 30-83", new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("dd18a677-4572-4a3e-a5a0-7c0a9360f759"), "+401 49 (630) 68-51", new Guid("748c3896-0ffc-4ee0-90f3-e9dfa34cd332") },
                    { new Guid("ddd1f651-75cc-4b66-87b8-ca4074f9ef57"), "+237 81 (586) 83-78", new Guid("790a980d-2eee-45f9-a9aa-f38ce86f5d86") },
                    { new Guid("de2e71c3-9d4e-4125-8236-6ea354cd8572"), "+234 10 (233) 91-25", new Guid("a822fb95-cd1c-4797-b1fc-8a9971daff1e") },
                    { new Guid("df25a522-b9d2-41a9-b799-fa658a6c7d94"), "+614 28 (320) 83-52", new Guid("501ca405-0708-4624-a634-6510fc3c78d1") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("df4afbab-d97f-4c87-864b-01633e850572"), "+200 99 (431) 12-26", new Guid("185c63ba-c2f5-4c0e-9a0a-810f545d660b") },
                    { new Guid("dfae86cc-c2d2-4f32-8005-cb53d8d07bf2"), "+163 95 (779) 28-49", new Guid("5e307603-b79c-42ff-b951-98b55aa9f903") },
                    { new Guid("dfc4430a-72e3-4290-bb7c-8f1d38c83c3f"), "+870 75 (643) 81-70", new Guid("85a2dbf5-76ed-441a-9dae-db6d809a263d") },
                    { new Guid("e041dbae-899c-4142-97fb-54a6d3376a08"), "+178 22 (555) 28-91", new Guid("1fccf374-6938-4d04-97aa-f7eae88d2b56") },
                    { new Guid("e10d70fc-ecf0-495a-b392-293bee2f8129"), "+860 43 (235) 06-33", new Guid("4639e956-b4b3-49a9-9cb4-3d8abede9760") },
                    { new Guid("e2363ded-b8cf-4686-a892-aecdcc82d90c"), "+450 99 (159) 73-07", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("e245cd53-3984-4d25-8a87-6cd5a4b1b127"), "+222 35 (195) 32-19", new Guid("20acc6aa-77b1-4aa9-9f9b-1a6a655e4a98") },
                    { new Guid("e348901f-25c2-470f-bca0-5ed0ca39d4a3"), "+103 95 (654) 64-14", new Guid("65012c66-d07a-40f6-9789-b100201359c2") },
                    { new Guid("e35326c5-7ace-4132-9140-7e825a9bb592"), "+622 39 (882) 50-10", new Guid("e047511a-e7e9-42dd-a5b0-d4d19e1ea8b6") },
                    { new Guid("e418175c-3105-4af7-b160-4d6135deb09a"), "+560 07 (293) 98-13", new Guid("ca402be9-4708-4877-ada7-62364da2236a") },
                    { new Guid("e43d777f-d3f9-4faa-acf8-14542f4e8559"), "+585 23 (861) 45-86", new Guid("1b426f91-04e6-4baf-9392-6d6314f47bfc") },
                    { new Guid("e472c4b4-161e-43e3-bab9-f6e6dc9317b4"), "+695 34 (056) 83-20", new Guid("dd6ea664-cca4-4c89-83f4-529704dbc5d5") },
                    { new Guid("e49c8bff-df88-4f1d-be6c-fa488f65ff8c"), "+617 18 (459) 69-42", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("e4abbc7d-0914-46d5-b1b5-a721b2d4dc8a"), "+999 35 (435) 39-25", new Guid("082d68f3-3ec8-4587-9852-34cd715f794e") },
                    { new Guid("e4d180da-e584-45d5-ab14-a922a1362bbe"), "+219 99 (787) 52-59", new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("e4f109e0-0c9b-4317-b94a-1652b10416f9"), "+562 10 (729) 38-47", new Guid("27c1d593-3f3a-4b44-af5c-6acf73b9800f") },
                    { new Guid("e51bb41c-5481-401c-a0d9-d6e07b1f28ca"), "+656 48 (613) 16-27", new Guid("f152c9ef-389f-456b-990f-61d9b8acc09f") },
                    { new Guid("e522ff7b-da2f-42a0-9508-de4d8aa822d7"), "+674 07 (913) 34-73", new Guid("c50e00ec-d32c-4b4e-afed-79f7300dd13c") },
                    { new Guid("e5c3639d-dfd4-47d8-b305-e7aee1de35e5"), "+646 88 (105) 30-69", new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("e5c4cd8b-8a14-44ef-85d5-40ba0827d2a8"), "+679 36 (924) 35-20", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("e60a586a-0208-44a4-997f-bf94f398168a"), "+517 59 (954) 40-97", new Guid("22cac187-01bd-4609-824e-e95ae4f8ec17") },
                    { new Guid("e64b7ef0-ab30-42f5-bbe7-44b72666be0d"), "+390 20 (132) 28-38", new Guid("ab12d7dc-177b-41a8-ba65-c005052d2a4a") },
                    { new Guid("e6607b37-33fb-42d6-8a00-755a4daf4c12"), "+35 87 (004) 81-49", new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("e686250a-d1ec-4a54-a728-5ec203ef876d"), "+117 84 (297) 58-27", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("e76df365-3707-48b8-9942-1e616f5c016d"), "+889 76 (264) 77-47", new Guid("87f9d496-a48d-4b94-8203-47d8346ad0f1") },
                    { new Guid("e79ff2ad-f28a-4e89-8308-475fff4a1391"), "+192 87 (279) 97-32", new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("e7a3a7b0-913f-4446-a5b6-f9d690b2d313"), "+31 59 (295) 73-24", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("e7b9485f-a191-4337-b581-e41bccd93145"), "+611 25 (647) 71-61", new Guid("0a6753e1-2434-4328-852e-3458edfcd329") },
                    { new Guid("e8015e07-1e4b-46a7-a12e-1b07cae376a3"), "+976 99 (869) 93-19", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("e802d90f-47c4-4bbd-b68e-9730baf453e7"), "+254 56 (818) 99-61", new Guid("6e4c11da-c895-47e6-809d-836eef6bfa38") },
                    { new Guid("e8c04358-ae83-4785-b0ee-e76bc93f88ba"), "+47 65 (409) 50-33", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("e91857ad-b8ee-486b-a8eb-1db21cafd885"), "+471 51 (741) 98-98", new Guid("ce376eab-8569-4f9a-8425-51e1310948af") },
                    { new Guid("e91ee92d-b90c-40ca-8f3e-f6e37df74487"), "+987 03 (829) 96-34", new Guid("d2e4da7f-9d84-4d75-aaef-35d2d1517702") },
                    { new Guid("e92b71d5-6bac-4bf9-81c9-08e91e3f3764"), "+124 73 (265) 47-36", new Guid("172dc15c-c2ad-42c7-ab45-f7efcacaf31a") },
                    { new Guid("e9372999-c99d-4da5-8546-e2b14312568a"), "+970 34 (907) 31-96", new Guid("2733ca0e-d23b-49a2-b189-97b762991cf1") },
                    { new Guid("e94643be-f531-41ea-86a5-5b42c6195aad"), "+168 05 (811) 29-06", new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7") },
                    { new Guid("e9976992-1aa0-4dae-8e08-659c7c682714"), "+459 93 (261) 73-45", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("e9c4c1d0-e78d-4fe3-9623-7183f8c0b043"), "+509 20 (749) 53-95", new Guid("6da4a869-75e2-4059-9b21-1ac2d5213192") },
                    { new Guid("eaea57f0-9847-4454-85c4-f062a9a43694"), "+992 95 (347) 08-41", new Guid("9eeef870-7564-4ec9-a513-9b4d971643d7") },
                    { new Guid("eb5b50ba-1572-4a41-a546-bd1071b1cd03"), "+265 18 (441) 52-90", new Guid("7230e072-479a-4bc1-beb5-84fb8ad865ba") },
                    { new Guid("eb7ec316-00c7-48cc-bf1e-a9e018ee46b2"), "+490 12 (570) 56-37", new Guid("2a59222b-5b62-4710-a913-e8a851d0d3cb") },
                    { new Guid("ebfbea8f-37e5-4d17-bed6-c1c564c1c76b"), "+588 60 (254) 60-46", new Guid("41e02d10-dbc3-4198-b3e1-413fde1b0106") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("ec2db884-9964-4a49-a786-90c95d93c746"), "+104 52 (269) 62-60", new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("ed2218e4-1ed0-4725-9f58-419f7353ab2e"), "+967 01 (731) 33-52", new Guid("e750faef-6ee6-4b07-9218-54b28eb40e37") },
                    { new Guid("ed45d9d3-cc30-4de1-97e6-b02e6a79e853"), "+934 38 (431) 24-23", new Guid("99e79b31-2994-4fd2-956f-0294e124da96") },
                    { new Guid("ed784720-ac65-42fd-968a-7bf33e03a0a6"), "+254 86 (395) 77-87", new Guid("d8d070a2-53ef-41c5-828d-1ca97137281f") },
                    { new Guid("edbb46ad-b5fb-4799-a1a6-b8d9ae86bc8a"), "+950 44 (818) 87-09", new Guid("36fa2eff-6726-4de9-9600-18e22290de3c") },
                    { new Guid("edccd4fe-091f-4928-98f0-180e2c0ee8b6"), "+298 04 (850) 01-29", new Guid("c9472a51-2e3e-4b6b-8c43-6530c4d32592") },
                    { new Guid("ee11af77-75e3-45fb-b3c6-3e7a424aa4f2"), "+474 24 (408) 37-02", new Guid("ddfe5f8e-2e15-4bdf-946b-80af9d47e553") },
                    { new Guid("ee6c39be-1e80-49ae-a732-c17fc7d6c5ca"), "+387 33 (116) 29-01", new Guid("ebc0a6d0-2733-49b3-82d4-bebe9916299f") },
                    { new Guid("ee76e760-33be-46f9-b9b9-94b139a995b7"), "+361 59 (946) 52-66", new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("ef27ef46-812d-4864-b8a8-569cea476a61"), "+18 98 (731) 21-56", new Guid("6280e581-a380-4b2b-890d-dced1f97d1de") },
                    { new Guid("ef5e7f2b-1234-4dd5-9ca7-7cae7457303a"), "+495 45 (057) 93-33", new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("ef940be5-37c6-4325-b6d7-b50f0f921286"), "+28 64 (203) 71-58", new Guid("6da3c4c0-8b5d-4550-a461-63766d08a4fa") },
                    { new Guid("ef9995e9-ce7f-425a-85aa-966c996f717c"), "+26 96 (251) 37-72", new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("efdda746-624c-49a3-a9bf-35f9edf98d04"), "+630 55 (977) 06-25", new Guid("dd8cdfac-da55-4f50-974d-ce267420fb01") },
                    { new Guid("f0422183-54f2-4d35-a999-cd3e2c193252"), "+837 31 (066) 14-44", new Guid("b8f5bf89-6e74-488b-9353-96a107eef2a8") },
                    { new Guid("f0c055cb-08bb-4556-80b3-3f5f28a4ec22"), "+818 65 (460) 15-25", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") },
                    { new Guid("f0e8c44e-fb82-4f43-863b-e9b0fbfc7153"), "+203 14 (046) 37-34", new Guid("3176dd3e-33a9-4be8-bd96-18017d5cb41a") },
                    { new Guid("f165e729-b6e2-463a-8803-89ed210983e1"), "+960 02 (104) 90-66", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("f1945858-0d4a-4582-81ff-5aa3eb382b17"), "+450 36 (954) 63-41", new Guid("f4943944-5289-42df-aed1-a6281dd934db") },
                    { new Guid("f195979d-d576-4718-aef5-e09da754db3b"), "+377 92 (551) 56-12", new Guid("ecfe301f-9845-4f5d-ad12-ffdc96625f0e") },
                    { new Guid("f1c69b0d-5a44-4bf3-9265-b2e90cfc2fc3"), "+438 91 (064) 96-23", new Guid("201c0a9b-6a38-4915-a659-ef53ea45b401") },
                    { new Guid("f1e0e740-f757-47cf-8de2-912be200ede1"), "+357 36 (259) 14-63", new Guid("7369b497-f21e-4a1c-9f24-d237bc3ff700") },
                    { new Guid("f1f887f7-149c-4088-8b22-b18498a71013"), "+731 20 (392) 59-42", new Guid("b2bede80-2ad3-40a6-9e0a-7e59b8125ac7") },
                    { new Guid("f209d746-df62-4709-9a6c-17ff9898a31b"), "+614 36 (564) 20-51", new Guid("134ec031-a4a4-493b-a93a-c6d6ce233c12") },
                    { new Guid("f256048a-c377-44fa-b3f6-2356d616aa6d"), "+906 68 (804) 32-18", new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("f26a6c57-e781-4fe1-8f0e-f1c10469c52e"), "+891 20 (737) 67-64", new Guid("b07e4692-924c-4f52-ae90-713922a2f1b8") },
                    { new Guid("f270bb59-7bfb-434c-9239-aae51d38d6fe"), "+170 70 (453) 45-29", new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("f28996da-79cc-48c8-9f44-85d8feabd1f1"), "+138 76 (662) 64-04", new Guid("37370b1f-a3f0-4edb-acd3-a0192a63b08d") },
                    { new Guid("f37bc114-74ba-4d56-8716-2d8dfc811318"), "+18 56 (710) 95-94", new Guid("c4cc0902-09e2-404e-a40a-f875e14d69e9") },
                    { new Guid("f4affdc3-66c6-4563-9402-dbabf7c6bf13"), "+915 32 (614) 46-19", new Guid("fbbebf72-930b-41e3-8d4c-64442a7903eb") },
                    { new Guid("f5308896-0203-471e-baa1-a456e2bf7068"), "+210 20 (058) 08-45", new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("f54a8e13-aa3e-4eca-bd45-6763cf2905d6"), "+143 90 (611) 59-60", new Guid("04010b7c-acf5-4cc3-bd23-366c55dea058") },
                    { new Guid("f555fac3-9c8b-420f-8e50-4735fb84a850"), "+678 33 (889) 11-57", new Guid("6ca7cec5-e081-415f-b4d0-8fcb3838daed") },
                    { new Guid("f59cc569-4976-46f5-8ac5-5aff550ad328"), "+633 43 (948) 22-45", new Guid("4a7cae5c-25fc-4818-bd12-ea138ae34a7d") },
                    { new Guid("f5fb5572-38c3-4e58-b6b4-11d128e00fc4"), "+600 49 (680) 20-46", new Guid("f7e1289c-247c-4f2f-82a1-8c3209f7e1ea") },
                    { new Guid("f60f7790-7ec1-4d01-9894-391b11aed327"), "+191 81 (045) 05-10", new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("f6bdcec9-ab6f-4eb6-aa83-62ef01af6afa"), "+901 06 (226) 65-18", new Guid("3684afea-cc23-4354-a0c3-cd7e1d5b18b4") },
                    { new Guid("f70bbe3a-9dad-4deb-97a0-7a4b3ebc99f0"), "+436 13 (063) 44-13", new Guid("082d68f3-3ec8-4587-9852-34cd715f794e") },
                    { new Guid("f7568572-542a-49ff-b3de-fdfcc4bbc9d9"), "+717 77 (819) 46-64", new Guid("b3a97f09-bace-41d8-916f-1f9c43cdf011") },
                    { new Guid("f786f60b-d471-4a31-abbb-7561cce75a95"), "+418 21 (387) 55-11", new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("f7c4165b-8af4-4283-b1f4-3fb35efd6c68"), "+733 62 (601) 06-56", new Guid("4d300619-14a0-469d-ad30-19a8d1a6a37f") },
                    { new Guid("f7c90bd8-1c12-4331-a673-366b29e0a9ac"), "+68 91 (564) 42-80", new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "PhoneNumberId", "Number", "UserId" },
                values: new object[,]
                {
                    { new Guid("f81d0198-fdde-412e-8e2d-a6db67b77e12"), "+627 13 (998) 29-85", new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("f92a6d2b-ba45-4b90-92b2-edc20aa0a1fd"), "+643 52 (178) 08-85", new Guid("302bd1ee-93df-4cd4-b9e0-554ee413237e") },
                    { new Guid("f9539854-e4a6-4724-8bb1-bc84423e6988"), "+998 53 (880) 11-39", new Guid("d51d599a-a1e1-4cb2-ad67-d3b7175a50f6") },
                    { new Guid("f98d0955-95a8-4b2b-8d91-163421bfd133"), "+964 96 (067) 68-34", new Guid("a94cc7e7-180d-4c3c-b870-a58a0f86496c") },
                    { new Guid("f9f31145-76cb-468f-b706-39de771d93c5"), "+972 65 (476) 51-49", new Guid("92b8dda9-fd82-4568-86fa-4a32b6489969") },
                    { new Guid("fa09f8bb-fd34-44f1-8db7-144558937924"), "+332 82 (063) 69-14", new Guid("1294e106-cbbd-4bf6-abf9-22012284dd2a") },
                    { new Guid("faceb76e-5506-43b4-b5f2-081ec9e13799"), "+886 20 (107) 90-92", new Guid("a0c72d91-dc13-4995-848c-613286a462f4") },
                    { new Guid("fb059a65-551c-479e-8e06-a8b7ca7085c2"), "+47 90 (771) 24-24", new Guid("bbff2065-0fdc-4fc7-aa6b-385886709664") },
                    { new Guid("fb524281-61e4-4232-863d-879e046e6797"), "+385 75 (079) 34-75", new Guid("002b48ff-5311-4b87-a3d1-f6bd1a66ac17") },
                    { new Guid("fb72ca9a-77bf-4367-9150-9430e55d4e3e"), "+543 82 (936) 27-33", new Guid("2e77aeaf-8e17-4d82-9514-fdc483268387") },
                    { new Guid("fb78dbc0-115a-4146-89a5-63492b65bb2b"), "+624 43 (818) 80-76", new Guid("2c35eacf-b8cd-4ff0-b71e-6e8cdec46807") },
                    { new Guid("fb9599c3-c4f6-41f9-b39f-9f7a95a8a038"), "+272 04 (959) 90-54", new Guid("46560af2-918f-43b7-ac66-bf26a10cdfc9") },
                    { new Guid("fd638048-9e36-4fd9-90a2-0bc46ef13433"), "+899 86 (825) 35-79", new Guid("a575107d-8b01-4cfb-8c06-740360739c3b") },
                    { new Guid("fd7629c7-a4c6-4303-8154-f3f386a45dc3"), "+854 52 (803) 94-28", new Guid("d8bacea3-d276-4baf-9e42-486b55067620") },
                    { new Guid("fd84a3d7-6cc7-4270-8d6f-7c132eb94cda"), "+692 80 (785) 61-71", new Guid("88c37b2d-115b-4aea-9e4c-db76d06f9007") },
                    { new Guid("fdc64a43-8e19-4313-94ec-1fcb96538858"), "+609 15 (386) 46-79", new Guid("e534c8a5-cbab-4328-9b63-b55d32432a8d") },
                    { new Guid("fdd146b2-50b5-441a-82c3-c5d8e0fea47c"), "+593 32 (972) 89-33", new Guid("813c55a8-fd85-48e7-9121-56830bfefc7e") },
                    { new Guid("fe9f16b6-f3d0-471c-b7c4-6dff2df43a26"), "+500 07 (237) 83-81", new Guid("3cfee791-0fdd-4a1b-80bd-77b0a557b184") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("04ce6439-f97e-4c3d-92ab-d035c8475b30"), new Guid("00dfebec-fb40-4e2b-9e75-2fdd2b55eceb"), new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("0714a0c7-245a-4d48-865a-70541fc88250"), new Guid("e1ec5814-cc1e-4c58-a9a9-111e13d6a4fc"), new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("11dde5a4-4fde-4756-a6af-08e90bf1ae96"), new Guid("8c2ac402-899a-40a8-a708-5fff489bc2eb"), new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("15620694-ad30-4648-8056-0360837e0f08"), new Guid("7a9316a6-44f7-430f-8e05-a8fd9b2c9186"), new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("19d401cb-f8e6-448b-9735-a1ed6b572675"), new Guid("0809ca1f-63f3-452d-b883-ca5f11d909cf"), new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("19d42c9a-d12d-461d-852c-067e3d6a1cfe"), new Guid("225c7cae-a13e-4edc-9cc1-cfcb2589e57c"), new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("1c568bb2-2819-48fc-8cee-a67e8fd57d2a"), new Guid("5686d183-3d0d-41f1-a52b-ea86a8e0ac4a"), new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("1defe135-cf83-4dc8-a25b-0ae8485bb736"), new Guid("aae05d17-8b91-4e50-b17e-493c7ecfdd0c"), new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("20de44be-6a17-45f7-8d33-64250ee4ff85"), new Guid("a5cb8000-3c2a-486a-b593-6a21ebe8f367"), new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("21ca600a-ad67-445e-ab16-a3d8f8128088"), new Guid("b1695177-eec6-472a-a864-a933bc1f22fe"), new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("25d47762-b010-42d6-963e-f9fd779ce607"), new Guid("cc19bcc3-319f-43c4-971f-4106c62e8e80"), new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("2c5b0c86-5e26-4027-96b0-1621692e9e90"), new Guid("bb1afed4-d314-46f8-a76d-81e152deffc4"), new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("2d2cd8d7-80a6-4b3f-ae0f-7626d20500cc"), new Guid("ae821cda-f212-4c7b-a34c-efb96130c1d9"), new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("2e2e210c-bb4b-475c-8dcf-31f38de15e3f"), new Guid("27b0d9a9-2737-4ddf-9410-fabc3a2966fb"), new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("353894e3-b067-445c-b2ac-2ec409581fb9"), new Guid("a5cb8000-3c2a-486a-b593-6a21ebe8f367"), new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("3c260a1d-c49f-4247-a5bf-450682c7e6b9"), new Guid("88151a9e-50d9-4941-bdee-8f0cf3735de4"), new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("4192847e-adbb-4216-a5ae-73993159aa9a"), new Guid("b3e39f0f-915a-443b-b8cf-6e0f778619db"), new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("47ad9d2d-1e5f-48e2-bd13-a1009ab8b0af"), new Guid("9e0caa1a-8096-4717-84ed-da9cafde4a2f"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("4e5bfadf-2b89-4dd6-80cf-b76e29d2b25f"), new Guid("93141f87-a60f-4941-ad1e-888b0517476f"), new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("50c815b2-524c-45b9-9de4-63990a3b90fa"), new Guid("a987655b-3a56-467b-a70a-6dad466664fa"), new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("5410e966-786a-4944-9d03-819e90ad3f2f"), new Guid("b3e39f0f-915a-443b-b8cf-6e0f778619db"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("5658e89a-2a54-4399-afe6-bf5575fe522d"), new Guid("d8df15a7-b416-4345-83b3-6f52ea444eda"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("5c924008-d8e9-4579-ac6b-f5dc6d1c2a3e"), new Guid("aae05d17-8b91-4e50-b17e-493c7ecfdd0c"), new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("63246536-6df4-42db-ae65-8fbc387eb09e"), new Guid("7c7cc635-c7b6-4190-9655-1b8d24188f46"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") }
                });

            migrationBuilder.InsertData(
                table: "UserParcelMachines",
                columns: new[] { "Id", "ParcelMachineId", "UserId" },
                values: new object[,]
                {
                    { new Guid("77e3bef6-fb70-4e1e-9af3-5218210c18b1"), new Guid("f6c815a0-a15f-45cb-96e3-9724da561ae9"), new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("7bc7dbde-e65a-453c-9758-c462dc64826d"), new Guid("15465541-6048-441f-9365-f54a8f2e413f"), new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("854e7a9b-55e1-45d7-8db8-be5592e7059f"), new Guid("47541163-70b3-4e12-a210-73989f977276"), new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("86b721e1-cd74-4fe5-ae7c-8519205fb14c"), new Guid("5215b833-f9bf-45e1-8801-02f667761599"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("8a891770-825a-4234-a0f2-c78179138a12"), new Guid("fdb1910e-9488-40a4-8da8-6a89017dd088"), new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("8d27af1e-3bc4-48b1-ac06-a611253a67c7"), new Guid("7f7b3ab9-b22c-4d54-b18a-7dee63cba9e9"), new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("920ae56c-8d98-4397-9251-769f66dd7a03"), new Guid("87114ad0-8653-4a50-ae0d-91b3044d1c1a"), new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("95294284-5772-49d6-a83d-abb438a8c4c0"), new Guid("418de17e-db13-4ff5-a08f-6e6e26da4d38"), new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("9562c412-4645-4e81-b07a-8fa1d50e9281"), new Guid("ea290975-bd5f-4617-9651-40dc797eb5fd"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("98da03c2-c30d-4654-a8db-d8d9f510ba8f"), new Guid("8c2ac402-899a-40a8-a708-5fff489bc2eb"), new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("9b76adcb-2d12-44fb-a42e-892fa136de24"), new Guid("8041ce88-8970-4e24-a0cd-0ddb6c08f83a"), new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("9bc1058e-d5f5-4493-a834-92da83fad9e7"), new Guid("bb1afed4-d314-46f8-a76d-81e152deffc4"), new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("9e79e189-0483-42be-a903-c37d8b6ffe2e"), new Guid("aae05d17-8b91-4e50-b17e-493c7ecfdd0c"), new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("a07c996e-b9ef-4d8a-9e11-fe9ce0a88555"), new Guid("9e0caa1a-8096-4717-84ed-da9cafde4a2f"), new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("a0973b81-7f90-4f43-992b-484308a5fcb5"), new Guid("ab213edf-9504-4cf0-a96a-659a5f48c772"), new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("a3629d9c-d867-4810-a1f5-2e2a6ea92a4a"), new Guid("2e93d73b-ab1e-4acc-9f3e-41137645d8c4"), new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("a9dc72c7-9252-4543-8dca-1c53d1a9c172"), new Guid("27b0d9a9-2737-4ddf-9410-fabc3a2966fb"), new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("b524ac5d-7dec-491c-8d79-51d8a43c0700"), new Guid("64069a76-e70c-4348-b8c9-b2bd5af83ff2"), new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("be912198-d266-4ba1-af68-5685011cd722"), new Guid("7a9316a6-44f7-430f-8e05-a8fd9b2c9186"), new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("c02d4bd5-7249-46b8-bf3b-f9097af0e2ce"), new Guid("29c204cf-fa17-4494-bbc4-69e1801aedb1"), new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("c11196b6-18b4-4986-93cc-05b14e3247f1"), new Guid("c2e9a7ab-37d6-4114-b802-a69f665ecfbd"), new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("c2b0c803-7575-452b-8b5a-a7a66eaf253d"), new Guid("8041ce88-8970-4e24-a0cd-0ddb6c08f83a"), new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("c8a51486-3f9b-4647-ab9b-f36a72e188e5"), new Guid("7a9316a6-44f7-430f-8e05-a8fd9b2c9186"), new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("c8e44119-99f3-41e9-8f38-9216071081f8"), new Guid("33629524-892b-419a-9844-38ecb6bf16ba"), new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("c92b4d06-fcee-4c7c-b88e-5da9bd7d810a"), new Guid("27b0d9a9-2737-4ddf-9410-fabc3a2966fb"), new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("cf4fb827-f8fe-45f7-ad8f-084f62a4eb5a"), new Guid("65de2abc-0071-445e-8420-4089caea7e68"), new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("cf9d298d-6b72-4c45-bc5b-7bc3ba24dad1"), new Guid("e273e9ca-7e68-4789-acd6-035f53923937"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("d1f814ce-03d5-40a7-ac5f-cc089607a665"), new Guid("6c0f4055-2dd6-44a4-a770-add285995e2c"), new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("d33fabe4-780f-40c2-b6a2-41a3badc04f2"), new Guid("e6321b35-1606-41ca-91f6-fab2fd27caa4"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("d861a986-72cb-4be4-8241-0cb636e3cc3c"), new Guid("7847e3e6-e8e7-4793-ae82-f42ffb84862e"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("e41c08ed-c9e4-4146-af16-7cbe9f8614c6"), new Guid("225c7cae-a13e-4edc-9cc1-cfcb2589e57c"), new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("f2a034b7-90b6-4642-ab87-8bc9fbc64725"), new Guid("5fdbf576-345f-48a9-80fc-5fc2b086a721"), new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("f2d39dfb-c087-464d-a341-5d2482679786"), new Guid("64069a76-e70c-4348-b8c9-b2bd5af83ff2"), new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("f35a69a1-3f9b-4fb6-8933-9f3d370e1f20"), new Guid("fdb1910e-9488-40a4-8da8-6a89017dd088"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("f84f7466-2d32-4220-8751-0206ca3a785d"), new Guid("d8df15a7-b416-4345-83b3-6f52ea444eda"), new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("f986e7e9-e020-4717-8fd3-950eaa1d2a19"), new Guid("a9ed5b3e-93a8-42f7-80da-a28cdbb45d7c"), new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("03d089a3-504f-4a25-bfea-e6a4d3f2e60d"), new Guid("f347ad50-1a3a-448a-ad0c-3c5ac0c97757"), new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("06609ffb-a94a-4847-b68d-1e2624151411"), new Guid("7dfa3888-1cbe-431d-8f87-73b0001a68ee"), new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") },
                    { new Guid("11440fbe-60fc-4408-bde9-f721321860f4"), new Guid("fb383be0-d62d-4ada-9890-ccb09042c420"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("12956c19-249c-401f-9431-034216972ad3"), new Guid("f347ad50-1a3a-448a-ad0c-3c5ac0c97757"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("1989578a-f5a4-4902-a0a3-0d840fbbbf10"), new Guid("790700ae-4f7f-4063-8470-93b30820d7ec"), new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("1fdee354-8195-4d3d-a833-3c5bd2ccdb4d"), new Guid("4a3c1fe1-dac5-4716-9645-a21a1f5fc905"), new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2756587d-502d-4bb0-8085-fb35bd1878c1"), new Guid("007374a4-abe7-4cbf-9fe9-dcb4d03d9f29"), new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("34e3f1cb-70a2-403c-b380-ca8a4c7b7bc9"), new Guid("1d59e08c-2cf1-45bd-9d76-a67f55a90a2b"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("35883d11-e7ef-4f48-93ce-f8d44342f8ee"), new Guid("7c015125-fcc6-449c-8e3d-716aea32724f"), new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("39c08408-fc40-4fa5-90d6-5c4f97def6b2"), new Guid("bbf611ba-773c-426d-8e7f-fa8990beaac2"), new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("3e95e20c-d9df-44d8-98bd-6cac982af206"), new Guid("19e3b61c-4227-4f32-8244-ec011da8ad0e"), new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("3ecefb0d-7940-40e0-b149-156841b6f686"), new Guid("e2d3e1c2-54ad-439b-a92c-b2aa2a2b0dc9"), new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("3fcd4ae7-7440-46dc-9d4b-222ba157b086"), new Guid("8ed56a71-22bb-4438-9035-107f55000c92"), new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("44dcf792-253c-42cf-92bb-396992dc1d90"), new Guid("5f2e1df8-79a8-427c-84f4-fcfd68fb4a4f"), new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("4a619e73-0278-4a61-ad7a-8bd9b2189193"), new Guid("19e3b61c-4227-4f32-8244-ec011da8ad0e"), new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("53539c1a-5a94-4a86-85a3-a0022bb48cdd"), new Guid("0ddc1555-5c76-44d4-a961-7f4ace0284f8"), new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("58507db2-4da2-4c67-bf8d-4b69f8ec1c24"), new Guid("1d59e08c-2cf1-45bd-9d76-a67f55a90a2b"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("58754989-b1db-469c-a20f-96d7682d66c9"), new Guid("8b45dde8-a22f-4a68-a19d-be7802733200"), new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("5a5b6d55-cd6c-4ae4-bff4-5040cdee1112"), new Guid("1d59e08c-2cf1-45bd-9d76-a67f55a90a2b"), new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("5afe013d-6a9c-4da3-a191-dc59f35f955f"), new Guid("7fe70abd-d465-46d8-8872-b556b9424a16"), new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("5c522436-21e6-4a52-82b9-a2189afa5289"), new Guid("ee38c7e2-b40a-4595-894b-032db0ffffbb"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("653c4b76-bad3-402b-b947-8dde8cbab692"), new Guid("dc5833a8-3d41-4f91-95ec-9b82ca052034"), new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("67f201f0-ba42-4f39-aeb6-ca39255fab36"), new Guid("5f85f1d9-ed5b-4129-81f6-cc4f3dd932bd"), new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("71ded328-8654-444e-9472-457db7965888"), new Guid("00ddaa3a-fde4-4e97-aeb7-52d7e4ca3192"), new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("72acaddd-a5da-4e54-8c87-ead622eef7ee"), new Guid("e2d3e1c2-54ad-439b-a92c-b2aa2a2b0dc9"), new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("73376568-c7bb-485a-af2b-8bb275f32342"), new Guid("c29848ff-8bc9-47e0-8b77-b372fc739d91"), new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("7594d33c-4d04-460e-a238-8723ae1057c2"), new Guid("01026e9d-f00b-40ab-967c-4ac2fbf3c254"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("7a0ef7d5-4ada-4b46-aafe-76b3e10a4762"), new Guid("44598530-aa18-47a9-8d94-2f501ff27996"), new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("7afe83f1-e295-4aac-9e29-ba5222b3ff15"), new Guid("e2d3e1c2-54ad-439b-a92c-b2aa2a2b0dc9"), new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("7eac5804-952b-40aa-a4f5-9ff397a6cd61"), new Guid("7c015125-fcc6-449c-8e3d-716aea32724f"), new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("7ee0109e-e4f7-4db3-ac88-1cbd6d6a8755"), new Guid("6fed90bd-b866-4699-951b-6291c2343283"), new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("80c27b24-78f6-4044-a5cb-16bb22d0425e"), new Guid("017bb7de-ec27-4d86-a469-ab6fd845ae9f"), new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("81087710-d8e5-4ece-9ec0-21242bd98573"), new Guid("bbf611ba-773c-426d-8e7f-fa8990beaac2"), new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("824686be-939d-4da7-a59a-5fb11a47b0c1"), new Guid("fe14773f-6691-40b9-8a97-00bd146b272b"), new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("82501cfb-70ab-40b5-9469-23ee29143bdb"), new Guid("1568c3ad-cce1-41a0-a0c4-3b5c980c18cb"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("8cc2fc70-e68c-4b9f-9b34-23f27cfcf8d6"), new Guid("c8ffaece-8951-4955-87fd-d8457b06d299"), new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("8d46818b-97b4-4743-9a62-d49e4e748b2c"), new Guid("b0f6b08d-5a43-4f56-93c8-1087efa489ce"), new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("9a044c78-d4d7-49b9-983e-722938a01586"), new Guid("65469f28-cb68-49a6-90d5-3450a77704b1"), new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("a2741470-327c-41c6-8aa9-b0ed54f36167"), new Guid("2c9ab446-ee57-44e2-b641-cda156a85e2c"), new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("a6b2db6f-6373-4ab2-95ce-a184b3fc21ee"), new Guid("57e685cc-a45c-42f0-94e7-dbf7c6f9e1c8"), new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("a76bc302-6ff0-4fc1-87a8-93c7d228107c"), new Guid("4500ce4b-6df9-4282-b4d9-8e4c27d25180"), new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("b15f61b0-fc13-4d97-9854-b4025c8c4059"), new Guid("9f87c992-10b8-48d2-838a-ac3f61829a5c"), new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("b6c3a249-9ab5-427f-9d67-d37d67cc7706"), new Guid("e2d3e1c2-54ad-439b-a92c-b2aa2a2b0dc9"), new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("b8f83c0d-df30-4cd8-af37-b92fb7f727a6"), new Guid("5f85f1d9-ed5b-4129-81f6-cc4f3dd932bd"), new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("bca9dbe0-083f-4d26-9046-1a6356f8b28a"), new Guid("c5dc2358-e948-4030-aad3-23e9c4cec62f"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("c2063edd-260c-4213-ad23-5d7ea73c4360"), new Guid("0cef5f0e-429a-4133-a7c3-70c3681ea8ad"), new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") },
                    { new Guid("c24835f5-488d-49b3-a9ae-93fdf26a54b1"), new Guid("3f3b9aa0-2710-4d08-baef-8b69239bcd3a"), new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("cc733331-899b-4ce8-b0bc-b387d6a456af"), new Guid("c3cec6cc-40e5-4ec8-9a3c-3aabc13f3c30"), new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") }
                });

            migrationBuilder.InsertData(
                table: "UserPostBranches",
                columns: new[] { "Id", "PostBranchId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d8bd70e6-024c-48e7-9d0e-fd7c9f759985"), new Guid("c29848ff-8bc9-47e0-8b77-b372fc739d91"), new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("dfa7ba4e-90c4-4fc2-9837-c91fb1d9495c"), new Guid("44598530-aa18-47a9-8d94-2f501ff27996"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("e6eb9724-2f85-4473-94cc-e9e87eb99086"), new Guid("9f795109-d9e9-4a1f-b2b5-79638b0e20a5"), new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("eaed9402-edd4-47f0-b23b-52ac58760379"), new Guid("10021bbd-275b-4244-a649-f4e367e10866"), new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("eb74051c-d315-409e-aae5-1b57767e5784"), new Guid("c29848ff-8bc9-47e0-8b77-b372fc739d91"), new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("edba9174-c57e-4f6b-b447-889a1317b7c6"), new Guid("c00fd1c1-8cf6-49e1-bdd0-c037f857c502"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("eee3580b-3677-46e8-8ac8-69834e6397d6"), new Guid("1a7f1fa4-2eaa-4778-b9f9-b2115a812ce1"), new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("f0aaf9cb-05e6-4364-9a25-aecb61d3b1e0"), new Guid("017bb7de-ec27-4d86-a469-ab6fd845ae9f"), new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("f5b4b496-a47e-4fc1-9139-202f209d3eef"), new Guid("65469f28-cb68-49a6-90d5-3450a77704b1"), new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("f5db3efd-5071-4a93-b437-eca4b2557f90"), new Guid("017bb7de-ec27-4d86-a469-ab6fd845ae9f"), new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("f8034051-6bb9-46a9-a0e2-cdd64d00342d"), new Guid("b54d5ca2-5c75-4eeb-9dbb-05fa5c012899"), new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("fc9f5994-a223-4561-9b0c-01261a00d5cd"), new Guid("5f85f1d9-ed5b-4129-81f6-cc4f3dd932bd"), new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("006731fe-db3c-437d-aa91-de5df19c2994"), new Guid("59500a96-6847-40c0-8c4f-84f196e3d1fc"), new Guid("e7e25b0f-3ce8-464c-82d0-66401d90eb0b") },
                    { new Guid("0531c5f3-d7eb-4130-893d-a9114d0c8696"), new Guid("69ef6a1b-ea81-4676-bc34-ba5453e63353"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("1045db10-5e38-4e8d-8d77-5cbfdb023f53"), new Guid("182ad6c7-b3f4-4ab4-bc4e-2266bc62c306"), new Guid("0c876743-f7db-4f0a-8d45-76f35960f834") },
                    { new Guid("14c07b46-ff45-4fe2-abf5-90f383f53af3"), new Guid("084b14da-2861-42fe-8fca-e59ecedbac19"), new Guid("bc709cb8-3fea-4ac5-8e90-93ecd8f3740f") },
                    { new Guid("15de7df5-004f-4da8-8508-07f5d0dd2bf8"), new Guid("23400754-5aa2-47ee-846d-96582a8bbf0f"), new Guid("e88f713a-3f05-4073-a4f1-2e8527137ef9") },
                    { new Guid("167943f6-554d-41cd-9d46-12a618dfd88d"), new Guid("a468a037-a522-4234-85d3-125cb8cb712d"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("19ab21ba-9e03-4880-ac76-a25df04c3683"), new Guid("1341d321-af65-4ea5-9dfa-3bc9250dd8f8"), new Guid("03f69888-97c1-4626-8453-7ac762327e44") },
                    { new Guid("2244cfa2-d258-4aa4-b6cb-25e4908a60b9"), new Guid("35bb9590-5ac0-4f9d-b997-5dd6a9497951"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("2492e5d8-7d0b-4131-a7f1-c205a50ec65a"), new Guid("508a526a-c26c-48d3-a05a-1b93bd50ca4f"), new Guid("bc0a6139-dde8-4e29-8ce1-ce221fc3f078") },
                    { new Guid("28bd3656-3f0a-45b7-baee-5c813b1849fd"), new Guid("896a60a8-3bec-471a-887f-1df89dd2672f"), new Guid("149572f1-7b19-434c-ae5f-0b7982f903fa") },
                    { new Guid("2a4f848f-fee1-4e88-b01d-cb96939e7864"), new Guid("9202fcc2-4d19-4821-b69b-bd1c8db99ec9"), new Guid("cb9af841-6fdb-4d0f-9958-f1043f1ece5b") },
                    { new Guid("2a660869-342e-4d99-98d5-56b9426f030a"), new Guid("6afae337-35fa-4184-8a0d-a2e0301d88b5"), new Guid("3a67d2b3-3f5b-4dcd-8950-918057c8f8c3") },
                    { new Guid("34bce2bd-1f5c-4e41-9c90-f793ccfd2af2"), new Guid("0ed1c849-910b-4015-b3c9-44d990f83158"), new Guid("aeb56c03-eddf-490f-bfe6-b052cc91f669") },
                    { new Guid("3b4f3ee4-a340-4ae0-bac9-f39e4ece2d88"), new Guid("ad987145-c689-4742-b9df-801e698f1f9f"), new Guid("c184664b-be88-432d-9f74-e8476badaa13") },
                    { new Guid("3c5fc023-527b-4a80-bc27-1967a5384478"), new Guid("805256b2-0ba6-44a2-b2f4-965606812824"), new Guid("07fc2ff4-d13f-4dec-a603-cb58d36bb051") },
                    { new Guid("3c9e521f-fbd5-4489-a055-f6cc7d3f865f"), new Guid("462dfb6b-441a-4279-9954-7920ef68aa68"), new Guid("88a14b09-1988-4979-b812-aa42d93d737b") },
                    { new Guid("3fb8c095-2f25-4c88-a402-6e457bb2cec2"), new Guid("a9c55dcc-84a9-4ca5-952f-2fade6166ace"), new Guid("e0e39923-82cc-483a-9eed-f5459a3698cf") },
                    { new Guid("46c09205-8526-476b-a99b-86c93e26fd38"), new Guid("3241c1b6-8e2f-4f0f-8040-3bc891b57d1e"), new Guid("3c68930a-aeb9-4677-aa1a-cb1fcf1bad9b") },
                    { new Guid("4ab1cddd-d0d6-44db-89a2-db55ef1dae55"), new Guid("4dab1208-ca7e-4c9f-88c4-3edfcd90a541"), new Guid("e3f3ef8f-c8f0-4162-b3d0-4d299c326809") },
                    { new Guid("52167755-5858-4f58-b464-7fe82da67de8"), new Guid("61aef041-ce6e-477d-84ab-e8f461b83707"), new Guid("776bae78-ddd1-4162-b313-91943ab9b893") },
                    { new Guid("5d4c24c5-b202-4745-b4d1-ef71453ce6e0"), new Guid("2aff8a1e-2dd0-41a2-80fa-131b55d5b8f2"), new Guid("5b85cf22-a002-43a4-a591-1ec382dd4a33") },
                    { new Guid("6c121b20-5fb8-4fa5-8836-83e166c79b72"), new Guid("af79ae6f-84c5-4c9d-a0de-9cc01c202476"), new Guid("3e136cfb-cfcf-479c-8be1-e29e4b505ede") },
                    { new Guid("6e04940b-7a5e-4925-9217-d3fd8f469f8e"), new Guid("dd2f65fc-4954-4b3a-98d5-1ee0edfe06de"), new Guid("ad57f25a-26ff-4e79-bfb1-6e41e6741085") },
                    { new Guid("71cc182e-fdc8-4890-aa6a-91f6c706ee54"), new Guid("c9e6720b-a035-44f9-90d2-931b6d9b8a8b"), new Guid("0f78a70f-e14d-48a0-819e-1e794fb28bc6") },
                    { new Guid("7e71b9c8-2171-4de0-9d48-666596fa9140"), new Guid("397b2613-95d9-409b-af58-8033a1e74709"), new Guid("7727ae5e-2d20-4f86-b247-8c633ff13b9b") },
                    { new Guid("8088aa35-b677-4505-ac9e-3f23f7cb652e"), new Guid("2f72a756-9c56-4923-ad3a-69d91d40f271"), new Guid("07ad492d-8647-409f-93a7-b4567c04166e") },
                    { new Guid("8296a263-0213-4512-92b0-bd8428b0f8a0"), new Guid("d3a196df-89cd-4c64-82d9-876d4104d862"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("8636bd37-5cb6-4e73-97c7-9af8d425063c"), new Guid("6e64bda7-b7c3-48c2-b10d-6e986fa22c7c"), new Guid("e4bb5d44-162f-4649-8893-ffb7a7df2eca") },
                    { new Guid("873bed9b-aae3-441e-9e81-e44ad23028f1"), new Guid("e3bedcc4-0783-4c3d-b399-faf2eef244be"), new Guid("422863e6-da0f-472a-bc97-311c5fafa8b0") },
                    { new Guid("8af07f75-f19a-4783-a339-7fe44299d7f8"), new Guid("a32c30a4-60e0-4aac-8a4f-c84d79b3ed1d"), new Guid("1ff9bd14-a964-47ac-99fb-42b9f8dd688d") }
                });

            migrationBuilder.InsertData(
                table: "UserPromoCodes",
                columns: new[] { "Id", "PromoCodeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("98ea8dfa-ecfe-4b5b-bd97-ec99a0c5f1a4"), new Guid("4b6606a9-3d10-4e80-b86f-2df77c4371fe"), new Guid("702dc016-070a-4620-818f-b4e492286066") },
                    { new Guid("99cf4fcd-e1bf-4c20-a0a8-9502b5b87cfb"), new Guid("e001f607-8a32-419f-b6d5-3352260e032f"), new Guid("bd6893c5-45c9-40bd-a35a-2d896327c4d7") },
                    { new Guid("9ac09b42-c740-45b2-8b5d-5ad44526fb3a"), new Guid("1315c238-7843-4b14-a6b4-5cbffad29bc4"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("9beba333-6aeb-4153-a41a-f305752ede23"), new Guid("ad987145-c689-4742-b9df-801e698f1f9f"), new Guid("ce685c5c-d243-4b15-90e7-222d72eda73a") },
                    { new Guid("9d4d768e-fd8e-4044-947f-cea48de8fd04"), new Guid("805256b2-0ba6-44a2-b2f4-965606812824"), new Guid("edf37002-a546-4d28-acd9-2614759e640d") },
                    { new Guid("a5c1fe7b-99d7-4e1a-8d65-d1723c691a23"), new Guid("1a1b6b27-d005-41a9-823c-249ddacd02f5"), new Guid("1a71d795-0d73-4afc-ac64-3405f7850ba6") },
                    { new Guid("a891e1a6-0da1-477a-84b8-3f313ae67f11"), new Guid("1315c238-7843-4b14-a6b4-5cbffad29bc4"), new Guid("2a24280c-6e79-420d-bd19-903d44c42081") },
                    { new Guid("af91a7df-047c-4d83-aceb-50654d50a800"), new Guid("85dc2182-15ce-40dd-8db0-913a904b14d6"), new Guid("0b48aacc-b33f-4b28-84f9-623704dc0572") },
                    { new Guid("bb564168-3913-4477-976e-3c6b55d91b60"), new Guid("6afae337-35fa-4184-8a0d-a2e0301d88b5"), new Guid("19c67f23-dfcc-4228-91b6-db840755a673") },
                    { new Guid("bc1c40f0-23db-4e2b-bc70-88a1f972c076"), new Guid("44906530-56b2-4dd8-b521-86a89d9194eb"), new Guid("b7fdbe4b-53e0-4b57-a420-1ed336340097") },
                    { new Guid("bed20919-4246-4ba3-a250-538752893cad"), new Guid("1641013d-0120-4f71-9dda-83496a5d4f8d"), new Guid("d8a6c7db-4910-40c9-9759-6bd649e6132b") },
                    { new Guid("c34a0051-c714-4e51-8e46-ab4e9c542050"), new Guid("82bbef9f-ed60-4c30-8210-da8359cded31"), new Guid("e45bf65d-6a9e-4c36-841a-af761e1b7b17") },
                    { new Guid("cafe0511-19ef-4990-9f5a-fc9eadaa0bce"), new Guid("4d73d7a5-9db5-4fd2-a0ba-77f294de70c1"), new Guid("f078f986-b655-48e0-a855-de9ddc7c92f8") },
                    { new Guid("d1387a4c-2ffc-4320-8e91-26bbaf3912df"), new Guid("1315c238-7843-4b14-a6b4-5cbffad29bc4"), new Guid("50cef9f0-93df-44d5-b89a-756e1c07f39a") },
                    { new Guid("d22bea17-baa6-498b-be1a-b815f7f3686f"), new Guid("d3a196df-89cd-4c64-82d9-876d4104d862"), new Guid("b0c9cec9-3986-43e6-ada1-86601e0c8bc5") },
                    { new Guid("d2ffbc2b-b80a-45e4-bd2d-7495226a23a6"), new Guid("76003919-6702-4849-a6e1-647b4ec8d669"), new Guid("1e56e621-bc49-41e9-902d-c2c5b5206eeb") },
                    { new Guid("d6af5156-32b5-43df-956b-be7d90ec3d4a"), new Guid("1a1b6b27-d005-41a9-823c-249ddacd02f5"), new Guid("e669a526-a48b-454d-bfb1-91d7ee55faf0") },
                    { new Guid("d9e362ed-b3a6-4951-9004-5d5ceb58e034"), new Guid("c162a2d1-fa43-4c01-815e-3045adf099c8"), new Guid("05acfeaa-9cd8-425e-9336-adc6ab683813") },
                    { new Guid("db00b958-d6ad-45b4-b571-91c756d997d7"), new Guid("1641013d-0120-4f71-9dda-83496a5d4f8d"), new Guid("7ca99751-5750-4154-8f4c-f25241a8edd9") },
                    { new Guid("de0e5cb4-894c-4fbb-930e-e67984b5eb56"), new Guid("1a1b6b27-d005-41a9-823c-249ddacd02f5"), new Guid("87680e09-9e1c-41de-a3cd-2c3e59b3a912") },
                    { new Guid("e43fef27-3136-4514-beee-bfa15257bac4"), new Guid("a32c30a4-60e0-4aac-8a4f-c84d79b3ed1d"), new Guid("9e48e8f6-fb1f-4976-9b16-160b2ec661bf") },
                    { new Guid("e4c510c6-3215-4323-8a5f-6ff67705fbb0"), new Guid("084b14da-2861-42fe-8fca-e59ecedbac19"), new Guid("c8a0bce5-4606-4c68-a775-b810e12f667f") },
                    { new Guid("e5bb9ce3-aad7-45a9-bba3-38c204977843"), new Guid("896a60a8-3bec-471a-887f-1df89dd2672f"), new Guid("8206ebce-6988-4bbe-a696-1449919f6b27") },
                    { new Guid("ec40d03d-272c-436d-b924-b0a89e0cd302"), new Guid("69ef6a1b-ea81-4676-bc34-ba5453e63353"), new Guid("8861729f-4a56-4d39-bc73-6365e353facd") },
                    { new Guid("edeeec95-04e7-43ac-8af3-f438aa611abe"), new Guid("3241cbc8-60c7-4d85-bc94-5e47de93cd50"), new Guid("c09824ba-8b72-4c6e-bf98-87c5a3186865") },
                    { new Guid("ee0839e7-1b09-463c-a5f7-875175be384d"), new Guid("ce261e52-1d13-432b-8ada-e5e43db84e96"), new Guid("97b4e705-6daa-45fb-ba27-7f6a319f847c") },
                    { new Guid("efc2aa31-1f48-41dd-b25a-10268c0c3247"), new Guid("bf92627d-6a1e-464a-bf99-2e82c2acee50"), new Guid("4a16f415-5ed6-4569-95cb-9911520606c0") },
                    { new Guid("f1f287fa-143a-4c9e-83a1-28bfb8fda06c"), new Guid("bf92627d-6a1e-464a-bf99-2e82c2acee50"), new Guid("13093d30-7eb6-4bbd-8c92-f4045502d6b7") },
                    { new Guid("f5d94f4f-c6d8-4130-a46d-c3f699b07232"), new Guid("bef25f38-12fb-444e-a77e-2476d5dba1e9"), new Guid("57e87c72-5541-4451-bbea-b6a4e815221f") },
                    { new Guid("fea07b2b-d240-4cdb-9c41-63e9a90cc29f"), new Guid("1a1b6b27-d005-41a9-823c-249ddacd02f5"), new Guid("803cf10b-1d6e-48e2-a03b-ea457046e70a") }
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
