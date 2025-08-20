using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HYBS2025.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TexNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyBalance = table.Column<int>(type: "int", nullable: false),
                    CompanyDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentTip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headings",
                columns: table => new
                {
                    HeadingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadingAdres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadingAda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadingParsel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeadingStatus = table.Column<bool>(type: "bit", nullable: false),
                    AddedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedByUserNamee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headings", x => x.HeadingID);
                });

            migrationBuilder.CreateTable(
                name: "Ilceler",
                columns: table => new
                {
                    IlceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    surname = table.Column<int>(type: "int", nullable: false),
                    IlceAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilceler", x => x.IlceID);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                });

            migrationBuilder.CreateTable(
                name: "SmallVehicles",
                columns: table => new
                {
                    SmallVehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmallVehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmallVehicles", x => x.SmallVehicleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonAbout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBalances",
                columns: table => new
                {
                    CompanyBalanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FillArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Island = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBalances", x => x.CompanyBalanceID);
                    table.ForeignKey(
                        name: "FK_CompanyBalances_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "CompanyDocuments",
                columns: table => new
                {
                    CompanyDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDocuments", x => x.CompanyDocumentId);
                    table.ForeignKey(
                        name: "FK_CompanyDocuments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complainant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplainantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lookperson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Process = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_Complaints_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fillings",
                columns: table => new
                {
                    FillingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartIsland = table.Column<int>(type: "int", nullable: false),
                    FınıshIsland = table.Column<int>(type: "int", nullable: false),
                    StartParcel = table.Column<int>(type: "int", nullable: false),
                    FınıshParcel = table.Column<int>(type: "int", nullable: false),
                    StartDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FınıshDıstrıct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kazı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dolgu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fillings", x => x.FillingId);
                    table.ForeignKey(
                        name: "FK_Fillings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "infrastructureworks",
                columns: table => new
                {
                    lowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FınıshDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IhaleNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IhaleDökuman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IhaleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectDökuman = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_infrastructureworks", x => x.lowerId);
                    table.ForeignKey(
                        name: "FK_infrastructureworks_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peyzajs",
                columns: table => new
                {
                    PeyzajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartIsland = table.Column<int>(type: "int", nullable: false),
                    FınıshIsland = table.Column<int>(type: "int", nullable: false),
                    StartParcel = table.Column<int>(type: "int", nullable: false),
                    FınıshParcel = table.Column<int>(type: "int", nullable: false),
                    StartDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FınıshDıstrıct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kazı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dolgu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peyzajs", x => x.PeyzajId);
                    table.ForeignKey(
                        name: "FK_Peyzajs_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleTip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleHGS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleIMEI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleDara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleIzinBitis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mahalleler",
                columns: table => new
                {
                    MahalleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MahalleAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahalleler", x => x.MahalleID);
                    table.ForeignKey(
                        name: "FK_Mahalleler_Ilceler_IlceID",
                        column: x => x.IlceID,
                        principalTable: "Ilceler",
                        principalColumn: "IlceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherStructures",
                columns: table => new
                {
                    OtherStructureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nereye = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartIsland = table.Column<int>(type: "int", nullable: false),
                    FinishIsland = table.Column<int>(type: "int", nullable: false),
                    StartParcel = table.Column<int>(type: "int", nullable: false),
                    StartDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinishDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TalepEden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherStructures", x => x.OtherStructureId);
                    table.ForeignKey(
                        name: "FK_OtherStructures_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherStructures_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtherStructures_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OtherStructures_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    StructureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermitNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclePlaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UreticiName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UreticiPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UreticiAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Island = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    Blok = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Excavation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmptyExcavation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtikCinsi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Casting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcavationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnsonIslem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BekleyenIslem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kazi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Dolgu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.StructureId);
                    table.ForeignKey(
                        name: "FK_Structures_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Structures_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Structures_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Structures_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BalanceSmalls",
                columns: table => new
                {
                    BalanceSmallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TahakkukMiktarı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Island = table.Column<int>(type: "int", nullable: false),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SmallVehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceSmalls", x => x.BalanceSmallId);
                    table.ForeignKey(
                        name: "FK_BalanceSmalls_SmallVehicles_SmallVehicleId",
                        column: x => x.SmallVehicleId,
                        principalTable: "SmallVehicles",
                        principalColumn: "SmallVehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ContentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentMahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentAdaNo = table.Column<int>(type: "int", nullable: false),
                    ContentParselNo = table.Column<int>(type: "int", nullable: false),
                    ContentSonuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContentStatus = table.Column<bool>(type: "bit", nullable: false),
                    HeadingID = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    WriterPersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentID);
                    table.ForeignKey(
                        name: "FK_Contents_Headings_HeadingID",
                        column: x => x.HeadingID,
                        principalTable: "Headings",
                        principalColumn: "HeadingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Users_WriterPersonId",
                        column: x => x.WriterPersonId,
                        principalTable: "Users",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Punishments",
                columns: table => new
                {
                    CezaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTipi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CezaTeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CezaPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CezaAmont = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CezaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    AracVehicleId = table.Column<int>(type: "int", nullable: false),
                    PersonnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UserPersonId = table.Column<int>(type: "int", nullable: false),
                    BelgeDurumu = table.Column<int>(type: "int", nullable: false),
                    Personel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Punishments", x => x.CezaId);
                    table.ForeignKey(
                        name: "FK_Punishments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Punishments_Users_UserPersonId",
                        column: x => x.UserPersonId,
                        principalTable: "Users",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Punishments_Vehicles_AracVehicleId",
                        column: x => x.AracVehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceSmalls_SmallVehicleId",
                table: "BalanceSmalls",
                column: "SmallVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBalances_CompanyId",
                table: "CompanyBalances",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDocuments_CompanyId",
                table: "CompanyDocuments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_CompanyId",
                table: "Complaints",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_HeadingID",
                table: "Contents",
                column: "HeadingID");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_WriterPersonId",
                table: "Contents",
                column: "WriterPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Fillings_CompanyId",
                table: "Fillings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_infrastructureworks_CompanyId",
                table: "infrastructureworks",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahalleler_IlceID",
                table: "Mahalleler",
                column: "IlceID");

            migrationBuilder.CreateIndex(
                name: "IX_OtherStructures_CityId",
                table: "OtherStructures",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherStructures_CompanyId",
                table: "OtherStructures",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherStructures_DistrictId",
                table: "OtherStructures",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherStructures_NeighborhoodId",
                table: "OtherStructures",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Peyzajs_CompanyId",
                table: "Peyzajs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_AracVehicleId",
                table: "Punishments",
                column: "AracVehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_CompanyId",
                table: "Punishments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Punishments_UserPersonId",
                table: "Punishments",
                column: "UserPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_CityId",
                table: "Structures",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_CompanyId",
                table: "Structures",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_DistrictId",
                table: "Structures",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_NeighborhoodId",
                table: "Structures",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CompanyId",
                table: "Vehicles",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceSmalls");

            migrationBuilder.DropTable(
                name: "CompanyBalances");

            migrationBuilder.DropTable(
                name: "CompanyDocuments");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "DocumentStatuses");

            migrationBuilder.DropTable(
                name: "Fillings");

            migrationBuilder.DropTable(
                name: "infrastructureworks");

            migrationBuilder.DropTable(
                name: "Mahalleler");

            migrationBuilder.DropTable(
                name: "OtherStructures");

            migrationBuilder.DropTable(
                name: "Peyzajs");

            migrationBuilder.DropTable(
                name: "Punishments");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "SmallVehicles");

            migrationBuilder.DropTable(
                name: "Headings");

            migrationBuilder.DropTable(
                name: "Ilceler");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
