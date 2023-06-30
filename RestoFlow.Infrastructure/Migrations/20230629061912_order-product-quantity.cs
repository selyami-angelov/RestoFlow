using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class orderproductquantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "Orders");

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
    }
}
