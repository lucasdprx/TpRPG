using TpRPG.Attacks;

namespace TpRPG;

public class BaseEntity : IEntity
{
    public int health { get; set; }
    public int damage { get; set; }
    
    public int defense { get; set; }
    public FightResolver fightResolver { get; set; } = new();
    public Action onDeath { get; set; }

    public void Attack(IEntity target)
    {
        fightResolver.Resolve(this, target);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            health = 0;
            onDeath?.Invoke();
        }
    }
}