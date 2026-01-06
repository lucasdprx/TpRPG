namespace TpRPG;

public class Tilemap
{
    public int width { get; }
    public int height { get; }

    public Tilemap(int width, int height)
    {
        this.width = width;
        this.height = height;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                tiles[(x, y)] = new Tile();
                var localX = x;
                var localY = y;
                tiles[(x, y)].OnEntered(_ =>
                {
                    Console.WriteLine($"Player new position : ({localX}, {localY})");
                    if (tiles[(localX, localY)].GetEntities().Any())
                    {
                        Console.WriteLine("Entities on this tile : " + string.Join(", ",
                            tiles[(localX, localY)].GetEntities().Select(e => e.name)));
                    }

                    if (tiles[(localX, localY)].GetObjects().Any())
                    {
                        Console.Write("Objects on this tile : " + string.Join(", ",
                            tiles[(localX, localY)].GetObjects().Select(o => o.GetName())));
                    }
                });
            }
        }
    }

    private Dictionary<(int, int), Tile> tiles = new();

    public void AddTile(int x, int y, Tile tile)
    {
        tiles[(x, y)] = tile;
    }

    public Tile? GetTile((int, int ) position)
    {
        tiles.TryGetValue(position, out var tile);
        return tile;
    }

    public void RemoveTile((int, int) position)
    {
        tiles.Remove(position);
    }

    public IEnumerable<((int, int), Tile)> GetAllTiles()
    {
        foreach (var kvp in tiles)
        {
            yield return (kvp.Key, kvp.Value);
        }
    }

    public void MoveEntity(Entity entity, (int, int) oldPosition, (int, int) newPosition)
    {
        var oldTile = GetTile(oldPosition);
        var newTile = GetTile(newPosition);

        oldTile?.ExitTile(entity);

        newTile?.EnterTile(entity);
    }
}