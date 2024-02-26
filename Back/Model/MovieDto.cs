namespace Movies;

public class MovieDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int ProductionYear { get; set; }
    public string? Country { get; set; }
}