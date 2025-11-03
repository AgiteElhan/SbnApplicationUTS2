using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SbnApplicationUTS2.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBuyerTableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Buyers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Buyers");
        }
    }
}
