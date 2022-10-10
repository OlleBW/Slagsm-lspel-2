using System;

public class Weapon
{
    private int maxDamage = 10;
    private int minDamage = 0;
    public string name;
    private Random generator = new();


    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}

public class OpWeapon
{
    private int maxDamage = 100;
    private int minDamage = 50;
    private string name = "Excalibur";
    private Random generator = new();


    public int Attack()
    {
        return generator.Next(minDamage, maxDamage);
    }
}