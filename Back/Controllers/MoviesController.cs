using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly ILogger<MoviesController> _logger;
    private readonly IMovieService _movieService;
    private readonly IUnitOfWork _unitOfWork;

    public MoviesController(ILogger<MoviesController> logger, IMovieService movieService, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _movieService = movieService;
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IEnumerable<MovieDto>> GetAsync()
    {
        return await _movieService.GetMoviesAsync();
    }
}
