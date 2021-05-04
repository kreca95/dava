using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedcourselecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e4af5f26-59fd-40f4-a616-1be23bd527d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "38d5dd85-7fa5-428f-b6fb-5585b41be058");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "963d6a50-2e65-40b7-b53f-7f4902b5b33a", "AQAAAAEAACcQAAAAEElGAEAgWYj3+CMj3l/8ccQLV6V+PZaws23Pe/yejXMtYBQhw9rITEF91upcQWxpgQ==", "e325de87-04d0-474b-a35d-7419fc1eba81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "992caba7-b90e-4ccd-9809-8ee910c4decd", "AQAAAAEAACcQAAAAEJ0Q/4X5dUc1gPHj5RTb++Vc33KME6n0jDNoYUY5e4Glr/Shy4NP/75+vY8PgBtyzw==", "d485e377-1cbc-436b-8c2c-f56227a5b06f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "87fbe2e3-9200-4346-96b8-9cc75b286302");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "95460241-34fb-416a-9f20-e93d8227b980");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a6ecddd-1f00-42e9-b288-a9f82b5ab7cf", "AQAAAAEAACcQAAAAELwiI+pn7RCoc0gfc8yV7+LGNMUdcSUs/dm1tn/HNqFLGA3UjO/ToKrej0/RrcXJ4A==", "be14cb5e-e2cf-4a51-abe3-8a9ce26725ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25357866-f6b0-4631-8ab6-a4b774cfa394", "AQAAAAEAACcQAAAAEJtEjOhAwniGKrG6x4V4Q7qzb7qrdE4jBiP12cw8BAMkdWpG3brdXSri8qV/ZJFtJw==", "cdaac489-1583-48c7-9e23-d26be1316a56" });
        }
    }
}
