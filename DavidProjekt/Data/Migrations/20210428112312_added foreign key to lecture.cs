using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedforeignkeytolecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Courses_CourseId",
                table: "Lectures");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Lectures",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ab27e73b-4b77-4da6-bb15-ed38c4924d49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "9f4fdd6e-0e4a-4be6-995d-a25f1ff5700e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b548ab8-64eb-4fa1-8d70-20c64e26f9df", "AQAAAAEAACcQAAAAEH4WptkQnJmt/dMyYfx6duKUusqbPV97Hosns32+ruxAix0lzrYg7/SrDPyz8JyXhQ==", "1b3ff0c1-a247-48f1-9852-7fd23dcb2804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df8af248-3279-4ff8-8b0c-7bc7a3a654bf", "AQAAAAEAACcQAAAAEBAyvsNC5qHoe8YAs7knYN/3ayxGozDDbUMUtleJnA2TR+iz987MPBrnMmYTOlvjUQ==", "e347bcaa-2256-4c89-905a-0d3cf03f2f77" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Courses_CourseId",
                table: "Lectures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Courses_CourseId",
                table: "Lectures");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Lectures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "a5d5e8a0-b153-4d02-97dc-ecc1395d7505");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "7b33ceb9-4db8-46b2-98a3-137557ee6c21");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac5f1ec-e0f9-44ad-ad83-fa1112a98fc9", "AQAAAAEAACcQAAAAEEgQ7B2VkVQUavsVU8gItGq3ErMxzby7cok5HbAhiJwQ67nX5BvRmTM694JPp/J1Ag==", "6c397db3-ce23-4317-b011-4e56925f750e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f90194d0-0560-4012-8f48-03ce200a673b", "AQAAAAEAACcQAAAAEHw36AjvLGUPig1wUTBOWGujmeiuwOR0ijcRz6m5a1LwO95+Hzfu0oO2MpZaQDfLPw==", "cb8a0c4f-7bbe-4ec1-be40-1179053772a2" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Courses_CourseId",
                table: "Lectures",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
