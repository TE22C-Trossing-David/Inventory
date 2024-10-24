using System.Runtime.CompilerServices;

Character hero = new Character()
{
    Name = "Ludwig",
    Hp = 100,
};

Weapon Bloodoath = new Weapon()
{
    Name = "Bloodoath",
    Weight = 10,
    minDamage = 10,
    maxDamage = 30,
};

Armor Bikini = new Armor()
{
    Name = "Cute Bikini",
    Protection = 100,
    Weight = 1,
};

Consumable jagVetEj = new Consumable()
{
    Name = "Jag Vet Ej",
    Weight = 2,
    UsesMax = 5,
    UsesCount = 5,
};

hero.Backpack.itemList.Add(Bloodoath);
hero.Backpack.itemList.Add(jagVetEj);

while (true)
{
    Console.WriteLine("You see a bikini on the ground");
    Console.WriteLine("1. Pick it up\n2. Leave it");

    hero.ItemPickup(Console.ReadLine(), Bikini);

    hero.Backpack.Display();
    Console.ReadLine();
}

