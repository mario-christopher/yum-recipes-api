using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public class YumRecipeDB : DbContext
    {
        public YumRecipeDB(DbContextOptions<YumRecipeDB> context) : base(context)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Contributer> Contributers { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}