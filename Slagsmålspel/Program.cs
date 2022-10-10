using System;

Player p1 = new();
p1.weapon = new();
Player p2 = new();
p2.name = "Gurt";
p2.weapon = new();

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

    if (choiseW == "1" || choiseW == "one" || choiseW == "normal" || choiseW == "normal sword")
    {
        Console.WriteLine("test");
        Console.ReadLine();
    }
    if (choiseW == "2" || choiseW == "two" || choiseW == "very op" || choiseW == "very op sword" || choiseW == "op" || choiseW == "op sword")
    {
        Console.WriteLine("test2");
        Console.ReadLine();
    }

    Console.Clear();
    Console.WriteLine($"{p2.name} Please pick your weapon of choise:");
    Console.WriteLine("1. Normal Sword");
    Console.WriteLine("2. Very OP Sword");
    string choiseW2 = Console.ReadLine();
    choiseW2 = choiseW2.ToLower();

    if (choiseW2 == "1" || choiseW2 == "one" || choiseW2 == "normal" || choiseW2 == "normal sword")
    {
        Console.WriteLine("test");
    }
    if (choiseW2 == "2" || choiseW2 == "two" || choiseW2 == "very op" || choiseW2 == "very op sword" || choiseW2 == "op" || choiseW2 == "op sword")
    {
        Console.WriteLine("test2");
    }
}


Console.ReadLine();