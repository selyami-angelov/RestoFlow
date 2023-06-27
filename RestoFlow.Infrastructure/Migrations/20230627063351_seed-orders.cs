using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class seedorders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedById", "CreatedDate", "EditedById", "EditedDate", "Info", "IsServed", "ProductId", "isDeleted" },
                values: new object[,]
                {
                    { 1, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7477), null, null, "Order 1 information", false, 1, false },
                    { 2, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7478), null, null, "Order 2 information", false, 2, false },
                    { 3, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7479), null, null, "Order 3 information", false, 3, false },
                    { 4, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7480), null, null, "Order 4 information", false, 4, false },
                    { 5, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7481), null, null, "Order 5 information", false, 5, false },
                    { 6, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7482), null, null, "Order 6 information", false, 6, false },
                    { 7, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7483), null, null, "Order 7 information", false, 7, false },
                    { 8, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7484), null, null, "Order 8 information", false, 8, false },
                    { 9, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7484), null, null, "Order 9 information", false, 9, false },
                    { 10, "b08ba7ee-0960-4656-baf4-980b1d6b88df", new DateTime(2023, 6, 27, 6, 33, 51, 465, DateTimeKind.Utc).AddTicks(7485), null, null, "Order 10 information", false, 10, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
