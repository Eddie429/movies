namespace Movies;

public interface IMovieService
{
    Task<IEnumerable<MovieDto>> GetMoviesAsync();
}
