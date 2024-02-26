using Microsoft.EntityFrameworkCore;

namespace Movies;

public class MovieService : IMovieService
{
    private readonly MoviesDbContext _moviesDbContext;

    public MovieService(MoviesDbContext moviesDbContext)
    {
        _moviesDbContext = moviesDbContext;
    }

    public async Task<IEnumerable<MovieDto>> GetMoviesAsync()
    {
        var result = await _moviesDbContext.Movies.Select(x => new MovieDto
        {
            Id = x.Id,
            Name = x.Name,
            ProductionYear = x.ProductionYear,
            Country = x.Country
        }).ToListAsync();

        return result;
    }
}
