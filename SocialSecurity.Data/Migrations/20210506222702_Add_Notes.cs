using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialSecurity.Data.Migrations
{
    public partial class Add_Notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ERNote",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NoteDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
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
                    table.PrimaryKey("PK_ERNote", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ERNote_ERMaster_ERMasterID",
                        column: x => x.ERMasterID,
                        principalTable: "ERMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPNote",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NoteDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
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
                    table.PrimaryKey("PK_IPNote", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IPNote_IPMaster_InsuredPersonID",
                        column: x => x.InsuredPersonID,
                        principalTable: "IPMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ERNote_ERMasterID",
                table: "ERNote",
                column: "ERMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_IPNote_InsuredPersonID",
                table: "IPNote",
                column: "InsuredPersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ERNote");

            migrationBuilder.DropTable(
                name: "IPNote");
        }
    }
}
