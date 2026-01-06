using TpRPG;

int main()
{
    BaseEntity entity1 = new BaseEntity();
    BaseEntity entity2 = new BaseEntity();
    
    entity1.attackStrategies = new List<IAttackStrategy>()
    {
        new AttackStrategy(),
        new CritStrategy()
    };
    
    entity1.damage = 25;
    entity2.health = 100;
    entity2.defense = 5;
    
    entity1.Attack(entity2);
    Console.WriteLine($"Entity2 Health after attack: {entity2.health}");
    
    return 0;
}

main();