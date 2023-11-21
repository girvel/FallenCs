namespace EcsCs;

public class Entity
{
    private readonly object[] _components;

    public Entity(object[] components)
    {
        _components = components;
    }

    public T GetComponent<T>() => _components.OfType<T>().First();
}