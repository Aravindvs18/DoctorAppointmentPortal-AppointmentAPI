using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentAPI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AppointmentDetails",
                newName: "PatientGender");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AppointmentDetails",
                newName: "AppointmentId");

            migrationBuilder.AlterColumn<string>(
                name: "SelectDate",
                table: "AppointmentDetails",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PatientGender",
                table: "AppointmentDetails",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "AppointmentDetails",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "SelectDate",
                table: "AppointmentDetails",
                type: "nvarchar(8)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);
        }
    }
}
