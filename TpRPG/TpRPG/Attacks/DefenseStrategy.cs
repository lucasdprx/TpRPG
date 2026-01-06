namespace TpRPG;

public class DefenseStrategy : IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref int currentDamage)
    {
        currentDamage -= target.defense;
    }
}