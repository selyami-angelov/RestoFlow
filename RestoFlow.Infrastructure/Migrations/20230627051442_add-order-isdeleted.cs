using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class addorderisdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Orders");
        }
    }
}
