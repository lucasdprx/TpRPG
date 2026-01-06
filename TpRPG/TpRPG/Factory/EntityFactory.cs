namespace TpRPG.Factory;

public class EntityFactory
{
    private BaseEntity entity = new();

    public EntityFactory AsMonster()
    {
        entity.damage = 15;
        entity.health = 100;
        return this;
    }
    
    public EntityFactory AsPlayer()
    {
        entity.damage = 10;
        entity.health = 150;
        return this;
    }
    
    public EntityFactory AsNpc()
    {
        entity.damage = 5;
        entity.health = 80;
        return this;
    }
    
    public EntityFactory AsBoss()
    {
        entity.damage = 30;
        entity.health = 300;
        return this;
    }

    public EntityFactory WithDamage(int damage)
    {
        entity.damage = damage;
        return this;
    }

    public EntityFactory WithHealth(int health)
    {
        entity.health = health;
        return this;
    }
    
    public EntityFactory WithDefense(int defense)
    {
        entity.defense = defense;
        return this;
    }
    
    
    
    public IEntity Build()
    {
        IEntity currentEntity = entity;
        entity = new BaseEntity();
        return currentEntity;
    }
}