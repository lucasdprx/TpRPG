namespace TpRPG;

public class DefenseStrategy : IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref float currentDamage)
    {
        currentDamage -= target.defense;
    }
}