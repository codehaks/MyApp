using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Migrations
{
    public partial class UserAgeComputed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(Year,Birthdate,GETDATE())",
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(Year,Birthdate,GETDATE())");
        }
    }
}
