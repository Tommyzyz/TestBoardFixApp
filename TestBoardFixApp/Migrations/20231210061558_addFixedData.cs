using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TestBoardFixApp.Migrations
{
    /// <inheritdoc />
    public partial class addFixedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FixedFileData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegisteredPerson = table.Column<string>(type: "text", nullable: true),
                    TestingMethod = table.Column<string>(type: "text", nullable: true),
                    FixdMethod = table.Column<string>(type: "text", nullable: true),
                    EndFixDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Other2 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedFileData", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixedFileData");
        }
    }
}
