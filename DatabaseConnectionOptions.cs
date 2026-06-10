namespace Dreamine.Database.Abstractions;

/// <summary>
/// Provides connection settings for a Dreamine database provider.
/// </summary>
public sealed class DatabaseConnectionOptions
{
    public DatabaseConnectionOptions(string connectionString)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString);
        ConnectionString = connectionString;
    }

    public string ConnectionString { get; }
}
