namespace EF6MigrationSugar.DataAccess
{
    using Ef6MigrationSugar.Models;

    using System.Data.Entity;

    public class MovieContext : DbContext
    {
        public MovieContext()
            : base("MovieDb")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
