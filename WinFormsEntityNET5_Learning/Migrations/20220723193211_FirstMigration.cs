using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WinFormsEntityNET5_Learning.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Series",
                type: "interval",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 6, 0, 0));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudyDate",
                value: new DateTime(2022, 7, 23, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudyDate",
                value: new DateTime(2022, 5, 28, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StudyDate",
                value: new DateTime(2022, 7, 20, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StudyDate",
                value: new DateTime(2022, 7, 23, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 5,
                column: "StudyDate",
                value: new DateTime(2022, 7, 11, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 6,
                column: "StudyDate",
                value: new DateTime(2022, 6, 26, 22, 32, 11, 582, DateTimeKind.Local).AddTicks(9033));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Series");

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudyDate",
                value: new DateTime(2022, 7, 23, 22, 28, 21, 167, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudyDate",
                value: new DateTime(2022, 5, 28, 22, 28, 21, 168, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 3,
                column: "StudyDate",
                value: new DateTime(2022, 7, 20, 22, 28, 21, 168, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 4,
                column: "StudyDate",
                value: new DateTime(2022, 7, 23, 22, 28, 21, 168, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 5,
                column: "StudyDate",
                value: new DateTime(2022, 7, 11, 22, 28, 21, 168, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Studies",
                keyColumn: "Id",
                keyValue: 6,
                column: "StudyDate",
                value: new DateTime(2022, 6, 26, 22, 28, 21, 168, DateTimeKind.Local).AddTicks(2228));
        }
    }
}
