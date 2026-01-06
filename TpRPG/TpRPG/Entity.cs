namespace TpRPG;

public class Entity
{
    public string name { get; private set; }
    public Entity(string name)
    {
        this.name = name;
    }
    public (int, int) position { get; private set; }

    public void SetPosition((int, int) newPosition)
    {
        position = newPosition;
    }
}