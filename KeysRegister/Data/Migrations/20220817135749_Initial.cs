using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KeysRegister.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Identifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RfidCode = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identifiers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Identifiers",
                columns: new[] { "Id", "Description", "FirstName", "LastName", "RfidCode", "Type" },
                values: new object[,]
                {
                    { 1, "Dział IT", "Jan", "Kowalski", "0010614285", 1 },
                    { 2, "Dział Transportu", "Arkadiusz", "Nowak", "0004714539", 1 },
                    { 3, "100", "DZG27216", "", "0011079912", 0 },
                    { 4, "185", "DZG27215", "", "0004861400", 0 },
                    { 5, "185", "DZG00009", "", "0004734756", 0 },
                    { 6, "188", "DZG10001", "", "0004968393", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identifiers_RfidCode",
                table: "Identifiers",
                column: "RfidCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identifiers");
        }
    }
}
