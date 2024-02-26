namespace Movies;

public static class DbInitializer
{
    public static void Initialize(MoviesDbContext context)
    {

        if (context.Actors.Any()
            && context.Movies.Any())
        {
            return; // DB has been seeded
        }

        var movie1 = new Movie
        {
            Name = "Titanic",
            ProductionYear = 1997,
            Country = "United States"
        };

        var moviesList = new Movie[] {
            new Movie { Name = "The Shawshank Redemption", ProductionYear = 1994, Country = "United States" },
            new Movie { Name = "The Godfather", ProductionYear = 1972, Country = "United States" },
            new Movie { Name = "The Dark Knight", ProductionYear = 2008, Country = "United States" },
            new Movie { Name = "Schindler's List", ProductionYear = 1993, Country = "United States" },
            new Movie { Name = "Pulp Fiction", ProductionYear = 1994, Country = "United States" },
            new Movie { Name = "The Lord of the Rings: The Return of the King", ProductionYear = 2003, Country = "United States" },
            new Movie { Name = "Forrest Gump", ProductionYear = 1994, Country = "United States" },
            new Movie { Name = "Inception", ProductionYear = 2010, Country = "United States" },
            new Movie { Name = "The Matrix", ProductionYear = 1999, Country = "United States" },
            new Movie { Name = "Interstellar", ProductionYear = 2014, Country = "United States" },
            new Movie { Name = "The Silence of the Lambs", ProductionYear = 1991, Country = "United States" },
            new Movie { Name = "The Lion King", ProductionYear = 1994, Country = "United States" },
            new Movie { Name = "Fight Club", ProductionYear = 1999, Country = "United States" },
            new Movie { Name = "The Green Mile", ProductionYear = 1999, Country = "United States" },
            new Movie { Name = "The Usual Suspects", ProductionYear = 1995, Country = "United States" },
            new Movie { Name = "Avengers: Endgame", ProductionYear = 2019, Country = "United States" },
            new Movie { Name = "The Departed", ProductionYear = 2006, Country = "United States" },
            new Movie { Name = "Goodfellas", ProductionYear = 1990, Country = "United States" },
            new Movie { Name = "Gladiator", ProductionYear = 2000, Country = "United States" },
            new Movie { Name = "Avatar", ProductionYear = 2009, Country = "United States" }
        };

        var actor1 = new Actor
        {
            Name = "Leonardo DiCaprio",
            Movie = movie1
        };

        var actor2 = new Actor
        {
            Name = "Kate Winslet",
            Movie = movie1
        };

        var movieRating1 = new MovieRating
        {
            Rate = 1,
            Movie = movie1
        };

        var movieRating2 = new MovieRating
        {
            Rate = 2,
            Movie = movie1
        };

        var movieRating3 = new MovieRating
        {
            Rate = 3,
            Movie = movie1
        };

        var movieRating4 = new MovieRating
        {
            Rate = 4,
            Movie = movie1
        };

        var movieRating5 = new MovieRating
        {
            Rate = 5,
            Movie = movie1
        };

        context.Movies.Add(movie1);
        context.Actors.Add(actor1);
        context.Actors.Add(actor2);
        context.MovieRatings.Add(movieRating1);
        context.MovieRatings.Add(movieRating2);
        context.MovieRatings.Add(movieRating3);
        context.MovieRatings.Add(movieRating4);
        context.MovieRatings.Add(movieRating5);

        context.Movies.AddRange(moviesList);
        context.SaveChanges();
    }
}