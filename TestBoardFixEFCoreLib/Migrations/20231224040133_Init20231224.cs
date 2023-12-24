using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestBoardFixEFCoreLib.Migrations
{
    /// <inheritdoc />
    public partial class Init20231224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_FixFileData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsFixed = table.Column<bool>(type: "boolean", nullable: false),
                    TestMachingType = table.Column<string>(type: "text", nullable: false),
                    TestMachingNum = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BoardName = table.Column<string>(type: "text", nullable: false),
                    BoardNum = table.Column<string>(type: "text", nullable: false),
                    Abnormalphenomena = table.Column<string>(type: "text", nullable: false),
                    AbnormalString = table.Column<string>(type: "text", nullable: false),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    FixWay = table.Column<string>(type: "text", nullable: false),
                    RegisteredPerson = table.Column<string>(type: "text", nullable: false),
                    StartFixDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Other = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_FixFileData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Table_FixedFileData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisteredPerson = table.Column<string>(type: "text", nullable: false),
                    TestingMethod = table.Column<string>(type: "text", nullable: false),
                    FixdMethod = table.Column<string>(type: "text", nullable: false),
                    EndFixDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Other2 = table.Column<string>(type: "text", nullable: true),
                    FixFileDataID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_FixedFileData", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Table_FixedFileData_Table_FixFileData_FixFileDataID",
                        column: x => x.FixFileDataID,
                        principalTable: "Table_FixFileData",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Table_FixedFileData_FixFileDataID",
                table: "Table_FixedFileData",
                column: "FixFileDataID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_FixedFileData");

            migrationBuilder.DropTable(
                name: "Table_FixFileData");
        }
    }
}
