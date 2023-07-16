using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EducationStatusUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Educations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Educations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
