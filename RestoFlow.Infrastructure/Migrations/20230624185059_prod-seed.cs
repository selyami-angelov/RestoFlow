using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestoFlow.Infrastructure.Migrations
{
    public partial class prodseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Img", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Fresh salmon fillet grilled to perfection and served with a side of steamed vegetables.", "grilled_salmon.jpg", "Grilled Salmon" },
                    { 2, 1, "Tender breaded chicken breast topped with marinara sauce and melted mozzarella cheese, served with pasta.", "chicken_parmesan.jpg", "Chicken Parmesan" },
                    { 3, 1, "Juicy beef patty topped with cheese, lettuce, tomato, and pickles, served on a toasted bun.", "beef_burger.jpg", "Beef Burger" },
                    { 4, 1, "Assorted fresh vegetables stir-fried to perfection in a flavorful sauce, served over steamed rice.", "vegetable_stir_fry.jpg", "Vegetable Stir-Fry" },
                    { 5, 1, "Homemade ravioli stuffed with succulent lobster meat, served with a creamy tomato sauce.", "lobster_ravioli.jpg", "Lobster Ravioli" },
                    { 6, 1, "Tender pork tenderloin marinated in a savory blend of herbs and spices, grilled to perfection.", "pork_tenderloin.jpg", "Pork Tenderloin" },
                    { 7, 1, "Slices of breaded and fried eggplant layered with marinara sauce and melted mozzarella cheese.", "eggplant_parmesan.jpg", "Eggplant Parmesan" },
                    { 8, 1, "Plump shrimp sautéed in garlic butter and white wine, served over a bed of linguine pasta.", "shrimp_scampi.jpg", "Shrimp Scampi" },
                    { 9, 1, "Creamy risotto cooked with fresh mushrooms, Parmesan cheese, and a hint of truffle oil.", "mushroom_risotto.jpg", "Mushroom Risotto" },
                    { 10, 1, "Grilled steak served with a side of crispy French fries and a tangy dipping sauce.", "steak_frites.jpg", "Steak Frites" },
                    { 11, 2, "Classic New York-style cheesecake with a buttery graham cracker crust and creamy filling.", "cheesecake.jpg", "Cheesecake" },
                    { 12, 2, "Layers of espresso-soaked ladyfingers and creamy mascarpone cheese, dusted with cocoa powder.", "tiramisu.jpg", "Tiramisu" },
                    { 13, 2, "Homemade apple pie with a flaky crust and a sweet and tangy apple filling.", "apple_pie.jpg", "Apple Pie" },
                    { 14, 2, "Velvety smooth chocolate mousse topped with a dollop of whipped cream and chocolate shavings.", "chocolate_mousse.jpg", "Chocolate Mousse" },
                    { 15, 2, "Light and fluffy shortcake layered with fresh strawberries and whipped cream.", "strawberry_shortcake.jpg", "Strawberry Shortcake" },
                    { 16, 2, "Tangy lemon filling in a buttery tart shell, topped with a dusting of powdered sugar.", "lemon_tart.jpg", "Lemon Tart" },
                    { 17, 2, "Smooth and creamy Italian dessert made with sweetened cream and gelatin.", "panna_cotta.jpg", "Panna Cotta" },
                    { 18, 2, "Moist and velvety red velvet cake with layers of cream cheese frosting.", "red_velvet_cake.jpg", "Red Velvet Cake" },
                    { 19, 2, "Refreshing pie made with tangy key lime juice and a sweet graham cracker crust.", "key_lime_pie.jpg", "Key Lime Pie" },
                    { 20, 2, "Classic homemade chocolate chip cookies with gooey chocolate chips and a soft, chewy texture.", "chocolate_chip_cookies.jpg", "Chocolate Chip Cookies" },
                    { 21, 3, "Chilled coffee served over ice with a splash of milk and a hint of sweetness.", "iced_coffee.jpg", "Iced Coffee" },
                    { 22, 3, "Refreshing smoothie made with ripe mangoes, yogurt, and a touch of honey.", "mango_smoothie.jpg", "Mango Smoothie" },
                    { 23, 3, "Steeped green tea leaves with a delicate and soothing flavor.", "green_tea.jpg", "Green Tea" },
                    { 24, 3, "Freshly squeezed orange juice packed with vitamin C and a burst of citrus flavor.", "orange_juice.jpg", "Orange Juice" },
                    { 25, 3, "Homemade lemonade made with freshly squeezed lemons and a touch of sweetness.", "lemonade.jpg", "Lemonade" },
                    { 26, 3, "Classic Cuban cocktail made with rum, fresh mint leaves, lime juice, and a hint of sweetness.", "mojito.jpg", "Mojito" },
                    { 27, 3, "Rich and creamy hot chocolate topped with whipped cream and chocolate shavings.", "hot_chocolate.jpg", "Hot Chocolate" },
                    { 28, 3, "Bubbly and refreshing carbonated water with a clean and crisp taste.", "sparkling_water.jpg", "Sparkling Water" },
                    { 29, 3, "Chilled black tea served over ice, optionally sweetened and garnished with a slice of lemon.", "iced_tea.jpg", "Iced Tea" },
                    { 30, 3, "A tropical blend of assorted fruit juices with a sweet and tangy flavor.", "fruit_punch.jpg", "Fruit Punch" },
                    { 31, 4, "Classic Caesar salad with crisp romaine lettuce, Parmesan cheese, croutons, and tangy Caesar dressing.", "caesar_salad.jpg", "Caesar Salad" },
                    { 32, 4, "Fresh mozzarella cheese, ripe tomatoes, and basil leaves drizzled with balsamic glaze and olive oil.", "caprese_salad.jpg", "Caprese Salad" },
                    { 33, 4, "Classic Greek salad with fresh lettuce, tomatoes, cucumbers, olives, feta cheese, and a tangy dressing.", "greek_salad.jpg", "Greek Salad" },
                    { 34, 4, "Assorted greens topped with grilled chicken, avocado, bacon, hard-boiled eggs, and blue cheese crumbles.", "cobb_salad.jpg", "Cobb Salad" },
                    { 35, 4, "Fresh spinach leaves topped with sliced strawberries, goat cheese, and a light vinaigrette dressing.", "spinach_salad.jpg", "Spinach Salad" },
                    { 36, 4, "A French salad made with tuna, boiled eggs, green beans, potatoes, olives, and a Dijon vinaigrette.", "nicoise_salad.jpg", "Nicoise Salad" },
                    { 37, 4, "A refreshing salad made with crisp apples, celery, grapes, walnuts, and a creamy dressing.", "waldorf_salad.jpg", "Waldorf Salad" },
                    { 38, 4, "A vibrant salad with mixed greens, grilled corn, black beans, tomatoes, avocado, and a zesty dressing.", "mexican_salad.jpg", "Mexican Salad" },
                    { 39, 4, "A protein-packed salad made with flaky tuna, crunchy vegetables, and a tangy mayonnaise dressing.", "tuna_salad.jpg", "Tuna Salad" },
                    { 40, 4, "A nutritious salad made with quinoa, fresh vegetables, herbs, and a zesty lemon dressing.", "quinoa_salad.jpg", "Quinoa Salad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
