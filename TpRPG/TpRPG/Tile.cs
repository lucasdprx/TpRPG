namespace TpRPG;

public class Tile
{
    public Action<Entity> entered { get; private set; }
    public Action<Entity> exit { get; private set; }
    private List<IObject> objects = new();
    private List<Entity> entities = new();

    public void EnterTile(Entity enteredEntity)
    {
        entered?.Invoke(enteredEntity);
    }

    public void ExitTile(Entity exitedEntity)
    {
        exit?.Invoke(exitedEntity);
    }

    public void OnEntered(Action<Entity> action)
    {
        entered += action;
    }
    
    public void OnExit(Action<Entity> action)
    {
        exit += action;
    }
    
    public void AddObject(IObject obj)
    {
        objects.Add(obj);
    }
    
    public void RemoveObject(IObject obj)
    {
        objects.Remove(obj);
    }
    
    public void AddEntity(Entity entity)
    {
        entities.Add(entity);
    }
    
    public void RemoveEntity(Entity entity)
    {
        entities.Remove(entity);
    }
    
    public IEnumerable<IObject> GetObjects()
    {
        foreach (var obj in objects)
        {
            yield return obj;
        }
    }
    
    public IEnumerable<Entity> GetEntities()
    {
        foreach (var entity in entities)
        {
            yield return entity;
        }
    }
}