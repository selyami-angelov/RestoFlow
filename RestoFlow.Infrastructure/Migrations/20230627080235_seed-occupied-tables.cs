using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class seedoccupiedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OccupiedTables",
                columns: new[] { "OrderId", "TableId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 2, 2, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 3, 3, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 4, 4, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 5, 5, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 6, 6, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 7, 7, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 8, 8, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 9, 9, "b08ba7ee-0960-4656-baf4-980b1d6b88df" },
                    { 10, 10, "b08ba7ee-0960-4656-baf4-980b1d6b88df" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 8, 2, 35, 257, DateTimeKind.Utc).AddTicks(6474));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 1, 1, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 2, 2, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 3, 3, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 4, 4, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 5, 5, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 6, 6, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 7, 7, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 8, 8, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 9, 9, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 10, 10, "b08ba7ee-0960-4656-baf4-980b1d6b88df" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 27, 7, 58, 5, 650, DateTimeKind.Utc).AddTicks(8184));
        }
    }
}
