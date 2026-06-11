namespace Dreamine.Database.Abstractions;

/// <summary>
/// Exposes raw SQL query operations.
/// </summary>
public interface IDatabaseQueryProvider
{
    /// <summary>
    /// Executes a raw SQL query.
    /// </summary>
    /// <typeparam name="T">The row type.</typeparam>
    /// <param name="sql">The SQL query text.</param>
    /// <param name="parameters">The optional query parameters.</param>
    /// <returns>The query rows.</returns>
    IEnumerable<T> Query<T>(string sql, object? parameters = null);

    /// <summary>
    /// Executes a raw SQL query.
    /// </summary>
    /// <typeparam name="T">The row type.</typeparam>
    /// <param name="sql">The SQL query text.</param>
    /// <param name="parameters">The optional query parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The query rows.</returns>
    Task<IReadOnlyList<T>> QueryAsync<T>(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);
}
