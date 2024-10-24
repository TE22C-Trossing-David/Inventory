public class Inventory
{
    public List<Item> itemList = new List<Item>();

    public void Display()
    {
        int n = 0;
        foreach (var item in itemList)
        {
            n++;
            Console.WriteLine($"{n}) {item.Name}");
        }
    }
}