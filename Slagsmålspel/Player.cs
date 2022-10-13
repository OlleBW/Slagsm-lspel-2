using System;

public class Player
{
    public int countAtk = 0;
    public string name;
    public int hp = 100;
    public int strength;

    public Weapon weapon;

    public void Count()
    {
        countAtk++;
    }
}