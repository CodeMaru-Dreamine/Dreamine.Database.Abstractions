namespace Dreamine.Database.Abstractions;

/// <summary>
/// Exposes database schema and table-management operations.
/// </summary>
public interface IDatabaseSchemaProvider
{
    /// <summary>
    /// Determines whether a table exists.
    /// </summary>
    /// <param name="tableName">The table name.</param>
    /// <returns>True when the table exists; otherwise false.</returns>
    bool IsTableExists(string tableName);

    /// <summary>
    /// Determines whether a table exists.
    /// </summary>
    /// <param name="tableName">The table name.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>True when the table exists; otherwise false.</returns>
    Task<bool> IsTableExistsAsync(string tableName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Determines whether the mapped table for an entity type exists.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <returns>True when the table exists; otherwise false.</returns>
    bool IsTableExists<T>();

    /// <summary>
    /// Determines whether the mapped table for an entity type exists.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>True when the table exists; otherwise false.</returns>
    Task<bool> IsTableExistsAsync<T>(CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates the mapped table for an entity type when it does not exist.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    void CreateTable<T>();

    /// <summary>
    /// Creates the mapped table for an entity type when it does not exist.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CreateTableAsync<T>(CancellationToken cancellationToken = default);
}
