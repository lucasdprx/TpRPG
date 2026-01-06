using TpRPG.Attacks;

namespace TpRPG;

public interface IEntity
{
    public int health { get; set;  }
    public int damage { get; set;  }
    public int defense { get; set;  }
    public FightResolver fightResolver { get; set; }
    public Action onDeath { get; set; }
    
    public void Attack(IEntity target);

    public void TakeDamage(int damage);
}
    
