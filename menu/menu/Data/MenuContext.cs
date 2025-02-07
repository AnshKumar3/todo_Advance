using Microsoft.EntityFrameworkCore;
using menu.Models;
namespace menu.Data
{
    public class MenuContext : DbContext
    {

        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredients>()
                .HasKey(di => new
                {
                    di.DishId,
                    di.IngredientsId
                });
            modelBuilder.Entity<DishIngredients>()
                .HasOne(di => di.Dish)
                .WithMany(d => (IEnumerable<DishIngredients>)d.DishIngredient)
                .HasForeignKey(di => di.DishId);

            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Name = "Pasta Carbonara",
                    Description = "Spaghetti with bacon, eggs, and Parmesan cheese",
                    Price = 15.95M,
                    Category = "Main Course",
                    Image = "https://www.themealdb.com/images/media/meals/ysxwuq1487323065.jpg",
                    ImageThumbnail = "https://www.themealdb.com/images/media/meals/"
                });

            modelBuilder.Entity<Ingredients>().HasData(
                new Ingredients
                {
                    Id = "1", // Change from string to int
                    Name = "Spaghetti",
                },
                new Ingredients
                {
                    Id = "2", // Change from string to int
                    Name = "Bacon",
                },
                new Ingredients
                {
                    Id = "3", // Change from string to int
                    Name = "Eggs",
                },
                new Ingredients
                {
                    Id = "4", // Change from string to int
                    Name = "Parmesan Cheese",
                });
            modelBuilder.Entity<DishIngredients>().HasData(
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 1, // Change from string to int
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 2, // Change from string to int
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 3, // Change from string to int
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 4, // Change from string to int
                });
            modelBuilder.Entity<DishIngredients>().HasData(
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 1,
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 2,
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 3,
                },
                new DishIngredients
                {
                    DishId = 1,
                    IngredientsId = 4,
                });


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<DishIngredients> DishIngredients { get; set; }

    }
}
