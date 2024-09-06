using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sandbox.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Todos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
