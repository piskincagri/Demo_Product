using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addjob2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "JopID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "JopName",
                table: "Jobs",
                newName: "JobName");

            migrationBuilder.AlterColumn<int>(
                name: "JobID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "JobName",
                table: "Jobs",
                newName: "JopName");

            migrationBuilder.AlterColumn<int>(
                name: "JobID",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "JopID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
