using System.Numerics;

namespace TpRPG;

public class MovementCommand : ICommand
{
    private (int, int) direction;
    private Entity player;
    
    public MovementCommand(Entity player, (int, int) direction)
    {
        this.direction = direction;
        this.player = player;
    }
    
    
    public void Execute()
    {   
        var currentPosition = player.position;
        var newPosition = (currentPosition.Item1 + direction.Item1, currentPosition.Item2 + direction.Item2);
        player.SetPosition(newPosition);
    }
}