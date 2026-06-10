namespace Dreamine.Database.Abstractions;

/// <summary>
/// Defines the common database operations supported by Dreamine providers.
/// </summary>
public interface IDatabaseProvider
{
    DatabaseProviderKind Kind { get; }

    string ConnectionString { get; }

    void EnsureDatabaseExists();

    Task EnsureDatabaseExistsAsync(CancellationToken cancellationToken = default);

    bool IsTableExists(string tableName);

    Task<bool> IsTableExistsAsync(string tableName, CancellationToken cancellationToken = default);

    bool IsTableExists<T>();

    Task<bool> IsTableExistsAsync<T>(CancellationToken cancellationToken = default);

    void CreateTable<T>();

    Task CreateTableAsync<T>(CancellationToken cancellationToken = default);

    int ExecuteNonQuery(string sql, object? parameters = null);

    Task<int> ExecuteNonQueryAsync(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);

    T? ExecuteScalar<T>(string sql, object? parameters = null);

    Task<T?> ExecuteScalarAsync<T>(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);

    IEnumerable<T> Query<T>(string sql, object? parameters = null);

    Task<IReadOnlyList<T>> QueryAsync<T>(
        string sql,
        object? parameters = null,
        CancellationToken cancellationToken = default);

    bool Insert<T>(T entity);

    Task<bool> InsertAsync<T>(T entity, CancellationToken cancellationToken = default);

    bool Update<T>(T entity);

    Task<bool> UpdateAsync<T>(T entity, CancellationToken cancellationToken = default);

    bool Delete<T>(T entity);

    Task<bool> DeleteAsync<T>(T entity, CancellationToken cancellationToken = default);
}
