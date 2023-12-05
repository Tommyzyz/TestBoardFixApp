using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestBoardFixApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_FixFileData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsFixed = table.Column<bool>(type: "boolean", nullable: false),
                    TestMachingType = table.Column<string>(type: "text", nullable: false),
                    TestMachingNum = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BoardName = table.Column<string>(type: "text", nullable: true),
                    BoardNum = table.Column<string>(type: "text", nullable: true),
                    Abnormalphenomena = table.Column<string>(type: "text", nullable: true),
                    AbnormalString = table.Column<string>(type: "text", nullable: true),
                    ProductName = table.Column<string>(type: "text", nullable: true),
                    FixWay = table.Column<string>(type: "text", nullable: true),
                    RegisteredPerson = table.Column<string>(type: "text", nullable: true),
                    StartFixDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Other = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_FixFileData", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_FixFileData");
        }
    }
}
