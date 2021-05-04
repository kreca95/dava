using Microsoft.EntityFrameworkCore.Migrations;

namespace DavidProjekt.Data.Migrations
{
    public partial class addedsubscriptiontable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c8fcc9fd-a7c1-4373-b362-5258fecef858");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "034183a9-858e-4edf-a7d7-2f7b5adea303");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "147809e3-96df-4b45-835f-894e4d2dc988", "AQAAAAEAACcQAAAAEKtWF18+thnTjBklEQXlyUkV0+PSghojlbwOE8an52IDgJTwSnMJXNJ2aM//m9ETuQ==", "fb1fa202-8370-4ce9-8259-8e624c90ca0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a31ccaa-f882-496b-948d-97e7019e1dbf", "AQAAAAEAACcQAAAAECXwXM8UY0RJHNG+SdaXyJeRGU6hLUl3pYdP7nqxf2af0HsBEYlaBUSnrJhGqtfQjw==", "02be0f5a-0ea6-4438-a510-e224a90e7043" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
