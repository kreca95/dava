using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class seeddata22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "87fbe2e3-9200-4346-96b8-9cc75b286302");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "95460241-34fb-416a-9f20-e93d8227b980", "user", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25357866-f6b0-4631-8ab6-a4b774cfa394", "AQAAAAEAACcQAAAAEJtEjOhAwniGKrG6x4V4Q7qzb7qrdE4jBiP12cw8BAMkdWpG3brdXSri8qV/ZJFtJw==", "cdaac489-1583-48c7-9e23-d26be1316a56" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb0", 0, "3a6ecddd-1f00-42e9-b288-a9f82b5ab7cf", "User", "user@user.ba", false, "user", "user", false, null, null, null, "AQAAAAEAACcQAAAAELwiI+pn7RCoc0gfc8yV7+LGNMUdcSUs/dm1tn/HNqFLGA3UjO/ToKrej0/RrcXJ4A==", null, false, "be14cb5e-e2cf-4a51-abe3-8a9ce26725ff", false, "user" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75046e58-0f78-4158-af9d-5ccef909ff30", "AQAAAAEAACcQAAAAEN3s3Uc2s3Actx6eYyoCqicshoNi8Biyml7I2gqjTPpGKQNeDdPyV5IxYnqYASwRUQ==", "359e80c4-29d6-4f4a-9e76-4353c231da3e" });
        }
    }
}
