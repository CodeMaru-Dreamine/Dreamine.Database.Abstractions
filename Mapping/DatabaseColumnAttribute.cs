namespace Dreamine.Database.Abstractions.Mapping;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public sealed class DatabaseColumnAttribute : Attribute
{
    public DatabaseColumnAttribute(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        Name = name;
    }

    public string Name { get; }
}
