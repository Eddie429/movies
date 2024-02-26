namespace Movies;

public class UnitOfWork : IUnitOfWork
{
    MoviesDbContext _dbContext;

    public UnitOfWork(MoviesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}