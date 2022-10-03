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
Console.WriteLine("Please type out the player who wants to start");
while (p1.hp > 0 || p2.hp > 0)
{
}


Console.ReadLine();