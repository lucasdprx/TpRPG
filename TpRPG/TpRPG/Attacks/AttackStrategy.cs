namespace TpRPG;

public class AttackStrategy : IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref int currentDamage)
    {
        currentDamage += attacker.damage;
    }
}