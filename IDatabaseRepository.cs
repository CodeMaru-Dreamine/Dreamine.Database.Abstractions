namespace Dreamine.Database.Abstractions;

/// <summary>
/// Exposes mapped entity data manipulation operations.
/// </summary>
public interface IDatabaseRepository
{
    /// <summary>
    /// Inserts an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <returns>True when at least one row was inserted.</returns>
    bool Insert<T>(T entity);

    /// <summary>
    /// Inserts an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>True when at least one row was inserted.</returns>
    Task<bool> InsertAsync<T>(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <returns>True when at least one row was updated.</returns>
    bool Update<T>(T entity);

    /// <summary>
    /// Updates an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>True when at least one row was updated.</returns>
    Task<bool> UpdateAsync<T>(T entity, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <returns>True when at least one row was deleted.</returns>
    bool Delete<T>(T entity);

    /// <summary>
    /// Deletes an entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="entity">The entity instance.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>True when at least one row was deleted.</returns>
    Task<bool> DeleteAsync<T>(T entity, CancellationToken cancellationToken = default);
}
