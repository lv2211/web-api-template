using WebApiProject.Core.Contracts.Repositories;

namespace WebApiProject.Infrastructure;

public class Repository<T> : IRepository<T> where T: class, new()
{
    public IQueryable<T> Get()
    {
        throw new NotImplementedException();
    }

    public async Task<T?> FindAsync(params object?[]? keyValues)
    {
        throw new NotImplementedException();
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }
}