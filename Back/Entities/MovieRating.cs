namespace Movies;

public class MovieRating
{
    public Guid Id { get; set; }
    public int Rate { get; set; }
    public Movie? Movie { get; set; }
    public Guid? MovieId { get; set; }
}
