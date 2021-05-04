using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c8c552bd-d37d-476c-bf8c-c340c19b29c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75046e58-0f78-4158-af9d-5ccef909ff30", "admin@admin.ba", "AQAAAAEAACcQAAAAEN3s3Uc2s3Actx6eYyoCqicshoNi8Biyml7I2gqjTPpGKQNeDdPyV5IxYnqYASwRUQ==", "359e80c4-29d6-4f4a-9e76-4353c231da3e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "10777748-7886-47e8-9e7a-508c875286c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e24c284-db58-4041-b2c2-b0e310c22ca0", "admin", "AQAAAAEAACcQAAAAELq69YRAar0ZnTWC2HYQcVhA7UOCQYt4x78MrQuWtQYPKtncto4b4Fv9GR+lE+mhhQ==", "8eb8de13-6286-4ef7-a902-30b62fd61330" });
        }
    }
}
