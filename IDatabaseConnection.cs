namespace Dreamine.Database.Abstractions;

/// <summary>
/// Exposes database provider identity and connection configuration.
/// </summary>
public interface IDatabaseConnection
{
    /// <summary>
    /// Gets the database provider kind.
    /// </summary>
    DatabaseProviderKind Kind { get; }

    /// <summary>
    /// Gets the provider connection string.
    /// </summary>
    string ConnectionString { get; }

    /// <summary>
    /// Ensures the target database can be opened or created by the provider.
    /// </summary>
    void EnsureDatabaseExists();

    /// <summary>
    /// Ensures the target database can be opened or created by the provider.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task EnsureDatabaseExistsAsync(CancellationToken cancellationToken = default);
}
