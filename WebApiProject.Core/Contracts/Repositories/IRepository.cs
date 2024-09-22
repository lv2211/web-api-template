namespace WebApiProject.Core.Contracts.Repositories;

public interface IRepository<T> where T : class, new()
{
    /// <summary>
    /// Retrieves a queryable collection of entities of type T.
    /// </summary>
    /// <return>
    /// A queryable collection of entities.
    /// </return>
    IQueryable<T> Get();

    /// <summary>
    /// Retrieves an entity of type T by its unique identifier.
    /// </summary>
    /// <param name="keyValues">The values that uniquely identify the entity.</param>
    /// <return>
    /// A task that represents the asynchronous operation. The task result contains the entity if found, otherwise null.
    /// </return>
    Task<T?> FindAsync(params object?[]? keyValues);

    /// <summary>
    /// Adds an entity of type T to the repository.
    /// </summary>
    /// <param name="entity">The entity to add to the repository.</param>
    void Add(T entity);

    /// <summary>
    /// Adds a range of entities of type T to the repository.
    /// </summary>
    /// <param name="entities">The collection of entities to add to the repository.</param>
    void AddRange(IEnumerable<T> entities);

    /// <summary>
    /// Asynchronously adds an entity of type T to the repository.
    /// </summary>
    /// <param name="entity">The entity to add to the repository.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <return>
    /// A task that represents the asynchronous operation.
    /// </return>
    Task AddAsync(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Asynchronously adds a range of entities of type T to the repository.
    /// </summary>
    /// <param name="entities">The collection of entities to add to the repository.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <return>
    /// A task that represents the asynchronous operation.
    /// </return>
    Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an entity of type T in the repository.
    /// </summary>
    /// <param name="entity">The entity to update in the repository.</param>
    void Update(T entity);

    /// <summary>
    /// Updates a range of entities of type T in the repository.
    /// </summary>
    /// <param name="entities">The collection of entities to update in the repository.</param>
    void UpdateRange(IEnumerable<T> entities);

    /// <summary>
    /// Removes an entity of type T from the repository.
    /// </summary>
    /// <param name="entity">The entity to remove from the repository.</param>
    void Remove(T entity);

    /// <summary>
    /// Removes a range of entities of type T from the repository.
    /// </summary>
    /// <param name="entities">The collection of entities to remove from the repository.</param>
    void RemoveRange(IEnumerable<T> entities);
}