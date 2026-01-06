namespace TpRPG;

public class Tile
{
    private Action<IObject> entered;
    private Action<IObject> exit;
    private List<IObject> objects;

    public void EnterTile(IObject enteredObject)
    {
        entered?.Invoke(enteredObject);
    }

    public void ExitTile(IObject exitedObject)
    {
        exit?.Invoke(exitedObject);
    }
}