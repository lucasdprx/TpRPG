namespace TpRPG;

public class BaseEntity : IEntity
{
    public int health { get; set; }
    public int damage { get; set; }
    
    public int defense { get; set; }
    public List<IAttackStrategy> attackStrategies { get; set; } = new();
    public AttackProcessor attackProcessor { get; set; } = new();
    public Action onDeath { get; set; }

    public void Attack(IEntity target)
    {
        attackProcessor.DoAttack(attackStrategies, this, target);
    }
}