using System;

public class Weapon
{
    private int maxDamage = 10;
    private int minDamage = 0;
    private int weaponWeight;
    public string name;
    private Random generator = new();


    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}