namespace Dreamine.Database.Abstractions.Mapping;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class DatabaseTableAttribute : Attribute
{
    public DatabaseTableAttribute(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        Name = name;
    }

    public string Name { get; }
}
