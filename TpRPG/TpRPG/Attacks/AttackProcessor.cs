namespace TpRPG;

public class AttackProcessor
{
    private Type[] attackStrategyOrder =
    [
        typeof(AttackStrategy),
        typeof(DefenseStrategy),
        typeof(CritStrategy)
    ];
    
    public void DoAttack(List<IAttackStrategy> attackStrategies, IEntity attacker, IEntity target)
    {
        attackStrategies.Add(new DefenseStrategy());
        attackStrategies = attackStrategies.OrderBy(
            strategy => Array.IndexOf(attackStrategyOrder, strategy.GetType())
        ).ToList();
        float _currentDamage = 0;
        foreach (IAttackStrategy attackStrategy in attackStrategies)
        {
            attackStrategy.DoAttackStrategy(attacker, target, ref _currentDamage);
        }
        target.health -= (int)_currentDamage;
        if (target.health <= 0)
        {
            target.health = 0;
            target.onDeath?.Invoke();
        }
    }
}