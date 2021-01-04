using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentAPI.Migrations
{
    public partial class UserCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AppointmentDetails",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AppointmentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AppointmentDetails");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AppointmentDetails");
        }
    }
}
