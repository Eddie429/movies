using Microsoft.EntityFrameworkCore;

namespace Movies;

public class MoviesDbContext: DbContext
{
     public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<MovieRating> MovieRatings => Set<MovieRating>();   
    public DbSet<Actor> Actors => Set<Actor>();
}