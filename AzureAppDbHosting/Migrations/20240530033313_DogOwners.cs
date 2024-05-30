using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureAppDbHosting.Migrations
{
    /// <inheritdoc />
    public partial class DogOwners : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LeadSource",
                table: "Leads",
                newName: "OwnerWalker");

            migrationBuilder.CreateTable(
                name: "DogOwners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogBreed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogAge = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogOwners", x => x.OwnerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogOwners");

            migrationBuilder.RenameColumn(
                name: "OwnerWalker",
                table: "Leads",
                newName: "LeadSource");
        }
    }
}
