namespace Movies;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}