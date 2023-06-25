using Microsoft.EntityFrameworkCore;

using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Infrastructure.Data
{
    public class DbSeeder
    {
        public static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Main Dishes" },
                new Category { Id = 2, Name = "Desserts" },
                new Category { Id = 3, Name = "Beverages" },
                new Category { Id = 4, Name = "Salads" }
            );


        }

        public static void SeedTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>().HasData(
                new Table { Id = 1, TableNumber = 1, Seats = 4 },
                new Table { Id = 2, TableNumber = 2, Seats = 6 },
                new Table { Id = 3, TableNumber = 3, Seats = 2 },
                new Table { Id = 4, TableNumber = 4, Seats = 8 },
                new Table { Id = 5, TableNumber = 5, Seats = 4 },
                new Table { Id = 6, TableNumber = 6, Seats = 6 },
                new Table { Id = 7, TableNumber = 7, Seats = 2 },
                new Table { Id = 8, TableNumber = 8, Seats = 4 },
                new Table { Id = 9, TableNumber = 9, Seats = 6 },
                new Table { Id = 10, TableNumber = 10, Seats = 2 },
                new Table { Id = 11, TableNumber = 11, Seats = 4 },
                new Table { Id = 12, TableNumber = 12, Seats = 6 },
                new Table { Id = 13, TableNumber = 13, Seats = 2 },
                new Table { Id = 14, TableNumber = 14, Seats = 4 },
                new Table { Id = 15, TableNumber = 15, Seats = 6 },
                new Table { Id = 16, TableNumber = 16, Seats = 2 },
                new Table { Id = 17, TableNumber = 17, Seats = 4 },
                new Table { Id = 18, TableNumber = 18, Seats = 6 },
                new Table { Id = 19, TableNumber = 19, Seats = 2 },
                new Table { Id = 20, TableNumber = 20, Seats = 4 },
                new Table { Id = 21, TableNumber = 21, Seats = 6 },
                new Table { Id = 22, TableNumber = 22, Seats = 2 },
                new Table { Id = 23, TableNumber = 23, Seats = 4 },
                new Table { Id = 24, TableNumber = 24, Seats = 6 },
                new Table { Id = 25, TableNumber = 25, Seats = 2 },
                new Table { Id = 26, TableNumber = 26, Seats = 4 },
                new Table { Id = 27, TableNumber = 27, Seats = 6 },
                new Table { Id = 28, TableNumber = 28, Seats = 2 },
                new Table { Id = 29, TableNumber = 29, Seats = 4 },
                new Table { Id = 30, TableNumber = 30, Seats = 6 }
            );
        }

        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            // Main Dishes
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Grilled Salmon",
                    Description = "Fresh salmon fillet grilled to perfection and served with a side of steamed vegetables.",
                    CategoryId = 1,
                    Img = "grilled_salmon.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Chicken Parmesan",
                    Description = "Tender breaded chicken breast topped with marinara sauce and melted mozzarella cheese, served with pasta.",
                    CategoryId = 1,
                    Img = "chicken_parmesan.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Beef Burger",
                    Description = "Juicy beef patty topped with cheese, lettuce, tomato, and pickles, served on a toasted bun.",
                    CategoryId = 1,
                    Img = "beef_burger.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Vegetable Stir-Fry",
                    Description = "Assorted fresh vegetables stir-fried to perfection in a flavorful sauce, served over steamed rice.",
                    CategoryId = 1,
                    Img = "vegetable_stir_fry.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Lobster Ravioli",
                    Description = "Homemade ravioli stuffed with succulent lobster meat, served with a creamy tomato sauce.",
                    CategoryId = 1,
                    Img = "lobster_ravioli.jpg"
                },
                new Product
                {
                    Id = 6,
                    Name = "Pork Tenderloin",
                    Description = "Tender pork tenderloin marinated in a savory blend of herbs and spices, grilled to perfection.",
                    CategoryId = 1,
                    Img = "pork_tenderloin.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Eggplant Parmesan",
                    Description = "Slices of breaded and fried eggplant layered with marinara sauce and melted mozzarella cheese.",
                    CategoryId = 1,
                    Img = "eggplant_parmesan.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "Shrimp Scampi",
                    Description = "Plump shrimp sautéed in garlic butter and white wine, served over a bed of linguine pasta.",
                    CategoryId = 1,
                    Img = "shrimp_scampi.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Mushroom Risotto",
                    Description = "Creamy risotto cooked with fresh mushrooms, Parmesan cheese, and a hint of truffle oil.",
                    CategoryId = 1,
                    Img = "mushroom_risotto.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "Steak Frites",
                    Description = "Grilled steak served with a side of crispy French fries and a tangy dipping sauce.",
                    CategoryId = 1,
                    Img = "steak_frites.jpg"
                }
            );

            // Desserts
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 11,
                    Name = "Cheesecake",
                    Description = "Classic New York-style cheesecake with a buttery graham cracker crust and creamy filling.",
                    CategoryId = 2,
                    Img = "cheesecake.jpg"
                },
                new Product
                {
                    Id = 12,
                    Name = "Tiramisu",
                    Description = "Layers of espresso-soaked ladyfingers and creamy mascarpone cheese, dusted with cocoa powder.",
                    CategoryId = 2,
                    Img = "tiramisu.jpg"
                },
                new Product
                {
                    Id = 13,
                    Name = "Apple Pie",
                    Description = "Homemade apple pie with a flaky crust and a sweet and tangy apple filling.",
                    CategoryId = 2,
                    Img = "apple_pie.jpg"
                },
                new Product
                {
                    Id = 14,
                    Name = "Chocolate Mousse",
                    Description = "Velvety smooth chocolate mousse topped with a dollop of whipped cream and chocolate shavings.",
                    CategoryId = 2,
                    Img = "chocolate_mousse.jpg"
                },
                new Product
                {
                    Id = 15,
                    Name = "Strawberry Shortcake",
                    Description = "Light and fluffy shortcake layered with fresh strawberries and whipped cream.",
                    CategoryId = 2,
                    Img = "strawberry_shortcake.jpg"
                },
                new Product
                {
                    Id = 16,
                    Name = "Lemon Tart",
                    Description = "Tangy lemon filling in a buttery tart shell, topped with a dusting of powdered sugar.",
                    CategoryId = 2,
                    Img = "lemon_tart.jpg"
                },
                new Product
                {
                    Id = 17,
                    Name = "Panna Cotta",
                    Description = "Smooth and creamy Italian dessert made with sweetened cream and gelatin.",
                    CategoryId = 2,
                    Img = "panna_cotta.jpg"
                },
                new Product
                {
                    Id = 18,
                    Name = "Red Velvet Cake",
                    Description = "Moist and velvety red velvet cake with layers of cream cheese frosting.",
                    CategoryId = 2,
                    Img = "red_velvet_cake.jpg"
                },
                new Product
                {
                    Id = 19,
                    Name = "Key Lime Pie",
                    Description = "Refreshing pie made with tangy key lime juice and a sweet graham cracker crust.",
                    CategoryId = 2,
                    Img = "key_lime_pie.jpg"
                },
                new Product
                {
                    Id = 20,
                    Name = "Chocolate Chip Cookies",
                    Description = "Classic homemade chocolate chip cookies with gooey chocolate chips and a soft, chewy texture.",
                    CategoryId = 2,
                    Img = "chocolate_chip_cookies.jpg"
                }
            );

            // Beverages
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 21,
                    Name = "Iced Coffee",
                    Description = "Chilled coffee served over ice with a splash of milk and a hint of sweetness.",
                    CategoryId = 3,
                    Img = "iced_coffee.jpg"
                },
                new Product
                {
                    Id = 22,
                    Name = "Mango Smoothie",
                    Description = "Refreshing smoothie made with ripe mangoes, yogurt, and a touch of honey.",
                    CategoryId = 3,
                    Img = "mango_smoothie.jpg"
                },
                new Product
                {
                    Id = 23,
                    Name = "Green Tea",
                    Description = "Steeped green tea leaves with a delicate and soothing flavor.",
                    CategoryId = 3,
                    Img = "green_tea.jpg"
                },
                new Product
                {
                    Id = 24,
                    Name = "Orange Juice",
                    Description = "Freshly squeezed orange juice packed with vitamin C and a burst of citrus flavor.",
                    CategoryId = 3,
                    Img = "orange_juice.jpg"
                },
                new Product
                {
                    Id = 25,
                    Name = "Lemonade",
                    Description = "Homemade lemonade made with freshly squeezed lemons and a touch of sweetness.",
                    CategoryId = 3,
                    Img = "lemonade.jpg"
                },
                new Product
                {
                    Id = 26,
                    Name = "Mojito",
                    Description = "Classic Cuban cocktail made with rum, fresh mint leaves, lime juice, and a hint of sweetness.",
                    CategoryId = 3,
                    Img = "mojito.jpg"
                },
                new Product
                {
                    Id = 27,
                    Name = "Hot Chocolate",
                    Description = "Rich and creamy hot chocolate topped with whipped cream and chocolate shavings.",
                    CategoryId = 3,
                    Img = "hot_chocolate.jpg"
                },
                new Product
                {
                    Id = 28,
                    Name = "Sparkling Water",
                    Description = "Bubbly and refreshing carbonated water with a clean and crisp taste.",
                    CategoryId = 3,
                    Img = "sparkling_water.jpg"
                },
                new Product
                {
                    Id = 29,
                    Name = "Iced Tea",
                    Description = "Chilled black tea served over ice, optionally sweetened and garnished with a slice of lemon.",
                    CategoryId = 3,
                    Img = "iced_tea.jpg"
                },
                new Product
                {
                    Id = 30,
                    Name = "Fruit Punch",
                    Description = "A tropical blend of assorted fruit juices with a sweet and tangy flavor.",
                    CategoryId = 3,
                    Img = "fruit_punch.jpg"
                }
            );

            // Salads
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 31,
                    Name = "Caesar Salad",
                    Description = "Classic Caesar salad with crisp romaine lettuce, Parmesan cheese, croutons, and tangy Caesar dressing.",
                    CategoryId = 4,
                    Img = "caesar_salad.jpg"
                },
                new Product
                {
                    Id = 32,
                    Name = "Caprese Salad",
                    Description = "Fresh mozzarella cheese, ripe tomatoes, and basil leaves drizzled with balsamic glaze and olive oil.",
                    CategoryId = 4,
                    Img = "caprese_salad.jpg"
                },
                new Product
                {
                    Id = 33,
                    Name = "Greek Salad",
                    Description = "Classic Greek salad with fresh lettuce, tomatoes, cucumbers, olives, feta cheese, and a tangy dressing.",
                    CategoryId = 4,
                    Img = "greek_salad.jpg"
                },
                new Product
                {
                    Id = 34,
                    Name = "Cobb Salad",
                    Description = "Assorted greens topped with grilled chicken, avocado, bacon, hard-boiled eggs, and blue cheese crumbles.",
                    CategoryId = 4,
                    Img = "cobb_salad.jpg"
                },
                new Product
                {
                    Id = 35,
                    Name = "Spinach Salad",
                    Description = "Fresh spinach leaves topped with sliced strawberries, goat cheese, and a light vinaigrette dressing.",
                    CategoryId = 4,
                    Img = "spinach_salad.jpg"
                },
                new Product
                {
                    Id = 36,
                    Name = "Nicoise Salad",
                    Description = "A French salad made with tuna, boiled eggs, green beans, potatoes, olives, and a Dijon vinaigrette.",
                    CategoryId = 4,
                    Img = "nicoise_salad.jpg"
                },
                new Product
                {
                    Id = 37,
                    Name = "Waldorf Salad",
                    Description = "A refreshing salad made with crisp apples, celery, grapes, walnuts, and a creamy dressing.",
                    CategoryId = 4,
                    Img = "waldorf_salad.jpg"
                },
                new Product
                {
                    Id = 38,
                    Name = "Mexican Salad",
                    Description = "A vibrant salad with mixed greens, grilled corn, black beans, tomatoes, avocado, and a zesty dressing.",
                    CategoryId = 4,
                    Img = "mexican_salad.jpg"
                },
                new Product
                {
                    Id = 39,
                    Name = "Tuna Salad",
                    Description = "A protein-packed salad made with flaky tuna, crunchy vegetables, and a tangy mayonnaise dressing.",
                    CategoryId = 4,
                    Img = "tuna_salad.jpg"
                },
                new Product
                {
                    Id = 40,
                    Name = "Quinoa Salad",
                    Description = "A nutritious salad made with quinoa, fresh vegetables, herbs, and a zesty lemon dressing.",
                    CategoryId = 4,
                    Img = "quinoa_salad.jpg"
                }
            );
        }
    }
}
