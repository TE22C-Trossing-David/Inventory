public class Weapon: Item
{
    public int minDamage;
    public int maxDamage;

    public int attack()
    {
        int damage = Random.Shared.Next(minDamage, maxDamage);
        return damage;
    }
}