using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class productprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 7, 1, 7, 40, 49, 933, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 2, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 3, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 4, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 5, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 6, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 7, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 8, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 9, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 10, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 11, 10, 40, 49, 933, DateTimeKind.Local).AddTicks(8407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 30, 16, 37, 13, 516, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 1, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 2, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 3, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 4, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 5, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 6, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 7, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 8, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 9, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 10, 19, 37, 13, 516, DateTimeKind.Local).AddTicks(7851));
        }
    }
}
