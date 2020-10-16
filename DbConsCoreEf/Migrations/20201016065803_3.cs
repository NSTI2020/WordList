using Microsoft.EntityFrameworkCore.Migrations;

namespace DbConsCoreEf.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "A",
                table: "A001s",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "A",
                table: "A001s",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
