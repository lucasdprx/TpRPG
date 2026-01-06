namespace TpRPG;

public interface IEntity
{
    public int health { get; set;  }
    public int damage { get; set;  }
    public int defense { get; set;  }
    public List<IAttackStrategy> attackStrategies { get; set; }
    public AttackProcessor attackProcessor { get; set; }
    public Action onDeath { get; set; }
    
    public void Attack(IEntity target);
}
    
