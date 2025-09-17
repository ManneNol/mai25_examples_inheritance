namespace GameInventory;

class Weapon : Item
{
    public int Damage;

    public Weapon(string name, int dmg) : base(name)
    {
        Damage = dmg;
    }

    public override string Info()
    {
        return Name + " " + Damage;
    }
}
