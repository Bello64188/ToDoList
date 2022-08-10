using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoAPI.Migrations
{
    public partial class initialSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[] { 1, new DateTime(2022, 8, 10, 14, 1, 13, 986, DateTimeKind.Local).AddTicks(6933), "Bello", "male", "Azeez" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[] { 2, new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2352), "Bolaji", "male", "Kola" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[] { 3, new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2485), "Maryam", "female", "Atinuke" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "LastName" },
                values: new object[] { 4, new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2502), "John", "male", "Deji" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
