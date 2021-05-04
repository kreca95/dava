using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedtagstolecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Lectures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3ec6d283-1748-4e7e-bd3b-9be1939cadde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "e0e022a5-77fc-4796-ad33-085977f1f375");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f39801-2011-4dcd-b466-9ed0d5cf5aa7", "AQAAAAEAACcQAAAAELzkbt8s969M9aDcGMyM+j5V2KM+Nw2zexVdNueAd0P+IwX6i2gztM38bOypYiiC9Q==", "aabc2b9b-9e40-4140-8dd4-89d6acbb7ad6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78a3b688-9d7e-43ba-b45b-4e4e06b5b984", "AQAAAAEAACcQAAAAEF8iXpDkK8KJ3j++3oB2FVPG5cjt/aURcZGMXnY2s8VeDEkBPZPDDg0/vJ1N3EEuig==", "0130caa7-2bbb-4f0b-aa75-8e942b681077" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Lectures");

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
    }
}
