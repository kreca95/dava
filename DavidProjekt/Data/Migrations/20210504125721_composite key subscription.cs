using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class compositekeysubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "82aaceff-5242-4851-a965-b8512d7733be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "869f4e07-c7ac-4f44-86cd-efa7895a296b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f23f44-642f-43c3-8b33-daa1d7bb1bbe", "AQAAAAEAACcQAAAAENuqB1t4vF7zZ+HiTrgKkBzz9C6TWAalIavYUpGlXP+FsT9AD1bxfhf+zC4Ot5If8A==", "54900d2f-3e83-483c-8541-6bab80edb6c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2d79d5-6975-4a8b-bb7a-0e7588a4bb6b", "AQAAAAEAACcQAAAAEPLJj7IDBzF93xxTzEh0mNNbIBH2QEEeU8ndnFgSpGJG9OlNJT6kU7ux3+lUc2CFPw==", "bfb3c83e-9fb4-4c97-bc8c-87bc20184a34" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "201a7187-a880-4703-bfb5-7a58de45595d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "d16e204c-2b46-4c09-a344-0ddb980aef11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb14cf9-da31-4c97-a4ce-b87edaf93a42", "AQAAAAEAACcQAAAAEPc64H+afgITQrSCY2hbgXfzFpoUv5QfUurhwlxdOjAerKT71bSIZasPAY8lcRmhqA==", "9421938b-3d5b-4bc7-8b5f-e17fc1e96c20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e7a5f54-2bd7-4fe3-9a75-3e9a055d7a11", "AQAAAAEAACcQAAAAEPXGb90cyMpN8zmNjaw+vT0Z5D+biMh7pNkJlZERo/PU+pxbU+CWHghZIYxNYJWAWA==", "af57cb08-c606-42bd-ba1d-b6d8743cb5cd" });
        }
    }
}
