namespace TpRPG;

public interface IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref int currentDamage);
}