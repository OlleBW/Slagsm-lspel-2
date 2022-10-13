using System;

Player p1 = new();
p1.weapon = new();
Player p2 = new();
p2.name = "Gurt";
p2.weapon = new();
OpWeapon Excalibur = new();

bool nameConfirm = false;
while (nameConfirm == false)
{
    Console.WriteLine("Please Write your name below:");
    p1.name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Are you sure you want your name to be {p1.name}");
    Console.WriteLine("Write YES or NO");
    string answer = Console.ReadLine();
    answer = answer.ToLower();
    if (answer == "yes")
    {
        nameConfirm = true;
    }
    Console.Clear();
}

Console.WriteLine($"Hello {p1.name} and {p2.name}, Welcome To Fighting Game II!");
Console.WriteLine("Please press Enter to start the fight.");
Console.ReadLine();
Console.Clear();

while (p1.hp > 0 || p2.hp > 0)
{
    Console.WriteLine($"{p1.name} Please pick your weapon of choise:");
    Console.WriteLine("1. Normal Sword");
    Console.WriteLine("2. Very OP Sword");
    string choiseW = Console.ReadLine();
    choiseW = choiseW.ToLower();

    if (choiseW == "1" || choiseW == "one")
    {
        p1.Count();
        Console.Clear();
        printStats();
        int dmg = p1.weapon.Attack();
        p2.hp = p2.hp - dmg;
        Console.WriteLine($"{p1.name} attacks {p2.name} and did {dmg} damage.");
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();
    }
    if (choiseW == "2" || choiseW == "two")
    {
        if (p1.countAtk >= 3)
        {
            Console.Clear();
            printStats();
            int dmg = Excalibur.Attack();
            p2.hp = p2.hp - dmg;
            Console.WriteLine($"{p1.name} used the powerful Excalibur and did {dmg} damage!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You wasted your turn by attempting to use Excalibur without 3 attacks");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }


    Console.Clear();
    printStats();
    Console.WriteLine($"{p2.name} Please pick your weapon of choise:");
    Console.WriteLine("1. Normal Sword");
    Console.WriteLine("2. Very OP Sword");
    string choiseW2 = Console.ReadLine();
    choiseW2 = choiseW2.ToLower();

    if (choiseW2 == "1" || choiseW2 == "one")
    {
        p2.Count();
        Console.Clear();
        printStats();
        int dmg = p2.weapon.Attack();
        p1.hp = p1.hp - dmg;
        Console.WriteLine($"{p2.name} attacks {p1.name} and did {dmg} damage.");
        Console.WriteLine("Press ENTER to continue.");
        Console.ReadLine();
    }
    if (choiseW2 == "2" || choiseW2 == "two")
    {
        if (p2.countAtk >= 3)
        {
            Console.Clear();
            printStats();
            int dmg = Excalibur.Attack();
            p1.hp = p1.hp - dmg;
            Console.WriteLine($"{p2.name} used the powerful Excalibur and did {dmg} damage!");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You wasted your turn by attempting to use Excalibur without 3 attacks");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }

    if (p1.hp < 0)
    { p1.hp = 0; }
    if (p2.hp < 0)
    { p2.hp = 0; }


    Console.Clear();
    printStats();
}


Console.WriteLine("Someone won the fight, I ran out of time :(");
Console.ReadLine();


void printStats()
{
    Console.WriteLine($"{p1.name} HP left: {p1.hp} {p2.name} HP left: {p2.hp}");
    Console.WriteLine($"{p1.name} Attacks: {p1.countAtk} {p2.name} Attacks: {p2.countAtk}");
    Console.WriteLine();
}