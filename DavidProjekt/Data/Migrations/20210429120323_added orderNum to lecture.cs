using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedorderNumtolecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNum",
                table: "Lectures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8975ab13-a8f9-4f1f-a77f-ed154ccc45bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "441ce0f5-649a-4790-b6e2-19f8eeeb5b00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01632def-6f50-418d-9af0-3e56fa2bc661", "AQAAAAEAACcQAAAAENwTvDDcpr/WerftgcJ8NL/3pqE1FUjWen2ezUBOnVK7H5nnTLpXRCtOFHxGLCxF5Q==", "c4c1cbf1-af53-4c78-ba81-ea177b1aeb79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b015560-b582-4c90-91c2-ea523aaf65a1", "AQAAAAEAACcQAAAAEG/RqHNv5rIgQtqbmjD5pSKvVWCsezAE+kQGx8lTw1W5rMiuERx3+gmn2Y/t7AOfFQ==", "b0b50a90-731d-4ab1-b235-7094ae0745f3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNum",
                table: "Lectures");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "52444afb-8ac4-4321-9fe3-8b7a29f2e739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "7fdb327f-d3ed-4d03-8db9-783b2a728545");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc8fbe2-d210-4f7e-93db-2d8dd46dcf64", "AQAAAAEAACcQAAAAEGp9ip4jtBa3VGMQ8zNh6DWDIvcOW515gCnCpPdaTGadma+b5LlHHU5imEnnQ6Dr3A==", "3718fece-e48f-4d38-b3b5-37db6138c2af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b315a657-9cb0-4570-8dd9-9c3e1891cc08", "AQAAAAEAACcQAAAAEPyk8mqbIVpQNfjTGKsDoxbBOpMfWOok0LRLu+fiD49i6xYcnsyoyP5nYBqDFc0t5w==", "e95c500c-9dd0-4a75-9ab4-716c3b67c044" });
        }
    }
}
