using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class seedproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Img", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Fresh salmon fillet grilled to perfection and served with a side of steamed vegetables.", "grilled_salmon.jpg", false, "Grilled Salmon", 10.2m },
                    { 2, 1, "Tender breaded chicken breast topped with marinara sauce and melted mozzarella cheese, served with pasta.", "chicken_parmesan.jpg", false, "Chicken Parmesan", 30.2m },
                    { 3, 1, "Juicy beef patty topped with cheese, lettuce, tomato, and pickles, served on a toasted bun.", "beef_burger.jpg", false, "Beef Burger", 10.4m },
                    { 4, 1, "Assorted fresh vegetables stir-fried to perfection in a flavorful sauce, served over steamed rice.", "vegetable_stir_fry.jpg", false, "Vegetable Stir-Fry", 123.2m },
                    { 5, 1, "Homemade ravioli stuffed with succulent lobster meat, served with a creamy tomato sauce.", "lobster_ravioli.jpg", false, "Lobster Ravioli", 123.54m },
                    { 6, 1, "Tender pork tenderloin marinated in a savory blend of herbs and spices, grilled to perfection.", "pork_tenderloin.jpg", false, "Pork Tenderloin", 10.42m },
                    { 7, 1, "Slices of breaded and fried eggplant layered with marinara sauce and melted mozzarella cheese.", "eggplant_parmesan.jpg", false, "Eggplant Parmesan", 13.21m },
                    { 8, 1, "Plump shrimp sautéed in garlic butter and white wine, served over a bed of linguine pasta.", "shrimp_scampi.jpg", false, "Shrimp Scampi", 112.43m },
                    { 9, 1, "Creamy risotto cooked with fresh mushrooms, Parmesan cheese, and a hint of truffle oil.", "mushroom_risotto.jpg", false, "Mushroom Risotto", 132.23m },
                    { 10, 1, "Grilled steak served with a side of crispy French fries and a tangy dipping sauce.", "steak_frites.jpg", false, "Steak Frites", 99.19m },
                    { 11, 2, "Classic New York-style cheesecake with a buttery graham cracker crust and creamy filling.", "cheesecake.jpg", false, "Cheesecake", 0m },
                    { 12, 2, "Layers of espresso-soaked ladyfingers and creamy mascarpone cheese, dusted with cocoa powder.", "tiramisu.jpg", false, "Tiramisu", 0m },
                    { 13, 2, "Homemade apple pie with a flaky crust and a sweet and tangy apple filling.", "apple_pie.jpg", false, "Apple Pie", 0m },
                    { 14, 2, "Velvety smooth chocolate mousse topped with a dollop of whipped cream and chocolate shavings.", "chocolate_mousse.jpg", false, "Chocolate Mousse", 0m },
                    { 15, 2, "Light and fluffy shortcake layered with fresh strawberries and whipped cream.", "strawberry_shortcake.jpg", false, "Strawberry Shortcake", 0m },
                    { 16, 2, "Tangy lemon filling in a buttery tart shell, topped with a dusting of powdered sugar.", "lemon_tart.jpg", false, "Lemon Tart", 0m },
                    { 17, 2, "Smooth and creamy Italian dessert made with sweetened cream and gelatin.", "panna_cotta.jpg", false, "Panna Cotta", 0m },
                    { 18, 2, "Moist and velvety red velvet cake with layers of cream cheese frosting.", "red_velvet_cake.jpg", false, "Red Velvet Cake", 0m },
                    { 19, 2, "Refreshing pie made with tangy key lime juice and a sweet graham cracker crust.", "key_lime_pie.jpg", false, "Key Lime Pie", 0m },
                    { 20, 2, "Classic homemade chocolate chip cookies with gooey chocolate chips and a soft, chewy texture.", "chocolate_chip_cookies.jpg", false, "Chocolate Chip Cookies", 0m },
                    { 21, 3, "Chilled coffee served over ice with a splash of milk and a hint of sweetness.", "iced_coffee.jpg", false, "Iced Coffee", 0m },
                    { 22, 3, "Refreshing smoothie made with ripe mangoes, yogurt, and a touch of honey.", "mango_smoothie.jpg", false, "Mango Smoothie", 0m },
                    { 23, 3, "Steeped green tea leaves with a delicate and soothing flavor.", "green_tea.jpg", false, "Green Tea", 0m },
                    { 24, 3, "Freshly squeezed orange juice packed with vitamin C and a burst of citrus flavor.", "orange_juice.jpg", false, "Orange Juice", 0m },
                    { 25, 3, "Homemade lemonade made with freshly squeezed lemons and a touch of sweetness.", "lemonade.jpg", false, "Lemonade", 0m },
                    { 26, 3, "Classic Cuban cocktail made with rum, fresh mint leaves, lime juice, and a hint of sweetness.", "mojito.jpg", false, "Mojito", 0m },
                    { 27, 3, "Rich and creamy hot chocolate topped with whipped cream and chocolate shavings.", "hot_chocolate.jpg", false, "Hot Chocolate", 0m },
                    { 28, 3, "Bubbly and refreshing carbonated water with a clean and crisp taste.", "sparkling_water.jpg", false, "Sparkling Water", 0m },
                    { 29, 3, "Chilled black tea served over ice, optionally sweetened and garnished with a slice of lemon.", "iced_tea.jpg", false, "Iced Tea", 0m },
                    { 30, 3, "A tropical blend of assorted fruit juices with a sweet and tangy flavor.", "fruit_punch.jpg", false, "Fruit Punch", 0m },
                    { 31, 4, "Classic Caesar salad with crisp romaine lettuce, Parmesan cheese, croutons, and tangy Caesar dressing.", "caesar_salad.jpg", false, "Caesar Salad", 0m },
                    { 32, 4, "Fresh mozzarella cheese, ripe tomatoes, and basil leaves drizzled with balsamic glaze and olive oil.", "caprese_salad.jpg", false, "Caprese Salad", 0m },
                    { 33, 4, "Classic Greek salad with fresh lettuce, tomatoes, cucumbers, olives, feta cheese, and a tangy dressing.", "greek_salad.jpg", false, "Greek Salad", 0m },
                    { 34, 4, "Assorted greens topped with grilled chicken, avocado, bacon, hard-boiled eggs, and blue cheese crumbles.", "cobb_salad.jpg", false, "Cobb Salad", 0m },
                    { 35, 4, "Fresh spinach leaves topped with sliced strawberries, goat cheese, and a light vinaigrette dressing.", "spinach_salad.jpg", false, "Spinach Salad", 0m },
                    { 36, 4, "A French salad made with tuna, boiled eggs, green beans, potatoes, olives, and a Dijon vinaigrette.", "nicoise_salad.jpg", false, "Nicoise Salad", 0m },
                    { 37, 4, "A refreshing salad made with crisp apples, celery, grapes, walnuts, and a creamy dressing.", "waldorf_salad.jpg", false, "Waldorf Salad", 0m },
                    { 38, 4, "A vibrant salad with mixed greens, grilled corn, black beans, tomatoes, avocado, and a zesty dressing.", "mexican_salad.jpg", false, "Mexican Salad", 0m },
                    { 39, 4, "A protein-packed salad made with flaky tuna, crunchy vegetables, and a tangy mayonnaise dressing.", "tuna_salad.jpg", false, "Tuna Salad", 0m },
                    { 40, 4, "A nutritious salad made with quinoa, fresh vegetables, herbs, and a zesty lemon dressing.", "quinoa_salad.jpg", false, "Quinoa Salad", 0m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillId", "CreatedById", "CreatedDate", "EditedById", "EditedDate", "Info", "IsReady", "IsServed", "ProductId", "ProductQuantity", "isDeleted" },
                values: new object[,]
                {
                    { 1, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8674), null, null, "Order 1 information", false, false, 1, 0, false },
                    { 2, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8676), null, null, "Order 2 information", false, false, 2, 0, false },
                    { 3, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8677), null, null, "Order 3 information", false, false, 3, 0, false },
                    { 4, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8677), null, null, "Order 4 information", false, false, 4, 0, false },
                    { 5, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8678), null, null, "Order 5 information", false, false, 5, 0, false },
                    { 6, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8679), null, null, "Order 6 information", false, false, 6, 0, false },
                    { 7, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8680), null, null, "Order 7 information", false, false, 7, 0, false },
                    { 8, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8681), null, null, "Order 8 information", false, false, 8, 0, false },
                    { 9, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8682), null, null, "Order 9 information", false, false, 9, 0, false },
                    { 10, null, "b56a186b-3b88-4f7c-be1f-cab791090685", new DateTime(2023, 7, 22, 16, 32, 8, 206, DateTimeKind.Utc).AddTicks(8683), null, null, "Order 10 information", false, false, 10, 0, false }
                });

            migrationBuilder.InsertData(
                table: "OccupiedTables",
                columns: new[] { "OrderId", "TableId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 2, 2, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 3, 3, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 4, 4, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 5, 5, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 6, 6, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 7, 7, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 8, 8, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 9, 9, "b56a186b-3b88-4f7c-be1f-cab791090685" },
                    { 10, 10, "b56a186b-3b88-4f7c-be1f-cab791090685" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 1, 1, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 2, 2, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 3, 3, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 4, 4, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 5, 5, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 6, 6, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 7, 7, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 8, 8, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 9, 9, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "OccupiedTables",
                keyColumns: new[] { "OrderId", "TableId", "UserId" },
                keyValues: new object[] { 10, 10, "b56a186b-3b88-4f7c-be1f-cab791090685" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
