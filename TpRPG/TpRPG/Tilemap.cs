namespace TpRPG;

public class Tilemap
{
    Dictionary<(int, int), Tile> tiles = new();
    
    public void AddTile(int x, int y, Tile tile)
    {
        tiles[(x, y)] = tile;
    }
    
    public Tile? GetTile(int x, int y)
    {
        tiles.TryGetValue((x, y), out var tile);
        return tile;
    }
    
    public void RemoveTile(int x, int y)
    {
        tiles.Remove((x, y));
    }
    
    public IEnumerable<((int, int), Tile)> GetAllTiles()
    {
        foreach (var kvp in tiles)
        {
            yield return (kvp.Key, kvp.Value);
        }
    }
}