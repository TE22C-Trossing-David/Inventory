public class Character
{
    public int Hp;
    public string Name;
    public Inventory Backpack;

    public Character()
    {
        Backpack = new();
    }

    public void ItemPickup(string Answer, Item item)
    {
        if (Answer == "1")
        {
            Backpack.itemList.Add(item);
            Console.WriteLine($"You picked up {item.Name}");
        }
        else if (Answer == "2")
        {
            Console.WriteLine($"You leave the {item.Name}");

        }
        else
        {
            Console.WriteLine("You seem confused and leave the item");
        }
    }
}