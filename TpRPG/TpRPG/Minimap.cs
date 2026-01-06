namespace TpRPG;

public class Minimap
{
    private Entity player;
    private Tilemap tilemap;

    public Minimap(Tilemap tilemap , Entity player)
    {
        this.tilemap = tilemap;
        this.player = player;
    }

    public void Display()
    {
        string map = "+-----------------+\n";
        for (int y = tilemap.width; y >= 0; y--)
        {
            map += "|";
            for (int x = 0; x <= tilemap.height; x++)
            {
                bool hasSomething = false;
                if (x == player.position.Item1 && y == player.position.Item2)
                {
                    map += "P";
                    if(tilemap.GetTile((x, y))?.GetEntities() != null && tilemap.GetTile((x, y))!.GetEntities().Any(e => e != player) || 
                       tilemap.GetTile((x, y))?.GetObjects() != null && tilemap.GetTile((x, y))!.GetObjects().Any())
                    {
                        map += "/";
                    }
                    hasSomething = true;
                }
                if(tilemap.GetTile((x, y))?.GetEntities() != null && tilemap.GetTile((x, y))!.GetEntities().Any())
                {
                    map += "E";
                    hasSomething = true;
                }
                if( tilemap.GetTile((x, y))?.GetObjects() != null && tilemap.GetTile((x, y))!.GetObjects().Any())
                {
                    map += "O";
                    hasSomething = true;
                }
                if (tilemap.GetTile((x, y)) != null && !hasSomething)
                {
                    map += "#";
                }
            }

            map += "|\n";
        }

        map += "+-----------------+";
        Console.WriteLine(map);
    }
}