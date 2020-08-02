using System;

class Monster 
{
    int level;
    int health;
    int attack;
    int defence;

    public Monster(int level, int health, int attak, int defence) 
    {
        this.level = level;
        this.health = health;
        this.attack = attack;
        this.defence = defence;
    }

    public int damage() 
    {
        return level + attack;
    }

    public bool isDead() 
    {
        if (health <= 0) 
        {
            return true;
        }

        return false;
    }

    public int getInitiative()
    {
        Random r = new Random(DateTime.Today.ToFileTimeUtc());
        return r.Next(1,100);
        
    }
}