using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialSecurity.Data.Migrations
{
    public partial class Initialize_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ERMaster",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmployerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TradeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApprovedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ERMaster", x => x.ID);
                    table.UniqueConstraint("AK_ERMaster_EmployerName", x => x.EmployerName);
                    table.UniqueConstraint("AK_ERMaster_RegistrationNumber", x => x.RegistrationNumber);
                    table.UniqueConstraint("AK_ERMaster_TradeName", x => x.TradeName);
                });

            migrationBuilder.CreateTable(
                name: "IPAddressApproved",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressApproval = table.Column<bool>(type: "bit", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPAddressApproved", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IPEmploymentTypeApproval",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentTypeApproval = table.Column<bool>(type: "bit", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPEmploymentTypeApproval", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IPOccupationApproved",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationApproval = table.Column<bool>(type: "bit", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPOccupationApproved", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IPSSN",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSN = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPSSN", x => x.ID);
                    table.UniqueConstraint("AK_IPSSN_SSN", x => x.SSN);
                });

            migrationBuilder.CreateTable(
                name: "PersonTasks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceEntity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DateToBeCompleted = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTasks", x => x.ID);
                    table.UniqueConstraint("AK_PersonTasks_UserID_ID", x => new { x.UserID, x.ID });
                });

            migrationBuilder.CreateTable(
                name: "TableCollection",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableCollection", x => x.ID);
                    table.UniqueConstraint("AK_TableCollection_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableCountry",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableCountry", x => x.ID);
                    table.UniqueConstraint("AK_TableCountry_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableDistrict",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDistrict", x => x.ID);
                    table.UniqueConstraint("AK_TableDistrict_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableDocumentType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableDocumentType", x => x.ID);
                    table.UniqueConstraint("AK_TableDocumentType_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableEmploymentType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableEmploymentType", x => x.ID);
                    table.UniqueConstraint("AK_TableEmploymentType_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableIndustry",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableIndustry", x => x.ID);
                    table.UniqueConstraint("AK_TableIndustry_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableMaritalStatus",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableMaritalStatus", x => x.ID);
                    table.UniqueConstraint("AK_TableMaritalStatus_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableNationality",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableNationality", x => x.ID);
                    table.UniqueConstraint("AK_TableNationality_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableOccupation",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableOccupation", x => x.ID);
                    table.UniqueConstraint("AK_TableOccupation_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableParish",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableParish", x => x.ID);
                    table.UniqueConstraint("AK_TableParish_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TablePostalCode",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePostalCode", x => x.ID);
                    table.UniqueConstraint("AK_TablePostalCode_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TablePostOffice",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePostOffice", x => x.ID);
                    table.UniqueConstraint("AK_TablePostOffice_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableStreet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableStreet", x => x.ID);
                    table.UniqueConstraint("AK_TableStreet_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableTaskPriority",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTaskPriority", x => x.ID);
                    table.UniqueConstraint("AK_TableTaskPriority_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableTaskReferenceType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTaskReferenceType", x => x.ID);
                    table.UniqueConstraint("AK_TableTaskReferenceType_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableTaskStatus",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTaskStatus", x => x.ID);
                    table.UniqueConstraint("AK_TableTaskStatus_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "TableTaskType",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableTaskType", x => x.ID);
                    table.UniqueConstraint("AK_TableTaskType_Code", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "ERBasic2",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfBranches = table.Column<int>(type: "int", nullable: false),
                    NumberOfDirectors = table.Column<int>(type: "int", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    SurnamePersonRegistering = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    FirstNamePersonRegistering = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MiddleNamePersonRegistering = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    PositionPersonRegistering = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    ERMasterID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ERBasic2", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ERBasic2_ERMaster_ERMasterID",
                        column: x => x.ERMasterID,
                        principalTable: "ERMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ERContact",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MainTelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryTelephoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERMasterID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ERContact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ERContact_ERMaster_ERMasterID",
                        column: x => x.ERMasterID,
                        principalTable: "ERMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ERDirector",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    ManagingDirector = table.Column<bool>(type: "bit", nullable: false),
                    ERMasterID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ERDirector", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ERDirector_ERMaster_ERMasterID",
                        column: x => x.ERMasterID,
                        principalTable: "ERMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPMaster",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    OtherName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    IPSSNID = table.Column<long>(type: "bigint", nullable: true),
                    ApprovedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPMaster_IPSSN_IPSSNID",
                        column: x => x.IPSSNID,
                        principalTable: "IPSSN",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ERBasic",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessAddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessAddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BusinessParishID = table.Column<long>(type: "bigint", nullable: true),
                    BusinessPostalCodeID = table.Column<long>(type: "bigint", nullable: true),
                    BusinessDistrictID = table.Column<long>(type: "bigint", nullable: true),
                    BusinessStreetID = table.Column<long>(type: "bigint", nullable: true),
                    BusinessPostOfficeID = table.Column<long>(type: "bigint", nullable: true),
                    MailingAddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MailingAddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MailingParishID = table.Column<long>(type: "bigint", nullable: true),
                    MailingPostalCodeID = table.Column<long>(type: "bigint", nullable: true),
                    MailingDistrictID = table.Column<long>(type: "bigint", nullable: true),
                    MailingStreetID = table.Column<long>(type: "bigint", nullable: true),
                    MailingPostOfficeID = table.Column<long>(type: "bigint", nullable: true),
                    IndustryID = table.Column<long>(type: "bigint", nullable: true),
                    NatureOfBusiness = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LocationOfRecords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CollectorateOfPayment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CollectionID = table.Column<long>(type: "bigint", nullable: true),
                    DateOfLiability = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ERMasterID = table.Column<long>(type: "bigint", nullable: false),
                    ApprovedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ERBasic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ERBasic_ERMaster_ERMasterID",
                        column: x => x.ERMasterID,
                        principalTable: "ERMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableCollection_CollectionID",
                        column: x => x.CollectionID,
                        principalTable: "TableCollection",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableDistrict_BusinessDistrictID",
                        column: x => x.BusinessDistrictID,
                        principalTable: "TableDistrict",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableDistrict_MailingDistrictID",
                        column: x => x.MailingDistrictID,
                        principalTable: "TableDistrict",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableIndustry_IndustryID",
                        column: x => x.IndustryID,
                        principalTable: "TableIndustry",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableParish_BusinessParishID",
                        column: x => x.BusinessParishID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableParish_MailingParishID",
                        column: x => x.MailingParishID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TablePostalCode_BusinessPostalCodeID",
                        column: x => x.BusinessPostalCodeID,
                        principalTable: "TablePostalCode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TablePostalCode_MailingPostalCodeID",
                        column: x => x.MailingPostalCodeID,
                        principalTable: "TablePostalCode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TablePostOffice_BusinessPostOfficeID",
                        column: x => x.BusinessPostOfficeID,
                        principalTable: "TablePostOffice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TablePostOffice_MailingPostOfficeID",
                        column: x => x.MailingPostOfficeID,
                        principalTable: "TablePostOffice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableStreet_BusinessStreetID",
                        column: x => x.BusinessStreetID,
                        principalTable: "TableStreet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ERBasic_TableStreet_MailingStreetID",
                        column: x => x.MailingStreetID,
                        principalTable: "TableStreet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPAddress",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ParishID = table.Column<long>(type: "bigint", nullable: true),
                    PostalCodeID = table.Column<long>(type: "bigint", nullable: true),
                    DistrictID = table.Column<long>(type: "bigint", nullable: true),
                    StreetID = table.Column<long>(type: "bigint", nullable: true),
                    PostOfficeID = table.Column<long>(type: "bigint", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    ApprovedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPAddress", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPAddress_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPAddress_TableDistrict_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "TableDistrict",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPAddress_TableParish_ParishID",
                        column: x => x.ParishID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPAddress_TablePostalCode_PostalCodeID",
                        column: x => x.PostalCodeID,
                        principalTable: "TablePostalCode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPAddress_TablePostOffice_PostOfficeID",
                        column: x => x.PostOfficeID,
                        principalTable: "TablePostOffice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPAddress_TableStreet_StreetID",
                        column: x => x.StreetID,
                        principalTable: "TableStreet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPBasic",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AliasName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NationalRegistrationNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OccupationFreeform = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    PreviousName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MotherSurname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MotherFirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MotherMiddleName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MotherMaidenName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    FatherSurname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    FatherFirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryOfBirthID = table.Column<long>(type: "bigint", nullable: true),
                    NationalityID = table.Column<long>(type: "bigint", nullable: true),
                    OccupationID = table.Column<long>(type: "bigint", nullable: true),
                    ParishID = table.Column<long>(type: "bigint", nullable: true),
                    PostalCodeID = table.Column<long>(type: "bigint", nullable: true),
                    DistrictID = table.Column<long>(type: "bigint", nullable: true),
                    StreetID = table.Column<long>(type: "bigint", nullable: true),
                    PostOfficeID = table.Column<long>(type: "bigint", nullable: true),
                    EmploymentTypeID = table.Column<long>(type: "bigint", nullable: true),
                    MaritalStatusID = table.Column<long>(type: "bigint", nullable: true),
                    ParishOfBirthID = table.Column<long>(type: "bigint", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    ApprovedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPBasic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPBasic_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableCountry_CountryOfBirthID",
                        column: x => x.CountryOfBirthID,
                        principalTable: "TableCountry",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableDistrict_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "TableDistrict",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableEmploymentType_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "TableEmploymentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableMaritalStatus_MaritalStatusID",
                        column: x => x.MaritalStatusID,
                        principalTable: "TableMaritalStatus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableNationality_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "TableNationality",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableOccupation_OccupationID",
                        column: x => x.OccupationID,
                        principalTable: "TableOccupation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableParish_ParishID",
                        column: x => x.ParishID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableParish_ParishOfBirthID",
                        column: x => x.ParishOfBirthID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TablePostalCode_PostalCodeID",
                        column: x => x.PostalCodeID,
                        principalTable: "TablePostalCode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TablePostOffice_PostOfficeID",
                        column: x => x.PostOfficeID,
                        principalTable: "TablePostOffice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPBasic_TableStreet_StreetID",
                        column: x => x.StreetID,
                        principalTable: "TableStreet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPContact",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelephoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPContact", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPContact_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPRegEmployer",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ActiveEmployer = table.Column<bool>(type: "bit", nullable: false),
                    EmployerAddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmployerAddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmployerParishID = table.Column<long>(type: "bigint", nullable: true),
                    EmployerPostalCodeID = table.Column<long>(type: "bigint", nullable: true),
                    EmployerDistrictID = table.Column<long>(type: "bigint", nullable: true),
                    EmployerStreetID = table.Column<long>(type: "bigint", nullable: true),
                    EmployerPostOfficeID = table.Column<long>(type: "bigint", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPRegEmployer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_TableDistrict_EmployerDistrictID",
                        column: x => x.EmployerDistrictID,
                        principalTable: "TableDistrict",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_TableParish_EmployerParishID",
                        column: x => x.EmployerParishID,
                        principalTable: "TableParish",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_TablePostalCode_EmployerPostalCodeID",
                        column: x => x.EmployerPostalCodeID,
                        principalTable: "TablePostalCode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_TablePostOffice_EmployerPostOfficeID",
                        column: x => x.EmployerPostOfficeID,
                        principalTable: "TablePostOffice",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPRegEmployer_TableStreet_EmployerStreetID",
                        column: x => x.EmployerStreetID,
                        principalTable: "TableStreet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPRegistrationDocument",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPRegistrationDocument", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPRegistrationDocument_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPRegistrationDocument_TableDocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "TableDocumentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPSpouse",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Firstname = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    MaidenName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfMarriage = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuredPersonID = table.Column<long>(type: "bigint", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedById = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CreatedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedDateTimeUtc = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPSpouse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPSpouse_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_BusinessDistrictID",
                table: "ERBasic",
                column: "BusinessDistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_BusinessParishID",
                table: "ERBasic",
                column: "BusinessParishID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_BusinessPostalCodeID",
                table: "ERBasic",
                column: "BusinessPostalCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_BusinessPostOfficeID",
                table: "ERBasic",
                column: "BusinessPostOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_BusinessStreetID",
                table: "ERBasic",
                column: "BusinessStreetID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_CollectionID",
                table: "ERBasic",
                column: "CollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_ERMasterID",
                table: "ERBasic",
                column: "ERMasterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_IndustryID",
                table: "ERBasic",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_MailingDistrictID",
                table: "ERBasic",
                column: "MailingDistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_MailingParishID",
                table: "ERBasic",
                column: "MailingParishID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_MailingPostalCodeID",
                table: "ERBasic",
                column: "MailingPostalCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_MailingPostOfficeID",
                table: "ERBasic",
                column: "MailingPostOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic_MailingStreetID",
                table: "ERBasic",
                column: "MailingStreetID");

            migrationBuilder.CreateIndex(
                name: "IX_ERBasic2_ERMasterID",
                table: "ERBasic2",
                column: "ERMasterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ERContact_ERMasterID",
                table: "ERContact",
                column: "ERMasterID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ERDirector_ERMasterID",
                table: "ERDirector",
                column: "ERMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_DistrictID",
                table: "IPAddress",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_InsuredPersonID",
                table: "IPAddress",
                column: "InsuredPersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_ParishID",
                table: "IPAddress",
                column: "ParishID");

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_PostalCodeID",
                table: "IPAddress",
                column: "PostalCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_PostOfficeID",
                table: "IPAddress",
                column: "PostOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPAddress_StreetID",
                table: "IPAddress",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_CountryOfBirthID",
                table: "IPBasic",
                column: "CountryOfBirthID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_DistrictID",
                table: "IPBasic",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_EmploymentTypeID",
                table: "IPBasic",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_InsuredPersonID",
                table: "IPBasic",
                column: "InsuredPersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_MaritalStatusID",
                table: "IPBasic",
                column: "MaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_NationalityID",
                table: "IPBasic",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_OccupationID",
                table: "IPBasic",
                column: "OccupationID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_ParishID",
                table: "IPBasic",
                column: "ParishID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_ParishOfBirthID",
                table: "IPBasic",
                column: "ParishOfBirthID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_PostalCodeID",
                table: "IPBasic",
                column: "PostalCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_PostOfficeID",
                table: "IPBasic",
                column: "PostOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPBasic_StreetID",
                table: "IPBasic",
                column: "StreetID");

            migrationBuilder.CreateIndex(
                name: "IX_IPContact_InsuredPersonID",
                table: "IPContact",
                column: "InsuredPersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IPMaster_IPSSNID",
                table: "IPMaster",
                column: "IPSSNID");

            migrationBuilder.CreateIndex(
                name: "IX_IPMaster_Surname_FirstName_MiddleName",
                table: "IPMaster",
                columns: new[] { "Surname", "FirstName", "MiddleName" });

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_EmployerDistrictID",
                table: "IPRegEmployer",
                column: "EmployerDistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_EmployerParishID",
                table: "IPRegEmployer",
                column: "EmployerParishID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_EmployerPostalCodeID",
                table: "IPRegEmployer",
                column: "EmployerPostalCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_EmployerPostOfficeID",
                table: "IPRegEmployer",
                column: "EmployerPostOfficeID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_EmployerStreetID",
                table: "IPRegEmployer",
                column: "EmployerStreetID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegEmployer_InsuredPersonID",
                table: "IPRegEmployer",
                column: "InsuredPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegistrationDocument_DocumentTypeId",
                table: "IPRegistrationDocument",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IPRegistrationDocument_InsuredPersonID",
                table: "IPRegistrationDocument",
                column: "InsuredPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_IPSpouse_InsuredPersonID",
                table: "IPSpouse",
                column: "InsuredPersonID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonTasks_UserID",
                table: "PersonTasks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TableCollection_ShortDescription",
                table: "TableCollection",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableCountry_ShortDescription",
                table: "TableCountry",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableDistrict_ShortDescription",
                table: "TableDistrict",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableDocumentType_ShortDescription",
                table: "TableDocumentType",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableEmploymentType_ShortDescription",
                table: "TableEmploymentType",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableIndustry_ShortDescription",
                table: "TableIndustry",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableMaritalStatus_ShortDescription",
                table: "TableMaritalStatus",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableNationality_ShortDescription",
                table: "TableNationality",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableOccupation_ShortDescription",
                table: "TableOccupation",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableParish_ShortDescription",
                table: "TableParish",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TablePostalCode_ShortDescription",
                table: "TablePostalCode",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TablePostOffice_ShortDescription",
                table: "TablePostOffice",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableStreet_ShortDescription",
                table: "TableStreet",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableTaskPriority_ShortDescription",
                table: "TableTaskPriority",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableTaskReferenceType_ShortDescription",
                table: "TableTaskReferenceType",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableTaskStatus_ShortDescription",
                table: "TableTaskStatus",
                column: "ShortDescription");

            migrationBuilder.CreateIndex(
                name: "IX_TableTaskType_ShortDescription",
                table: "TableTaskType",
                column: "ShortDescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ERBasic");

            migrationBuilder.DropTable(
                name: "ERBasic2");

            migrationBuilder.DropTable(
                name: "ERContact");

            migrationBuilder.DropTable(
                name: "ERDirector");

            migrationBuilder.DropTable(
                name: "IPAddress");

            migrationBuilder.DropTable(
                name: "IPAddressApproved");

            migrationBuilder.DropTable(
                name: "IPBasic");

            migrationBuilder.DropTable(
                name: "IPContact");

            migrationBuilder.DropTable(
                name: "IPEmploymentTypeApproval");

            migrationBuilder.DropTable(
                name: "IPOccupationApproved");

            migrationBuilder.DropTable(
                name: "IPRegEmployer");

            migrationBuilder.DropTable(
                name: "IPRegistrationDocument");

            migrationBuilder.DropTable(
                name: "IPSpouse");

            migrationBuilder.DropTable(
                name: "PersonTasks");

            migrationBuilder.DropTable(
                name: "TableTaskPriority");

            migrationBuilder.DropTable(
                name: "TableTaskReferenceType");

            migrationBuilder.DropTable(
                name: "TableTaskStatus");

            migrationBuilder.DropTable(
                name: "TableTaskType");

            migrationBuilder.DropTable(
                name: "TableCollection");

            migrationBuilder.DropTable(
                name: "TableIndustry");

            migrationBuilder.DropTable(
                name: "ERMaster");

            migrationBuilder.DropTable(
                name: "TableCountry");

            migrationBuilder.DropTable(
                name: "TableEmploymentType");

            migrationBuilder.DropTable(
                name: "TableMaritalStatus");

            migrationBuilder.DropTable(
                name: "TableNationality");

            migrationBuilder.DropTable(
                name: "TableOccupation");

            migrationBuilder.DropTable(
                name: "TableDistrict");

            migrationBuilder.DropTable(
                name: "TableParish");

            migrationBuilder.DropTable(
                name: "TablePostalCode");

            migrationBuilder.DropTable(
                name: "TablePostOffice");

            migrationBuilder.DropTable(
                name: "TableStreet");

            migrationBuilder.DropTable(
                name: "TableDocumentType");

            migrationBuilder.DropTable(
                name: "IPMaster");

            migrationBuilder.DropTable(
                name: "IPSSN");
        }
    }
}
