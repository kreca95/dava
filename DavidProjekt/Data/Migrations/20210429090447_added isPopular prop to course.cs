using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedisPopularproptocourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "483fcdff-0946-4b87-908d-959315d87474");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "623e4747-0209-4e04-a763-1355be9cd31a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dbf4aa9-07da-43ce-8927-656b61acb6b3", "AQAAAAEAACcQAAAAEI8eu5fpHnJNFX6gk27yKmIfiiiRanzPLx9EH7efPhX0TM/DigNWsDFUA0o+bQeGFA==", "e7896881-fa8b-478d-863d-5692270c7169" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83c3aed7-3a81-4c30-8bac-a7d32736cd0d", "AQAAAAEAACcQAAAAEIQVdJyMurZba8HG60nmxCfd5d6kgnAaiaeo7gADE05H5GXa8OSbeLvOA1SDlPZJqg==", "2cd22066-918f-476c-bc1e-e2f1636bf9d7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e60aecf9-ec98-4610-86fc-0808f066af09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "4e25c3ea-d1ec-49c3-8a1d-2e14639b4ab4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3413639f-8e97-4bc9-ad58-00c971e7d9be", "AQAAAAEAACcQAAAAEDskzul8qJZBwwnyUHy8x9GtIDOmqc9zQZxlrIXbZPcGQ7vzOL4I5sburqJzgWPBZg==", "4915598a-b81d-4ba2-ad9b-dd0a45da0782" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b809155-fefd-49ef-b41d-716bbaaf39dc", "AQAAAAEAACcQAAAAELyKDpumliqZe+EpQnWz7jc9sVLjsBhYsEiMdHYuEuqHjKJGkSdJJzf3zCmkBrxGzA==", "787de406-505a-402a-b042-346d507bf1b2" });
        }
    }
}
