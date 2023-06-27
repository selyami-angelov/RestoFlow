using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class seedreservationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 44, 10, 386, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.InsertData(
                table: "ReservationTable",
                columns: new[] { "ReservationId", "TableId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 28, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 29, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 30, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 1, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 2, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 3, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 4, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 5, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 6, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 7, 13, 44, 10, 386, DateTimeKind.Local).AddTicks(6563));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ReservationTable",
                keyColumns: new[] { "ReservationId", "TableId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 41, 59, 516, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 28, 13, 41, 59, 516, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 29, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 30, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 1, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 2, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 3, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 4, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 5, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 6, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 7, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(53));
        }
    }
}
