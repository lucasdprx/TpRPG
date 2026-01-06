namespace TpRPG.Attacks;

public class FightResolver
{
    private List<IAttackStrategy> strategies = new();
    
    public FightResolver()
    {
        strategies.Add(new AttackStrategy());
        strategies.Add(new DefenseStrategy());
        strategies.Add(new CritStrategy());
    }

    public int Resolve(IEntity attacker, IEntity target)
    { 
        int currentDamage = 0;
        
        foreach (var strategy in strategies)
        {
            strategy.DoAttackStrategy(attacker, target, ref currentDamage);
        }
        
        target.TakeDamage(currentDamage);
    }
}