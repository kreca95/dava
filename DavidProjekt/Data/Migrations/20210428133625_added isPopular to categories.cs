using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedisPopulartocategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2507d065-91c8-4538-9c48-ec8fee8b53c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "c6d4f1fc-4a72-485c-9561-1891118fd392");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39dcc604-2546-483b-b6cc-97583234db66", "AQAAAAEAACcQAAAAEMdtmSa/pF83bQvcaVG2oE23kSHlSV7r5RNpQRrB9pHyJmI7tm82wT+GGfgT3WNjlA==", "7930e518-0fe5-4a91-868f-b8977d45de6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48eb232-0dd8-4718-83a0-afd89d95f8dd", "AQAAAAEAACcQAAAAECCqTTRtmVGjoBB25xoh5O/NkTvOZ8EAc6bu+qBysYilUGR+vvcjyOvgwt8IDeRNOw==", "ef5a1e1f-001d-42a4-b56f-794df6217e25" });
        }
    }
}
