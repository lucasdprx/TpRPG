namespace TpRPG;

public class CritStrategy : IAttackStrategy
{
    public void DoAttackStrategy(IEntity attacker, IEntity target, ref int currentDamage)
    {
        float random = new Random().NextSingle();
        if (random <= 0.25f)
        {
            Console.WriteLine("Critical Hit!");
            currentDamage *= 2;
            return;
        }
        Console.WriteLine("Failed Crits!");
    }
}