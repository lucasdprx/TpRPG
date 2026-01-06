
using TpRPG;

class Program
{
    static void Main(string[] args)
    {
        
        
        BaseEntity entity1 = new BaseEntity();
        BaseEntity entity2 = new BaseEntity();
    
        entity1.attackStrategies = new List<IAttackStrategy>()
        {
            new AttackStrategy(),
            new CritStrategy()
        };
    
        entity1.damage = 25;
        entity2.health = 100;
        entity2.defense = 5;
    
        entity1.Attack(entity2);
        Console.WriteLine($"Entity2 Health after attack: {entity2.health}");
        
        Tilemap tilemap = new Tilemap(50, 50);
        Entity player = new Entity("Player qui déchire sa race");
        Entity enemy = new Entity("Super Dragon de la mort qui tue tout");
        enemy.SetPosition((5, 5));
        tilemap.GetTile(enemy.position)?.AddEntity(enemy);
        Minimap minimap = new Minimap(tilemap, player);

        player.SetPosition((0, 0));
        while (true)
        {
            Console.WriteLine("Move player : ");
            (int, int) direction = (0, 0);
            ConsoleKeyInfo character = Console.ReadKey();
            switch (character.Key)
            {
                case ConsoleKey.Z:
                    direction = (0, 1);
                    break;
                case ConsoleKey.S:
                    direction = (0, -1);
                    break;
                case ConsoleKey.Q:
                    direction = (-1, 0);
                    break;
                case ConsoleKey.D:
                    direction = (1, 0);
                    break;
                default:
                    Console.WriteLine("Invalid key, use Z Q S D to move.");
                    continue;
            }

            (int, int) newTilePosition =
                (player.position.Item1 + direction.Item1, player.position.Item2 + direction.Item2);
            Tile? nextTile = tilemap.GetTile(newTilePosition);
            if (nextTile == null)
            {
                Console.WriteLine("You can't move in that direction.");
            }
            else
            {
                MovementCommand moveCommand = new MovementCommand(player, direction);
                moveCommand.Execute();
                var pos = player.position;
                tilemap.MoveEntity(player, (pos.Item1 - direction.Item1, pos.Item2 - direction.Item2), pos);
            }

            Console.WriteLine();
            minimap.Display();
        }
    }
}