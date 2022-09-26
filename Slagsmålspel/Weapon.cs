using System;

public class Weapon
{
    public int maxDamage = 10;
    public int minDamage = 0;
    public int weaponWeight;
    public string name;
    private Random generator = new();


    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}