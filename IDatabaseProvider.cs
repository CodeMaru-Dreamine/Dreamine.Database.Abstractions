namespace Dreamine.Database.Abstractions;

/// <summary>
/// Defines the full database provider surface supported by Dreamine providers.
/// </summary>
/// <remarks>
/// New consumers should depend on the smallest role interface they need, such as
/// <see cref="IDatabaseRepository"/>, <see cref="IDatabaseSchemaProvider"/>,
/// <see cref="IDatabaseQueryProvider"/>, or <see cref="IDatabaseCommandExecutor"/>.
/// This interface remains as a compatibility facade for existing provider consumers.
/// </remarks>
public interface IDatabaseProvider :
    IDatabaseConnection,
    IDatabaseSchemaProvider,
    IDatabaseCommandExecutor,
    IDatabaseQueryProvider,
    IDatabaseRepository
{
}
