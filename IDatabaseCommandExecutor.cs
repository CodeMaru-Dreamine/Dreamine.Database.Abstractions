namespace Dreamine.Database.Abstractions;

/// <summary>
/// Exposes raw SQL command execution operations.
/// </summary>
public interface IDatabaseCommandExecutor
{
    /// <summary>
    /// Executes a raw SQL command.
    /// </summary>
    /// <param name="sql">The SQL command text.</param>
    /// <param name="parameters">The optional command parameters.</param>
    /// <returns>The affected row count.</returns>
    int ExecuteNonQuery(string sql, object? parameters = null);

    /// <summary>
    /// Executes a raw SQL command.
    /// </summary>
    /// <param name="sql">The SQL command text.</param>
    /// <param name="parameters">The optional command parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The affected row count.</returns>
    Task<int> ExecuteNonQueryAsync(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes a raw SQL scalar command.
    /// </summary>
    /// <typeparam name="T">The scalar value type.</typeparam>
    /// <param name="sql">The SQL command text.</param>
    /// <param name="parameters">The optional command parameters.</param>
    /// <returns>The scalar value.</returns>
    T? ExecuteScalar<T>(string sql, object? parameters = null);

    /// <summary>
    /// Executes a raw SQL scalar command.
    /// </summary>
    /// <typeparam name="T">The scalar value type.</typeparam>
    /// <param name="sql">The SQL command text.</param>
    /// <param name="parameters">The optional command parameters.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The scalar value.</returns>
    Task<T?> ExecuteScalarAsync<T>(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);
}
