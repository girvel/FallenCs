namespace EcsCs;

public class Entity
{
    private readonly object[] _components;

    public Entity(params object[] components)
    {
        _components = components;
    }

    public T GetComponent<T>() => _components.OfType<T>().First();
}