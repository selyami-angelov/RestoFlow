using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class seedreservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "IsCancelled", "PartySize", "ReservationDate", "UserId" },
                values: new object[,]
                {
                    { 1, false, 4, new DateTime(2023, 6, 28, 13, 41, 59, 516, DateTimeKind.Local).AddTicks(9973), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 2, false, 6, new DateTime(2023, 6, 29, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(24), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 3, false, 2, new DateTime(2023, 6, 30, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(28), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 4, false, 5, new DateTime(2023, 7, 1, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(31), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 5, false, 3, new DateTime(2023, 7, 2, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(35), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 6, false, 8, new DateTime(2023, 7, 3, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(39), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 7, false, 2, new DateTime(2023, 7, 4, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(42), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 8, false, 4, new DateTime(2023, 7, 5, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(46), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 9, false, 6, new DateTime(2023, 7, 6, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(50), "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 10, false, 3, new DateTime(2023, 7, 7, 13, 41, 59, 517, DateTimeKind.Local).AddTicks(53), "b08ba7ee-0960-4656-baf4-980b1d6b88df" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 10, 10, 35, 601, DateTimeKind.Utc).AddTicks(1168));
        }
    }
}
