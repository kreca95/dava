using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class compositekeysubscription1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8bdf809b-b882-44bc-a3fe-0efc25868f36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "1e7ef4da-368a-4c14-b921-5229161fedeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "256dc4a2-eeb4-4b66-990a-d071d1b7da7a", "AQAAAAEAACcQAAAAEM3zCQSKvI6i8qvCkfXlDjO1wABll7qPlrb51br81pQEAe2YNyylQRt5lWhwg061Ig==", "304b5e0f-1f62-4ed6-885b-a23b1eed0d18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ae1f5a8-08d6-4d25-becf-dab4a2769c01", "AQAAAAEAACcQAAAAEPHuRW+RRmLELuJiMbFGjOpanfUksmglaWuLEYWhxpoPHqSxSkrXemvxgj2feRhTlQ==", "3b8146b6-43fa-428b-bd3b-f316bc574e6e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
