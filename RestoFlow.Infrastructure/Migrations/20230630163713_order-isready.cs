using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class orderisready : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReady",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReady",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 29, 6, 19, 11, 121, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 6, 30, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 1, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 2, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 3, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 4, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 5, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 6, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 8,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 7, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 9,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 8, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 10,
                column: "ReservationDate",
                value: new DateTime(2023, 7, 9, 9, 19, 11, 121, DateTimeKind.Local).AddTicks(6809));
        }
    }
}
