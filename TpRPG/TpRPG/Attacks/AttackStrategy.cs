namespace TpRPG;

public class AttackStrategy : IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref float currentDamage)
    {
        currentDamage += attacker.damage;
    }
}