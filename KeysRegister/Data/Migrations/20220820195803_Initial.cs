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

            migrationBuilder.CreateTable(
                name: "ReleasedKeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyId = table.Column<int>(type: "integer", nullable: false),
                    KeyName = table.Column<string>(type: "text", nullable: true),
                    KeyInfo = table.Column<string>(type: "text", nullable: true),
                    KeyDescription = table.Column<string>(type: "text", nullable: true),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "text", nullable: true),
                    EmployeeLastName = table.Column<string>(type: "text", nullable: true),
                    EmployeeDescription = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasedKeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReleasedKeysHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyId = table.Column<int>(type: "integer", nullable: false),
                    KeyName = table.Column<string>(type: "text", nullable: false),
                    KeyInfo = table.Column<string>(type: "text", nullable: false),
                    KeyDescription = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "text", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "text", nullable: false),
                    EmployeeDescription = table.Column<string>(type: "text", nullable: false),
                    KeyOperatiomType = table.Column<int>(type: "integer", nullable: false),
                    OperationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasedKeysHistory", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Identifiers",
                columns: new[] { "Id", "Description", "FirstName", "LastName", "RfidCode", "Type" },
                values: new object[,]
                {
                    { 1, "Dział IT", "Jan", "Kowalski", "0010614285", 1 },
                    { 2, "Dział Transportu", "Arkadiusz", "Nowak", "0004714539", 1 },
                    { 3, "Id 100", "DZG27216", "Samochód osobowy", "0011079912", 0 },
                    { 4, "Id 101", "DZG27215", "Samochód osobowy", "0004861400", 0 },
                    { 5, "Nr boczny 185", "DZG00009", "Samochód ciężarowy", "0004734756", 0 },
                    { 6, "Nr boczny 188", "DZG10001", "Samochód ciężarowy", "0004968393", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Identifiers_RfidCode",
                table: "Identifiers",
                column: "RfidCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReleasedKeys_KeyId",
                table: "ReleasedKeys",
                column: "KeyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Identifiers");

            migrationBuilder.DropTable(
                name: "ReleasedKeys");

            migrationBuilder.DropTable(
                name: "ReleasedKeysHistory");
        }
    }
}
