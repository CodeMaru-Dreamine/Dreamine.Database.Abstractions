namespace Dreamine.Database.Abstractions;

/// <summary>
/// Identifies the database provider family.
/// </summary>
public enum DatabaseProviderKind
{
    Unknown = 0,
    Sqlite,
    SqlServer,
    MySql,
    Oracle
}
